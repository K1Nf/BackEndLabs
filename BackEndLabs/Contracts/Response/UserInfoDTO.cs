namespace BackEndLabs.Contracts.Response
{
    public class UserInfoDTO
    {
        public string Ip { get; set; } = string.Empty;
        public string UserAgent { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
    }
}