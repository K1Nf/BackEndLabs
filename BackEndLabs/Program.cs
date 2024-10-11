var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
var app = builder.Build();


app.UseStaticFiles();

app.MapControllers();

app.MapGet("/", (context) =>
{
    context.Response.Redirect("index.html");
    return Task.CompletedTask;
});
app.Run();
