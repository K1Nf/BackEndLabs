namespace BackEndLabs.Contracts.Request
{
    public class PermissionCreateRequest
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Code { get; set; } = string.Empty;
    }
}
