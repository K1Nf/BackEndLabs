using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEndLabs.Models
{
    public class LogsRequests
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Path { get; set; } = string.Empty;

        [Required]
        public string Method { get; set; } = string.Empty;

        //[Required]
        public string? ControllerName { get; set; } = string.Empty;

        //[Required]
        public string? ActionName { get; set; } = string.Empty;

        //[Required]
        public string? RequestBody { get; set; } = string.Empty;

        [Required]
        public string RequestHeaders { get; set; } = string.Empty;

        [Required]
        public int UserId { get; set; }

        [Required]
        public string IpAddress { get; set; } = string.Empty;

        [Required]
        public string UserAgent { get; set; } = string.Empty;

        [Required]
        public int StatusCode { get; set; } 

        //[Required]
        public string? ResponseBody { get; set; } = string.Empty;

        [Required]
        public string ResponseHeaders { get; set; } = string.Empty;

        [Required]
        public DateTime Created_at { get; set; } = DateTime.UtcNow;
    }

}
