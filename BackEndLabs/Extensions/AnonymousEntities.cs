namespace BackEndLabs.Extensions
{
    public class AnonymousUserInfo
    {
        public int UserId { get; set; }
        public HashSet<string> Permissions { get; set; } = [];
        public int RequestCount { get; set; }
        public int AuthCount { get; set; }
    }


    public class AnonymousMethodInfo
    {
        public string? Name { get; set; }
        public int Count { get; set; }
        public DateTime LastAccess { get; set; }
    }


    public class AnonymousEntitiesInfo
    {
        public int EntityId { get; set; }
        public string? EntityName { get; set; }
        public int Count { get; set; }
        public DateTime LastAccess { get; set; }
    }
}
