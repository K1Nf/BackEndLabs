using BackEndLabs.Data;
using BackEndLabs.Enum;
using BackEndLabs.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Transactions;

namespace BackEndLabs.Controllers
{
    [ApiController]
    [Route("/api/ref/changes/")]
    public class ChangeLogsController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;

        [HttpPost("roles/{changeId:int}")]
        [Authorize(policy: nameof(PermissionsNames.rollback_role))]
        public async Task<IActionResult> RollBackRoleChange(int changeId)
        {
            int userId = 1;

            var changeLogs = await _context.ChangeLogs
                .AsNoTracking()
                .FirstOrDefaultAsync(cl => cl.Id == changeId);

            if (changeLogs == null)
            {
                return BadRequest("Лог с таким id не найден!");
            }

            Role? returnedRole = JsonSerializer.Deserialize<Role>(changeLogs.OldValue);

            if (returnedRole == null)
            {
                return BadRequest("Не удалось получить старое значение роли");
            }

            _context.Roles.Update(returnedRole);
            await _context.SaveChangesAsync();

            return Ok();
        }



        [HttpPost("permissions/{changeId:int}")]
        [Authorize(policy: nameof(PermissionsNames.rollback_permission))]
        public async Task<ActionResult> RollBackPermissionChange(int changeId)
        {
            int userId = 1;

            var changeLogs = await _context.ChangeLogs
                .AsNoTracking()
                .FirstOrDefaultAsync(cl => cl.Id == changeId);

            if (changeLogs == null)
            {
                return BadRequest("Лог с таким id не найден!");
            }

            Permission? returnedPermission = JsonSerializer.Deserialize<Permission>(changeLogs.OldValue);

            if (returnedPermission == null)
            {
                return BadRequest("Не удалось получить старое разрешение");
            }

            _context.Permissions.Update(returnedPermission);
            await _context.SaveChangesAsync();


            return Ok();
        }



        [HttpPost("users/{changeId:int}")]
        public IActionResult RollBackUserChange(int changeId)
        {

            return Ok();
        }
    }
}










/*Role? replacedRole = JsonSerializer.Deserialize<Role>(changeLogs.NewValue);
var transaction = await _context.Database.BeginTransactionAsync();
try
{
    ChangeLogs newChangeLogs = new()
    {
        Created_By = userId,
        EntityId = replacedRole.Id,
        NewValue = returnedRole.Name,
        OldValue = replacedRole.Name
    };
    await _context.ChangeLogs.AddAsync(newChangeLogs);
    _context.Roles.Update(returnedRole);
    await _context.SaveChangesAsync();
    await transaction.CommitAsync();
}
catch(TransactionAbortedException ex)
{
    await transaction.RollbackAsync();
    Console.WriteLine(ex.Message);
    return BadRequest(ex.Message);
}*/