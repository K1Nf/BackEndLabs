using BackEndLabs.Background;
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
using System.Net;
using System.Text;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnectionString"));
});

builder.Services.AddScoped<JwtProvider>();
builder.Services.AddScoped<TokenService>();


builder.Services.AddScoped<IAuthorizationHandler, PermissionsHandler>();
builder.Services.AddHttpContextAccessor();


builder.Services.AddHostedService<BackgroundTask>();


builder.Services.Configure<FileFormatter>(builder.Configuration.GetSection(nameof(FileFormatter)));
builder.Services.Configure<JWTConfiguration>(builder.Configuration.GetSection(nameof(JWTConfiguration)));
builder.Services.Configure<JobConfiguration>(builder.Configuration.GetSection(nameof(JobConfiguration)));



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
                string? token = context.Request.Cookies["NeToken"] ?? context.Request.Headers.Authorization.ToString().Replace("Bearer ", "");

                if (token != null)
                {
                    context.Token = token.Replace("Bearer ", "");
                }

                Console.Write("Current token is: ");
                Console.WriteLine(context.Token);
                return Task.CompletedTask;
            }
        };
    });


builder.Services.ConfigureAuthorization();


var app = builder.Build();


app.UseHsts();
app.UseHttpsRedirection();

app.UseRouting();

app.UseStatusCodePages(async context => {

    var request = context.HttpContext.Request;
    var response = context.HttpContext.Response;

    if (response.StatusCode == (int)HttpStatusCode.Unauthorized)
    {
        response.Redirect("/authorize/login");
    }

    response.ContentType = "text/plain; charset=utf-8";
    await response.WriteAsync("Unexpected error with code: " + response.StatusCode);
});

app.UseStaticFiles();
app.UseDefaultFiles();


app.UseAuthentication();
app.UseMiddleware<JwtBlacklistMiddleware>();

app.UseMiddleware<LogRequestMiddleware>();


app.UseAuthorization();


app.MapControllers();


/*app.MapGet("/AccessDenied", (context) =>
//{
//    context.Response.Headers.ContentType = "text/html";
//    context.Response.StatusCode = 403;
//    context.Response.SendFileAsync("wwwroot/html/accessDenied.html");
//    return Task.CompletedTask;
});*/

app.MapGet("/authorize/login", async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    context.Response.StatusCode = 401;
    await context.Response.SendFileAsync("wwwroot/html/LoginPage.html");
});


app.Run();
