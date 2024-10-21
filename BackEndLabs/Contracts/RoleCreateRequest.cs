namespace BackEndLabs.Contracts
{
    public class RoleCreateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }

    public class RoleUpdateRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Code { get; set; }
    }

    public class PermissionCreateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }

    public class PermissionUpdateRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Code { get; set; }
    }

    public class UsersAndRolesCreateRequest
    {
    }

    public class UsersAndRolesUpdateRequest
    {
    }


    public class RolesAndPermissionsCreateRequest
    {
    }

    public class RolesAndPermissionsUpdateRequest
    {
    }


    public class UsersCreateRequest
    {

    }
    public class UsersUpdateRequest
    {
    }
}
