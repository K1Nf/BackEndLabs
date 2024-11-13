using BackEndLabs.Data;
using System;

namespace BackEndLabs.Middlewares
{
    public class JwtBlacklistMiddleware
    {
        private readonly RequestDelegate _next;
       

        public JwtBlacklistMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            // Получаем токен из запроса
            string? token = context.Request.Cookies["NeToken"] ?? context.Request.Headers.Authorization;


            if (!string.IsNullOrWhiteSpace(token))
            {
                ApplicationDbContext _context = context.RequestServices
                    .GetRequiredService<ApplicationDbContext>();


                // Проверяем, есть ли токен в черном списке
                if (!IsDataBaseContainsToken(_context, token))
                {
                    context.Response.StatusCode = 401;
                    context.Response.Cookies.Delete("NeToken");
                    return;
                }
            }
            await _next(context);   
        }

        private bool IsDataBaseContainsToken(ApplicationDbContext _context, string token)
        {
            return _context.Tokens
                .Count(t => t.Name == token) == 1;
        }
    }
}
