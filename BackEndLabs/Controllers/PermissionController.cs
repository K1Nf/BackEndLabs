using BackEndLabs.Contracts;
using BackEndLabs.Data;
using BackEndLabs.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndLabs.Controllers
{
    [ApiController]
    [Route("api/ref/policy/[controller]")]
    public class PermissionController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;

        [HttpGet]
        public async Task<IActionResult> GetAllPermissions()
        {
            return Ok(await _context.Permissions.ToListAsync());
        }


        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetPermissionById(int id)
        {
            return Ok(await _context.Permissions.FindAsync(id));
        }


        [HttpPost]
        public async Task<IActionResult> CreatePermission(PermissionCreateRequest permissionCreateRequest)
        {
            var permission = new Permission()
            {
                Code = permissionCreateRequest.Code,
                Name = permissionCreateRequest.Name,
                Description = permissionCreateRequest.Description,
            };

            await _context.Permissions.AddAsync(permission);
            await _context.SaveChangesAsync();


            return Created();
        }



        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdatePermission(int id, 
            [FromForm] PermissionUpdateRequest permissionUpdateRequest)
        {
            await _context.Permissions.Where(r => r.Id == id)
                .ExecuteUpdateAsync(p => p
                    .SetProperty(r => r.Code, r => permissionUpdateRequest.Code ?? r.Code)
                    .SetProperty(r => r.Description, r => permissionUpdateRequest.Description ?? r.Description)
                    .SetProperty(r => r.Name, r => permissionUpdateRequest.Name ?? r.Name)
                );

            return Ok();
        }


        [Authorize(Roles = "Admin,User")]
        [HttpDelete("{id:int}/soft")]
        public async Task<IActionResult> SoftDeleteRole(int id)
        {


            int userId = int.Parse(User.FindFirst("UserIdentity")!.Value);

            await _context.Permissions
                .Where(r => r.Id == id)
                    .ExecuteUpdateAsync(p => p
                        .SetProperty(r => r.Deleted_At, DateTime.UtcNow)
                        .SetProperty(r => r.Deleted_By, 1)
                    );

            return Ok();
        }



        [HttpDelete("{id:int}")]
        public async Task<IActionResult> RudeDeleteRole(int id)
        {
            await _context.Permissions
                .Where(r => r.Id == id)
                .IgnoreQueryFilters()
                .ExecuteDeleteAsync();

            return Ok();
        }


        [HttpPost("{id:int}/restore")]
        public async Task<IActionResult> RestoreDeletedRole(int id)
        {
            var permissions = await _context.Permissions
                .IgnoreQueryFilters()
                .Where(r => r.Id == id)
                .ToListAsync();

            permissions.ForEach(p =>
            {
                p.Deleted_By = null;
                p.Deleted_At = null;
            });
            _context.SaveChanges();

            return Ok();
        }
    }
}
