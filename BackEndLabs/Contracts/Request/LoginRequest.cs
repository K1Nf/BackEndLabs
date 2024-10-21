using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BackEndLabs.Contracts.Request
{
    public class LoginRequest
    {
        [Required]
        //[MinLength(7)]
        public string UserName { get; set; }

        [Required]
        //[MinLength(8)]
        [PasswordPropertyText]
        public string Password { get; set; }
    }
}
