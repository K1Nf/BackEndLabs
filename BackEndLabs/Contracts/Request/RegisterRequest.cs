using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BackEndLabs.Contracts.Request
{
    public class RegisterRequest
    {
        //[Required]
        //[MinLength(7)]
        public string UserName { get; set; } = string.Empty;

        //[Required]
        //[MinLength(7)]
        public string Email { get; set; } = string.Empty;

        //[Required]
        //[MinLength(8)]
        //[PasswordPropertyText]
        public string Password { get; set; } = string.Empty;

        //[Required]
        //[MinLength(8)]
        //[PasswordPropertyText]
        public string C_Password { get; set; } = string.Empty;

        //[Required]
        //[MinLength(8)]
        //[PasswordPropertyText]
        public string Birthday { get; set; } = string.Empty;
    }
}
