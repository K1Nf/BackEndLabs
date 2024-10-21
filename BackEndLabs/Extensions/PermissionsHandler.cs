using BackEndLabs.Data;
using BackEndLabs.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BackEndLabs.Extensions
{
    public class PermissionsHandler(ApplicationDbContext context) : AuthorizationHandler<PermissionRequirements>
    {
        private readonly ApplicationDbContext _context = context;

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
            PermissionRequirements requirement)
        {
            Claim? claim = context.User.Claims
                .SingleOrDefault(c => c.Type == "UserIdentity");


            if (claim == null)
            {
                context.Fail();
                return Task.CompletedTask;
            }

            int userId = int.Parse(claim!.Value);


            var userPermissions = _context.UsersAndRoles
                .Where(ur => ur.UserId == userId)
                .Include(ur => ur.Role)
                    .ThenInclude(r => r.Permissions)
                    .Select(r => r.Role)
                        .SelectMany(r => r.Permissions)
                        .Select(p => p.Name)
                .ToList();

            var identities = context.User.Identities;


            return Task.CompletedTask;
        }
    }
}
