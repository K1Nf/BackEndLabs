using BackEndLabs.Contracts.Request;
using BackEndLabs.Contracts.Response;
using BackEndLabs.Data;
using BackEndLabs.Enum;
using BackEndLabs.Models;
using BackEndLabs.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Transactions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BackEndLabs.Controllers
{
    [ApiController]
    [Route("api/ref/policy/[controller]")]
    public class RoleController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;

        [HttpGet]
        [Authorize(Policy = nameof(PermissionsNames.get_list_role))]
        public async Task<IActionResult> GetAllRoles()
        {
            return Ok(await _context.Roles
                .OrderBy(r => r.Id)
                .Include(r => r.Permissions)
                .ToListAsync());
        }



        [HttpGet("{id:int}")]
        [Authorize(Policy = nameof(PermissionsNames.read_role))]
        public async Task<IActionResult> GetRole(int id)
        {
            return Ok(await _context.Roles
                .Include(r => r.Permissions)
                .FirstOrDefaultAsync(r => r.Id == id));
        }



        [HttpPost]
        [Authorize(Policy = nameof(PermissionsNames.create_role))]
        public async Task<IActionResult> CreateRole([FromBody] RoleCreateRequest roleCreateRequest )
        {

            int userId = int.Parse(User.FindFirst("UserIdentity")!.Value);


            var role = new Role()
            {
                Code = roleCreateRequest.Code,
                Name = roleCreateRequest.Name,
                Description = roleCreateRequest.Description,
                Created_At = DateTime.UtcNow,
                Created_By = userId
            };
            
            await _context.Roles.AddAsync(role);
            await _context.SaveChangesAsync();
            return Created();
        }



        [HttpPut("{id:int}")]
        [Authorize(Policy = nameof(PermissionsNames.update_role))]
        public async Task<IActionResult> UpdateRole([FromRoute] int id, [FromBody] RoleUpdateRequest roleUpdateRequest)
        {
            int userId = int.Parse(User.FindFirst("UserIdentity")!.Value);


            Role? oldRole = await _context.Roles
                .AsNoTracking()
                .FirstOrDefaultAsync(r => r.Id == id);

            if (oldRole == null)
            {
                return BadRequest($"Роль с id {id} не найдена! ");
            }

            string oldValue = JsonSerializer.Serialize(oldRole);


            var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                await _context.Roles
                    .Where(c => c.Id == id)
                    .ExecuteUpdateAsync(r => r
                        .SetProperty(p => p.Name, roleUpdateRequest.Name)
                        .SetProperty(p => p.Description, roleUpdateRequest.Description)
                );

                Role? newRole = await _context.Roles
                    .AsNoTracking()
                    .FirstOrDefaultAsync(r => r.Id == id);

                string newValue = JsonSerializer.Serialize(newRole);

                ChangeLogs changesLog = new()
                {
                    EntityName = nameof(Role),
                    EntityId = id,
                    Created_By = userId,
                    OldValue = oldValue,
                    NewValue = newValue
                };

                await _context.ChangeLogs.AddAsync(changesLog);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

            }
            catch (TransactionAbortedException ex)
            {
                await transaction.RollbackAsync();
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                Console.WriteLine(ex.Message);
            }

            return Ok();
        }



        [HttpDelete("{id:int}/soft")]
        [Authorize(Policy = nameof(PermissionsNames.delete_role))]
        public async Task<IActionResult> SoftDeleteRole(int id)
        {
            await _context.Roles
                .Where(r => r.Id == id)
                    .ExecuteUpdateAsync(p => p
                        .SetProperty(r => r.Deleted_At, DateTime.UtcNow)
                        .SetProperty(r => r.Deleted_By, 1)
                    );

            return NoContent();
        }



        [HttpDelete("{id:int}")]
        [Authorize(Policy = nameof(PermissionsNames.delete_role))]
        public async Task<IActionResult> RudeDeleteRole(int id)
        {
            await _context.Roles
                .Where(r => r.Id == id)
                .IgnoreQueryFilters()
                .ExecuteDeleteAsync();

            return NoContent();
        }



        [HttpPost("{id:int}/restore")]
        [Authorize(Policy = nameof(PermissionsNames.restore_role))]
        public async Task<IActionResult> RestoreDeletedRole(int id)
        {
            var role = await _context.Roles
                .IgnoreQueryFilters()
                .FirstOrDefaultAsync(r => r.Id == id);

            if (role == null)
            {
                return BadRequest();
            }

            role.Deleted_By = null;
            role.Deleted_At = null;

            await _context.SaveChangesAsync();

            return Ok();
        }



        [HttpPost("{roleId:int}/permission/{permissionId:int}")]
        [Authorize(Policy = nameof(PermissionsNames.update_role))]
        public async Task<IActionResult> AddPermissionToRole(int roleId, int permissionId)
        {
            int userId = int.Parse(User.FindFirst("UserIdentity")!.Value);
            RolesAndPermissions rolesAndPermissions = new()
            {
                RoleId = roleId,
                PermissionId = permissionId,
                Created_At = DateTime.UtcNow,
                Created_By = userId
            };
            await _context.RolesAndPermissions.AddAsync(rolesAndPermissions);
            await _context.SaveChangesAsync();

            return Ok();
        }



        [HttpDelete("{roleId:int}/permission/{permissionId:int}")]
        [Authorize(Policy = nameof(PermissionsNames.update_role))]
        public async Task<IActionResult> RemovePermissionFromRole(int roleId, int permissionId)
        {
            await _context.RolesAndPermissions.
                Where(rp => rp.RoleId == roleId && rp.PermissionId == permissionId)
                .ExecuteDeleteAsync();
            return Ok();
        }



        [HttpGet("{id:int}/story")]
        [Authorize(Policy = nameof(PermissionsNames.get_story_role))]
        public async Task<IActionResult> GetRoleChangesStory(int id)
        {
            var roleStory = await _context.ChangeLogs
                .Where(c => c.EntityName == nameof(Role) && c.EntityId == id)
                .ToListAsync();


            List<ChangeLogsDTO> changesLogsDTO = [];
            foreach (var changeLog in roleStory)
            {
                Role? oldRole = JsonSerializer.Deserialize<Role>(changeLog.OldValue);
                Role? newRole = JsonSerializer.Deserialize<Role>(changeLog.NewValue);

                PropertyInfo[] properties = typeof(Role).GetProperties();

                StringBuilder oldValuesStringBuilder = new();
                StringBuilder newValuesStringBuilder = new();
                foreach (PropertyInfo property in properties)
                {
                    if (!property.PropertyType.IsGenericType)
                    {
                        string propertyName = property.Name;
                        object? oldPropertyValue = property.GetValue(oldRole);
                        object? newPropertyValue = property.GetValue(newRole);

                        if (!Equals(oldPropertyValue, newPropertyValue))
                        {
                            oldValuesStringBuilder.Append(propertyName + ": " + oldPropertyValue + "\n ");
                            newValuesStringBuilder.Append(propertyName + ": " + newPropertyValue + "\n ");
                        }
                    }
                }
                changesLogsDTO.Add(new ChangeLogsDTO()
                {
                    Id = changeLog.Id,
                    EntityId = id,
                    EntityName = nameof(Role),
                    NewValue = newValuesStringBuilder.ToString(),
                    OldValue = oldValuesStringBuilder.ToString(),
                });
            }



            return Ok(changesLogsDTO);
        }
    }
}
