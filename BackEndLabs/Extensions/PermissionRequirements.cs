using BackEndLabs.Models;
using Microsoft.AspNetCore.Authorization;

namespace BackEndLabs.Extensions
{
    public class PermissionRequirements() : IAuthorizationRequirement
    {
        //public Permission[] Permissions => permissions;
    }
}
