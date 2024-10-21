using BackEndLabs.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEndLabs.Contracts
{
    public class RoleDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public List<Permission> Permissions { get; set; } = [];
    }
}
