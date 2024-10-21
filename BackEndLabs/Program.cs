using BackEndLabs.Data;
using BackEndLabs.Extensions;
using BackEndLabs.JWT;
using BackEndLabs.Middlewares;
using BackEndLabs.Models;
using BackEndLabs.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnectionString"));
});

builder.Services.AddScoped<JwtProvider>();
builder.Services.AddScoped<TokenService>();



builder.Services.AddScoped<IAuthorizationHandler, PermissionsHandler>();


builder.Services.Configure<JWTConfiguration>(builder.Configuration.GetSection(nameof(JWTConfiguration)));

builder.Services.AddControllers();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, o =>
    {
        var jwt = builder.Configuration.GetSection(nameof(JWTConfiguration));

        var key = jwt.GetSection(nameof(JWTConfiguration.SecretKey));
        var issuer = jwt.GetSection(nameof(JWTConfiguration.Issuer));
        var audience = jwt.GetSection(nameof(JWTConfiguration.Audience));

        o.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuer = false,
            ValidIssuer = issuer.Value,

            ValidateAudience = true,
            ValidAudience = audience.Value,

            ValidateLifetime = true,
            RequireExpirationTime = true,

            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(key.Value!))
        };


        o.Events = new JwtBearerEvents
        {
            OnMessageReceived = context =>
            {
                context.Token = context.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
                Console.Write("Current token is: ");
                Console.WriteLine(context.Token);
                return Task.CompletedTask;
            }
        };
    });


builder.Services.AddAuthorization(opts => {
    // устанавливаем ограничение по возрасту
    opts.AddPolicy("PermissionLimit", policy => policy.Requirements.Add(new PermissionRequirements()));
});


var app = builder.Build();


app.UseHsts();
app.UseHttpsRedirection();

app.UseRouting();

app.UseStaticFiles();


app.UseAuthentication();

//app.UseMiddleware<JwtBlacklistMiddleware>();

app.UseAuthorization();



app.MapControllers();

app.UseDefaultFiles();

app.MapGet("/", (context) =>
{
    context.Response.Redirect("index.html");
    return Task.CompletedTask;
});
//    .RequireAuthorization(r =>
//{
//    r.Requirements.Add(new PermissionRequirements(new Permission[ new () { } ]));
//});
app.Run();
