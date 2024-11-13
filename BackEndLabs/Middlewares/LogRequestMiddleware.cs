using BackEndLabs.Data;
using BackEndLabs.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text;

namespace BackEndLabs.Middlewares
{
    public class LogRequestMiddleware(RequestDelegate next)
    {
        private readonly RequestDelegate _next = next;

        public async Task Invoke(HttpContext context)
        {
            ApplicationDbContext _context = context.RequestServices
                .GetRequiredService<ApplicationDbContext>();

            Claim? id = context.User.FindFirst("UserIdentity");
            int userId = 0;
            if (id != null)
            {
                userId = int.Parse(id.Value);
            }

            try
            {
                string ip = context.Request.HttpContext.Connection.RemoteIpAddress!
                    .MapToIPv4()
                    .ToString();

                string? actionName = (string?)context.Request.RouteValues["Action"];
                string? controllerName = (string?)context.Request.RouteValues["Controller"];


                await _next(context);

                StringBuilder stringBuilder = new ();
                string requestBody = "";
                if (context.Request.Method != "GET")
                {
                    foreach (var item in context.Request.Form)
                    {
                        stringBuilder.Append(item.Key + " = ");
                        stringBuilder.Append(item.Value + "; ");
                    };
                    requestBody = stringBuilder.ToString();
                }



                StringBuilder stringBuilderHeaders = new ();
                foreach (var item in context.Request.Headers)
                {
                    stringBuilderHeaders.Append(item.Key + " = ");
                    stringBuilderHeaders.Append(item.Value + "; ");
                };
                var requestHeaders = stringBuilderHeaders;



                StringBuilder stringBuilderResponseHeaders = new ();
                foreach (var item in context.Response.Headers)
                {
                    stringBuilderResponseHeaders.Append(item.Key + " = ");
                    stringBuilderResponseHeaders.Append(item.Value + "; ");
                };
                var responseHeaders = stringBuilderResponseHeaders;



                LogsRequests logsRequests = new()
                {
                    ActionName = actionName,
                    ControllerName = controllerName,
                    IpAddress = ip,
                    Method = context.Request.Method,
                    Path = context.Request.Path,
                    RequestBody = requestBody,
                    RequestHeaders = requestHeaders.ToString(),
                    StatusCode = context.Response.StatusCode,
                    UserId = userId,
                    UserAgent = context.Request.Headers.UserAgent!,
                    ResponseBody = "",
                    ResponseHeaders = responseHeaders.ToString(),
                };
                await _context.LogsRequests.AddAsync(logsRequests);
                await _context.SaveChangesAsync();

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
    }
}
