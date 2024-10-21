namespace BackEndLabs.JWT
{
    public class JWTConfiguration
    {
        public string Issuer { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;
        public int ExpiresMinutes { get; set; } = 2;
        public string SecretKey { get; set; } = string.Empty;
        public string UserIdentity { get; set; } = string.Empty;


        public const int MAXIMUM_VALID_TOKENS = 2;
    }
}