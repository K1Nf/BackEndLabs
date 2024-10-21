using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEndLabs.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        [PasswordPropertyText]
        public string Password { get; set; } = string.Empty;


        public DateOnly BirthDay { get; set; }


        //[NotMapped]
        //public int? RoleId { get; set; }
        public List<Role> Roles {  get; private set; } = [];


        //public List<Role> GetRoles() => Roles;


        public static User CreateUser(string userName, string email, DateOnly birthDay, string password)
        {
            return new User { UserName = userName, Email = email, Password = password, BirthDay = birthDay };
        }
    }
}
