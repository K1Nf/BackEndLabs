using BackEndLabs.Contracts;
using BackEndLabs.Data;
using BackEndLabs.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndLabs.Controllers
{
    [ApiController]
    [Route("api/ref/[controller]")]
    public class UserController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;

        [HttpGet]
        [Authorize(Policy = "PermissionLimit")]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _context.Users
                .Include(u => u.Roles)
                    // roles where userandroles.deleted_by is not null // add queryfilter?
                .ToListAsync());
        }


        [HttpGet("{id:int}/role")]
        [Authorize(policy: "get")]
        public async Task<IActionResult> GetUserRoles(int id)
        {
            var userRoles = await _context.UsersAndRoles
                .Include(x => x.Role)
                .Where(u => u.UserId == id)
                .ToListAsync();

            var roles = userRoles
                .Select(x => x.Role)
                .ToList();

            return Ok(roles);
        }


        [HttpPost("{userId:int}/role/{roleId:int}")]
        public async Task<IActionResult> AddRoleToUser(int userId, int roleId) // [frombody] roleId???
        {
            var userAndRole = new UsersAndRoles()
            {
                RoleId = roleId,
                UserId = userId,
                Created_At = DateTime.UtcNow,
                Created_By = 1,
            };

            await _context.UsersAndRoles.AddAsync(userAndRole);
            await _context.SaveChangesAsync();

            return Ok();
        }



        [HttpDelete("{userId:int}/role/{roleId:int}/soft")]
        public async Task<IActionResult> SoftDeleteRole(int userId, int roleId)
        {
            await _context.UsersAndRoles
                .Where(u => u.UserId == userId && u.RoleId == roleId)
                    .ExecuteUpdateAsync(p => p
                        .SetProperty(ur => ur.Deleted_At, DateTime.UtcNow)
                        .SetProperty(ur => ur.Deleted_By, userId)
                    );

            return Ok();
        }



        [HttpDelete("{userId:int}/role/{roleId:int}")]
        public async Task<IActionResult> RudeDeleteRole(int userId, int roleId)
        {
            await _context.UsersAndRoles
                .IgnoreQueryFilters()
                .Where(u => u.UserId == userId && u.RoleId == roleId)
                    .ExecuteDeleteAsync();

            return Ok();
        }



        [HttpPost("{userId:int}/role/{roleId:int}/restore")]
        public async Task<IActionResult> RestoreDeletedRole(int userId, int roleId)
        {
            await _context.UsersAndRoles
                .IgnoreQueryFilters()
                .Where(u => u.UserId == userId && u.RoleId == roleId)
                    .ExecuteUpdateAsync(p => p
                        .SetProperty(ur => ur.Deleted_At, ur => null)
                        .SetProperty(ur => ur.Deleted_By, ur => null)
                    );

            return Ok();
        }
    }
}
