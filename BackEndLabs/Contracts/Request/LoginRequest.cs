using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BackEndLabs.Contracts.Request
{
    public record LoginRequest(string UserName, string Password);
}
