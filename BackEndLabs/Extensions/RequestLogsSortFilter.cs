using BackEndLabs.Models;

namespace BackEndLabs.Extensions
{
    public class RequestLogsSortFilter
    {
        public int? UserId { get; set; }
        public int? StatusCode { get; set; }
        public string? IpAddress { get; set; }
        public string? UserAgent { get; set; }
        public string? ControllerName { get; set; }
        public List<Sort?> Orders { get; set; } = [];

    }

    public class Sort
    {
        public string OrderBy { get; set; } = "asc";
        public string? Key { get; set; } 
    }
}
