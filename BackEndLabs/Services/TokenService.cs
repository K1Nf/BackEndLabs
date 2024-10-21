using BackEndLabs.Data;
using BackEndLabs.JWT;
using BackEndLabs.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEndLabs.Services
{
    public class TokenService(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task CreateAndSaveTokenInDataBase(string token, int userId, int timeToLiveInMinutes)
        {
            var tokenEntity = new Token()
            {
                Name = token,
                UserId = userId,
                ExpiresAt = DateTime.UtcNow.AddMinutes(timeToLiveInMinutes),
            };

            await _context.Tokens.AddAsync(tokenEntity);
            await _context.SaveChangesAsync();
        }
    }
}
