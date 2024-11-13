using System.ComponentModel.DataAnnotations;

namespace BackEndLabs.Contracts.Response
{
    public class LogsRequestsDTO
    {
        public int Id { get; set; }
        public string Path { get; set; } = string.Empty;
        public string? ControllerName { get; set; } = string.Empty;
        public string? ActionName { get; set; } = string.Empty;
        public int StatusCode { get; set; }
        public DateTime Created_at { get; set; } = DateTime.UtcNow;
    }

}
