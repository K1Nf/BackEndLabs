namespace BackEndLabs.Models
{
    public class UsersAndRoles
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public DateTime Created_At { get; set; } = DateTime.UtcNow;
        public int Created_By { get; set; }
        public DateTime? Deleted_At { get; set; }
        public int? Deleted_By { get; set; }

        public User? User { get; set; }
        public Role? Role { get; set; }
    }
}
