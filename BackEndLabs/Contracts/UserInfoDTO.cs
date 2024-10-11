namespace BackEndLabs.Contracts
{
    public class UserInfoDTO
    {
        public string Ip { get; set; } = string.Empty;
        public string UserAgent { get; set; } = string.Empty;
        public PathString Path { get; set; } = string.Empty;
    }
}