using BackEndLabs.Enum;
using BackEndLabs.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BackEndLabs.Controllers
{
    public class PagesController : ControllerBase
    {

        [HttpGet("/users/{id:int}")]
        [Authorize(Policy = nameof(PermissionsNames.read_user))]
        public async Task GetUserPage()
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/userPage.html");
        }

        [HttpGet]
        [Route("/users")]
        [Route("/")]
        [Authorize(Policy = nameof(PermissionsNames.get_list_user))]
        public async Task GetUsersPage()
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/users.html");
        }

        [HttpGet("/roles/{id:int}")]
        [Authorize(Policy = nameof(PermissionsNames.read_role))]
        public async Task GetRolePage()
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/rolePage.html");
        }



        [HttpGet("/roles")]
        [Authorize(Policy = nameof(PermissionsNames.get_list_role))]
        public async Task GetRolesPage()
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/roles.html");
        }



        [HttpGet("/permissions/{id:int}")]
        [Authorize(Policy = nameof(PermissionsNames.read_permission))]
        public async Task GetPermissionPage()
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/permissionPage.html");
        }



        [HttpGet("/permissions")]
        [Authorize(Policy = nameof(PermissionsNames.get_list_permission))]
        public async Task GetPermissionsPage()
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/permissions.html");
        }



        [HttpGet("/requestslogs")]
        //[Authorize]
        public async Task GetRequestsLogsPage()
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/requestslogs.html");
        }



        [HttpGet("/requestlog/{id:int}")]
        //[Authorize]
        public async Task GetRequestLogPage()
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/requestlog.html");
        }



        [HttpGet("/authorize/register")]
        public async Task GetRegisterPage()
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/RegPage.html");
        }



        [HttpGet("/roles/create")]
        [Authorize(Policy = nameof(PermissionsNames.create_role))]
        public async Task GetRoleCreatePage()
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/createrole.html");
        }



        [HttpGet("/permissions/create")]
        [Authorize(Policy = nameof(PermissionsNames.create_permission))]
        public async Task GetPermissionCreatePage()
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/createpermission.html");
        }



        [HttpGet("/roles/update/{id:int}")]
        [Authorize(Policy = nameof(PermissionsNames.update_role))]
        public async Task GetRoleUpdatePage()
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/updateRole.html");
        }



        [HttpGet("/permissions/update/{id:int}")]
        [Authorize(Policy = nameof(PermissionsNames.update_permission))]
        public async Task GetPermissionUpdatePage()
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/updatePermission.html");
        }


        [HttpGet("/info")]
        public async Task GetInfoPage()
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/info.html");
        }


        [HttpGet("/usersLogs")]
        [Authorize(Policy = nameof(PermissionsNames.get_story_user))]
        public async Task GetUsersLogsPage()
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/userChangesLogs.html");
        }


        [HttpGet("/permissionsLogs")]
        [Authorize(Policy = nameof(PermissionsNames.get_story_permission))]
        public async Task GetPermissionsLogsPage()
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/permissionChangesLogs.html");
        }


        [HttpGet("/rolesLogs")]
        [Authorize(Policy = nameof(PermissionsNames.get_story_role))]
        public async Task GetRolesLogsPage()
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/roleChangesLogs.html");
        }


        [HttpGet("/me")]
        [Authorize(Policy = nameof(PermissionsNames.read_user))]
        public async Task GetMePage()
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/me.html");
        }



        [HttpGet("/admin")]
        //[Authorize(Policy = nameof(PermissionsNames.get_files))]
        public async Task GetAdminPage()
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/admin.html");
        }
    }
}
