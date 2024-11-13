using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text.Json.Serialization;
using BackEndLabs.Models;

namespace BackEndLabs.Contracts.Response
{
    public class UserDTO
    {
        public string UserName { get; set; } = string.Empty;

        public string? Email { get; set; }

        public DateOnly? BirthDate { get; set; }
        public Models.File File { get; set; }
        public int FileId { get; set; }
        public List<Role> Roles { get; set; } = [];
    }
}
