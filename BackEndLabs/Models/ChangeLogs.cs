using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace BackEndLabs.Models
{
    public class ChangeLogs
    {
        public ChangeLogs()
        {
            
        }
        public static ChangeLogs CreateChangeLogs(string entityName, int entityId, string oldValue, string newValue, int userId)
        {
            return new ChangeLogs 
            { 
                EntityName = entityName,
                EntityId = entityId,
                OldValue = oldValue,
                NewValue = newValue,
                Created_By = userId
            };
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int EntityId { get; set; }
        [Required]
        public string EntityName { get; set; } = string.Empty;

        [Required]
        public string OldValue { get; set; } = string.Empty;
        
        [Required] 
        public string NewValue { get; set; } = string.Empty;

        [Required]
        public DateTime Created_At { get; set; } = DateTime.UtcNow;

        [Required]
        public int Created_By { get; set; }
    }
}
