using BackEndLabs.Contracts.Request;
using BackEndLabs.Contracts.Response;
using BackEndLabs.Data;
using BackEndLabs.Enum;
using BackEndLabs.Models;
using BackEndLabs.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Transactions;

namespace BackEndLabs.Controllers
{
    [ApiController]
    [Route("api/ref/policy/[controller]")]
    public class PermissionController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;



        [HttpGet]
        [Authorize(Policy = nameof(PermissionsNames.get_list_permission))]
        public async Task<IActionResult> GetAllPermissions()
        {
            return Ok(await _context.Permissions.ToListAsync());
        }



        [HttpGet("{id:int}")]
        [Authorize(Policy = nameof(PermissionsNames.read_permission))]
        public async Task<IActionResult> GetPermissionById(int id)
        {
            return Ok(await _context.Permissions.FindAsync(id));
        }



        [HttpPost]
        [Authorize(Policy = nameof(PermissionsNames.create_permission))]
        public async Task<IActionResult> CreatePermission([FromBody] PermissionCreateRequest permissionCreateRequest)
        {
            int userId = int.Parse(User.FindFirst("UserIdentity")!.Value);

            var permission = new Permission()
            {
                Code = permissionCreateRequest.Code,
                Name = permissionCreateRequest.Name,
                Description = permissionCreateRequest.Description,
                Created_At = DateTime.UtcNow,
                Created_By = userId
            };

            await _context.Permissions.AddAsync(permission);
            await _context.SaveChangesAsync();


            return Created();
        }



        [HttpPut("{id:int}")]
        [Authorize(Policy = nameof(PermissionsNames.update_permission))]
        public async Task<IActionResult> UpdatePermission([FromRoute] int id, 
            [FromBody] PermissionUpdateRequest permissionUpdateRequest)
        {
            int userId = int.Parse(User.FindFirst("UserIdentity")!.Value);



            var permission = await _context.Permissions
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id);

            if (permission == null)
            {
                return BadRequest();
            }

            string oldValue = JsonSerializer.Serialize(permission);
            


            var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                await _context.Permissions
                    .Where(c => c.Id == id)
                    .ExecuteUpdateAsync(r => r
                        .SetProperty(p => p.Name, permissionUpdateRequest.Name)
                        .SetProperty(p => p.Description, permissionUpdateRequest.Description)
                );

                Permission? newPermission = await _context.Permissions
                    .AsNoTracking()
                    .FirstOrDefaultAsync(p => p.Id == id);

                string newValue = JsonSerializer.Serialize(newPermission);


                ChangeLogs changesLog = new()
                {
                    EntityName = nameof(Permission),
                    EntityId = id,
                    Created_By = userId,
                    OldValue = oldValue,
                    NewValue = newValue
                };

                await _context.ChangeLogs.AddAsync(changesLog);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch (TransactionException ex)
            {
                Console.WriteLine(ex.Message);
                await transaction.RollbackAsync();
                return BadRequest("Что-то пошло не так! Транзакция не прошла");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                await transaction.RollbackAsync();
                return BadRequest("Что-то пошло не так! Транзакция не прошла");
            }

            return Ok();
        }



        [HttpDelete("{id:int}/soft")]
        [Authorize(Policy = nameof(PermissionsNames.delete_permission))]
        public async Task<IActionResult> SoftDeletePermission(int id)
        {
            int userId = int.Parse(User.FindFirst("UserIdentity")!.Value);

            await _context.Permissions
                .Where(r => r.Id == id)
                    .ExecuteUpdateAsync(p => p
                        .SetProperty(r => r.Deleted_At, DateTime.UtcNow)
                        .SetProperty(r => r.Deleted_By, userId)
                    );

            return NoContent();
        }



        [HttpDelete("{id:int}")]
        [Authorize(Policy = nameof(PermissionsNames.delete_permission))]
        public async Task<IActionResult> RudeDeletePermission(int id)
        {
            await _context.Permissions
                .Where(r => r.Id == id)
                .IgnoreQueryFilters()
                .ExecuteDeleteAsync();
            
            return NoContent();
        }



        [HttpPost("{id:int}/restore")]
        [Authorize(Policy = nameof(PermissionsNames.restore_permission))]
        public async Task<IActionResult> RestoreDeletedPermission(int id)
        {
            Permission? permission = await _context.Permissions
                .IgnoreQueryFilters()
                .FirstOrDefaultAsync(r => r.Id == id);

            if (permission == null)
            {
                return BadRequest();
            }
            permission.Deleted_By = null;
            permission.Deleted_At = null;

            await _context.SaveChangesAsync();

            return Ok();
        }



        [HttpGet("{id:int}/story")]
        [Authorize(Policy = nameof(PermissionsNames.get_story_permission))]
        public async Task<IActionResult> GetPermissionChangesStory(int id)
        {
            var permissionStory = await _context.ChangeLogs
                .Where(c => c.EntityName == nameof(Permission) && c.EntityId == id)
            .ToListAsync();


            List<ChangeLogsDTO> changesLogsDTO = [];
            foreach (var changeLog in permissionStory)
            {
                Permission? oldPermission = JsonSerializer.Deserialize<Permission>(changeLog.OldValue);
                Permission? newPermission = JsonSerializer.Deserialize<Permission>(changeLog.NewValue);

                PropertyInfo[] properties = typeof(Permission).GetProperties();

                StringBuilder oldValuesStringBuilder = new();
                StringBuilder newValuesStringBuilder = new();
                foreach (PropertyInfo property in properties)
                {
                    if (!property.PropertyType.IsGenericType)
                    {
                        string propertyName = property.Name;
                        object? oldPropertyValue = property.GetValue(oldPermission);
                        object? newPropertyValue = property.GetValue(newPermission);

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
                    EntityName = nameof(Permission),
                    NewValue = newValuesStringBuilder.ToString(),
                    OldValue = oldValuesStringBuilder.ToString(),
                });
            }



            return Ok(changesLogsDTO);
        }
    }
}













//List<ChangeLogsDTO> changesLogsDTO = permissionStory
//    .Select(p => new ChangeLogsDTO
//    {
//        EntityName = p.EntityName,
//        NewValue = p.NewValue,
//        OldValue = p.OldValue,
//        Id = p.Id,
//        EntityId = id
//    }).ToList();