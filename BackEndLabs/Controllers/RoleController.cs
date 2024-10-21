using BackEndLabs.Contracts;
using BackEndLabs.Data;
using BackEndLabs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndLabs.Controllers
{
    [ApiController]
    [Route("api/ref/policy/[controller]")]
    public class RoleController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;

        [HttpGet] 
        public async Task<IActionResult> GetAllRoles()
        {
            return Ok(await _context.Roles
                .Include(r => r.Permissions)
                .ToListAsync());
        }


        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetRole(int id)
        {
            return Ok(await _context.Roles
                .FindAsync(id));
        }


        [HttpPost]
        public async Task<IActionResult> CreateRole([FromForm] RoleCreateRequest roleCreateRequest )
        {
            var role = new Role()
            {
                Code = roleCreateRequest.Code,
                Name = roleCreateRequest.Name,
                Description = roleCreateRequest.Description,
                Created_At = DateTime.UtcNow,
                Created_By = 2
            };

            await _context.Roles.AddAsync(role);
            await _context.SaveChangesAsync();
            return Created("", role);
        }


        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateRole(int id, [FromForm] RoleUpdateRequest roleUpdateRequest)
        {
            await _context.Roles.Where(r => r.Id == id)
                .ExecuteUpdateAsync(p => p
                    .SetProperty(r => r.Code, r => roleUpdateRequest.Code ?? r.Code)
                    .SetProperty(r => r.Description, r => roleUpdateRequest.Description ?? r.Description)
                    .SetProperty(r => r.Name, r => roleUpdateRequest.Name ?? r.Name)
                );

            return Ok();
        }


        [HttpDelete("{id:int}/soft")]
        public async Task<IActionResult> SoftDeleteRole(int id)
        {
            await _context.Roles
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
            await _context.Roles
                .Where(r => r.Id == id)
                .IgnoreQueryFilters()
                .ExecuteDeleteAsync();

            return Ok();
        }


        [HttpPost("{id:int}/restore")]
        public async Task<IActionResult> RestoreDeletedRole(int id)
        {
            var roles = await _context.Roles
                .IgnoreQueryFilters()
                .Where(r => r.Id == id)
                .ToListAsync();

            roles.ForEach(r =>
            {
                r.Deleted_By = null;
                r.Deleted_At = null;
            });
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
