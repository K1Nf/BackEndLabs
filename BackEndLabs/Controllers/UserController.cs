using BackEndLabs.Contracts.Response;
using BackEndLabs.Data;
using BackEndLabs.Enum;
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
        [Authorize(Policy = nameof(PermissionsNames.get_list_user))]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _context.Users
                .Include(u => u.Roles)
                .ToListAsync());
        }



        [HttpGet("{id:int}/role")]
        [Authorize(Policy = nameof(PermissionsNames.read_user))]
        public async Task<IActionResult> GetUserRoles(int id)
        {
            var userRoles = await _context.UsersAndRoles
                .Include(x => x.Role)
                .Where(u => u.UserId == id)
                .ToListAsync();

            var roles = userRoles
                .Select(x => x.Role)
                .OrderBy(r => r!.Id)
                .ToList();

            List<RoleDTO> rolesDTO = roles.Select(r => new RoleDTO
            {
                Id = r!.Id,
                Code = r!.Code,
                Description = r.Description,
                Name = r.Name,
            }).ToList();

            return Ok(rolesDTO);
        }



        [HttpPost("{userId:int}/role/{roleId:int}")]
        [Authorize(Policy = nameof(PermissionsNames.create_user))]
        public async Task<IActionResult> AddRoleToUser(int userId, int roleId)
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
        [Authorize(Policy = nameof(PermissionsNames.delete_user))]
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
        [Authorize(Policy = nameof(PermissionsNames.delete_user))]
        public async Task<IActionResult> RudeDeleteRole(int userId, int roleId)
        {
            await _context.UsersAndRoles
                .IgnoreQueryFilters()
                .Where(u => u.UserId == userId && u.RoleId == roleId)
                    .ExecuteDeleteAsync();

            return Ok();
        }



        [HttpPost("{userId:int}/role/{roleId:int}/restore")]
        [Authorize(Policy = nameof(PermissionsNames.restore_user))]
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



        [HttpGet("{id:int}/story")]
        [Authorize(Policy = nameof(PermissionsNames.get_story_user))]
        public async Task<IActionResult> GetUserChangesStory(int id)
        {
            var userStory = await _context.ChangeLogs
                .AsNoTracking()
                .Where(c => c.EntityId == id)
                .ToListAsync();

            List<ChangeLogsDTO> changesLogsDTO = userStory
                .Select(p => new ChangeLogsDTO
                {
                    EntityName = p.EntityName,
                    NewValue = p.NewValue,
                    OldValue = p.OldValue,
                    Id = p.Id,
                    EntityId = id
                }).ToList();

            return Ok(changesLogsDTO);
        }
    }
}
