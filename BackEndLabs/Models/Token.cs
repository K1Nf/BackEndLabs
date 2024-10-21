using System.ComponentModel.DataAnnotations;

namespace BackEndLabs.Models
{
    public class Token
    {
        [Key]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int UserId { get; set; }

        [Required]
        public DateTime ExpiresAt { get; set; }
    }
}