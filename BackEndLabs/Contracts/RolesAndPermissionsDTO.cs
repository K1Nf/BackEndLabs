using BackEndLabs.Models;

namespace BackEndLabs.Contracts
{
    public class RolesAndPermissionsDTO
    {
        public int RoleId { get; set; }
        public int PermissionId { get; set; }

        public Role Role { get; set; }
        public Permission Permission { get; set; }
    }
}
