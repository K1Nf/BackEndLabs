using BackEndLabs.Contracts.Response;
using BackEndLabs.Data;
using BackEndLabs.Extensions;
using BackEndLabs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Reflection;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BackEndLabs.Controllers
{
    [ApiController]
    [Route("api/ref/log/[controller]")]
    public class RequestController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;

        [HttpGet]
        public async Task<ActionResult> GetAllRequestLogs([FromQuery] int? page, [FromQuery] int? count,
            [FromQuery] RequestLogsSortFilter filter)
        {
            IQueryable<LogsRequests> logsQuery = _context.LogsRequests
                .AsQueryable();

            if(filter.StatusCode != null)
            {
                logsQuery = logsQuery.Where(x => x.StatusCode == filter.StatusCode);
            }
            if (filter.UserId != null)
            {
                logsQuery = logsQuery.Where(x => x.UserId == filter.UserId);
            }
            if (filter.UserAgent != null)
            {
                logsQuery = logsQuery.Where(x => x.UserAgent.ToLower().Contains(filter.UserAgent.ToLower()));
            }
            if (filter.IpAddress != null)
            {
                logsQuery = logsQuery.Where(x => x.IpAddress.ToLower() == filter.IpAddress.ToLower());
            }
            if (filter.ControllerName != null)
            {
                logsQuery = logsQuery.Where(x => x.ControllerName.ToLower() == filter.ControllerName.ToLower());
            }
            //IQueryable<LogsRequests> logsQuery2 = logsQuery;



            IOrderedQueryable<LogsRequests>? logsOrdered = logsQuery.OrderBy(x => x.UserId);
            bool isFirst = true;

            foreach (var order in filter.Orders)
            {
                if (isFirst)
                {
                    logsOrdered = null;
                }

                if (string.Equals(order!.Key, "ControllerName", StringComparison.CurrentCultureIgnoreCase))
                {
                    if (isFirst)
                    {
                        logsOrdered =
                            order.OrderBy.ToLower() == "asc".ToLower() ?

                            logsQuery
                                .OrderBy(l => l.ControllerName) :

                            logsQuery
                                .OrderByDescending(l => l.ControllerName);
                        isFirst = false;
                    }
                    else
                    {
                        logsOrdered =
                            order.OrderBy.ToLower() == "asc".ToLower() ?

                            logsOrdered!
                                .ThenBy(l => l.ControllerName) :

                            logsOrdered!
                                .ThenByDescending(l => l.ControllerName);
                    }
                }

                if (string.Equals(order.Key, "ActionName", StringComparison.CurrentCultureIgnoreCase))
                {
                    if (isFirst)
                    {
                        logsOrdered =
                            order.OrderBy.ToLower() == "asc".ToLower() ?

                            logsQuery
                                .OrderBy(l => l.ActionName) :

                            logsQuery
                                .OrderByDescending(l => l.ActionName); 
                        isFirst = false;
                    }
                    else
                    {
                        logsOrdered =
                            order.OrderBy.ToLower() == "asc".ToLower() ?

                            logsOrdered!
                                .ThenBy(l => l.ActionName) :

                            logsOrdered!
                                .ThenByDescending(l => l.ActionName);
                    }
                }

            }
            logsQuery = logsOrdered!.AsQueryable();


            int pageSize = count ?? 10;
            int pageNumber = page-1 ?? 0;
            List<LogsRequests> logsRequests = await logsQuery
                .Skip(pageNumber * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToListAsync();

            List<LogsRequestsDTO> logs = logsRequests
                .Select(l => 
                    new LogsRequestsDTO()
                    {
                        Id = l.Id,
                        ActionName = l.ActionName,
                        ControllerName = l.ControllerName,
                        Created_at = l.Created_at,
                        Path = l.Path,
                        StatusCode = l.StatusCode,
                    }).ToList();
            return Ok(logs);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<LogsRequests>> GetRequestLogById(int id)
        {
            LogsRequests? logRequests = await _context.LogsRequests.FindAsync(id);

            if (logRequests == null)
            {
                return BadRequest("Не найден такой лог запроса");
            }

            return Ok(logRequests);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult<LogsRequests>> DeleteRequestLogById(int id)
        {
            var log = await _context.LogsRequests.
                Where(r => r.Id == id)
                .ExecuteDeleteAsync();

            return NoContent();
        }
    }
}
