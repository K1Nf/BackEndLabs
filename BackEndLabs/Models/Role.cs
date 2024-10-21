using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BackEndLabs.Models
{
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Code { get; set; } = string.Empty;
        public DateTime Created_At { get; set; }
        public int Created_By { get; set; }
        public DateTime? Deleted_At { get; set; }
        public int? Deleted_By { get; set; }


        //[NotMapped]
        //[JsonIgnore]
        //public int? UserId { get; set; }

        [JsonIgnore]
        public List<User> Users { get; set; } = [];

        //[NotMapped]
        //[JsonIgnore]
        //public int? PermissionId { get; set; }
        //[JsonIgnore]
        public List<Permission> Permissions {  get; private set; } = [];

        //public List<Permission> GetPermissions() => Permissions;
    }
}
