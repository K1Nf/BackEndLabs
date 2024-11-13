namespace BackEndLabs.Contracts.Request
{
    public class RoleCreateRequest
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Code { get; set; } = string.Empty;
    }

    //public class UsersAndRolesCreateRequest
    //{
    //}

    //public class UsersAndRolesUpdateRequest
    //{
    //}


    //public class RolesAndPermissionsCreateRequest
    //{
    //}

    //public class RolesAndPermissionsUpdateRequest
    //{
    //}


    //public class UsersCreateRequest
    //{

    //}
    //public class UsersUpdateRequest
    //{
    //}
}
