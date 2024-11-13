using BackEndLabs.Data;
using BackEndLabs.Extensions;
using BackEndLabs.JWT;
using BackEndLabs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;

namespace BackEndLabs.Background
{
    public class BackgroundTask(IServiceProvider serviceProvider, IOptions<JobConfiguration> jobOptions) : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider = serviceProvider;
        private readonly JobConfiguration _jobOptions = jobOptions.Value;

        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            int counter = _jobOptions.RepeatCount;
            var hourInterval = _jobOptions.HourInterval;
            var dateTimeIntervalToSearch = DateTime.UtcNow.AddHours(-hourInterval);


            while (counter > 0)
            {
                using var scope = _serviceProvider.CreateScope();
                var _context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                var methods = _context.LogsRequests
                    .Where(l => l.Created_at >= dateTimeIntervalToSearch)
                    .OrderBy(l => l.Created_at)
                    .GroupBy(r => r.ActionName)
                    .Select(g => new AnonymousMethodInfo
                    {
                        Name = g.Key,
                        Count = g.Count(),
                        LastAccess = g.Max(m => m.Created_at)
                    })
                    .ToList();


                var entities = _context.ChangeLogs
                    .Where(c => c.Created_At >= dateTimeIntervalToSearch)
                    .GroupBy(r => new { r.EntityName, r.EntityId, r.Created_At })
                    .Select(g => new AnonymousEntitiesInfo
                    {
                        EntityId = g.Key.EntityId,
                        EntityName = g.Key.EntityName,
                        LastAccess = g.Max(m => m.Created_At),
                        Count = g.Count()
                    })
                    .ToList();


                var userPermissions = _context.Users
                    .AsNoTracking()
                    .Include(u => u.Roles)
                        .ThenInclude(r => r.Permissions)
                    .Select(ur => new
                    {
                        userId = ur.Id,
                        ur.UserName,
                        permissions = ur.Roles.SelectMany(r => r.Permissions.Select(p => p.Name).ToList()).ToHashSet(),
                    })
                    .ToList();


                var userAuthorizations = _context.Tokens
                    .IgnoreQueryFilters()
                    .GroupBy(t => t.UserId)
                    .Select(a => new
                    {
                        UserId = a.Key,
                        Count = a.Count()
                    })
                    .ToList();

                var userRequests = _context.LogsRequests
                    .GroupBy(t => t.UserId)
                    .Select(r => new
                    {
                        UserId = r.Key,
                        Count = r.Count()
                    })
                    .ToList();


                var userInfo = userPermissions.Join(userAuthorizations,
                    p => p.userId, a => a.UserId, (perms, auth) => new { perms, auth})
                    .Join(userRequests, p => p.perms.userId, r => r.UserId, (permsAndAuth, reqs) => new { permsAndAuth, reqs })
                    .Select(n => new AnonymousUserInfo
                    {
                        UserId = n.reqs.UserId,
                        Permissions = n.permsAndAuth.perms.permissions,
                        AuthCount = n.permsAndAuth.auth.Count,
                        RequestCount = n.reqs.Count
                    })
                    .ToList();

                Models.File.GetBackgroundReport(methods, entities, userInfo);
                counter--;
                await Task.Delay(_jobOptions.RepeatTimeOut * 60 * 1000, stoppingToken);
            }
        }
    }
}
