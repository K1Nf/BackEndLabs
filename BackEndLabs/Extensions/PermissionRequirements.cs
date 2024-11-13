using BackEndLabs.Models;
using Microsoft.AspNetCore.Authorization;

namespace BackEndLabs.Extensions
{
    public class PermissionRequirements(Permission permission) : IAuthorizationRequirement
    {
        public Permission Permission => permission;
    }
}
