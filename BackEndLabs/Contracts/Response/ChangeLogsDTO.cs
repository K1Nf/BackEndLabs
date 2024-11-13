using System.ComponentModel.DataAnnotations;

namespace BackEndLabs.Contracts.Response
{
    public class ChangeLogsDTO
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public string EntityName { get; set; } = string.Empty;
        public string OldValue { get; set; } = string.Empty;
        public string NewValue { get; set; } = string.Empty;
    }
}
