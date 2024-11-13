namespace BackEndLabs.JWT
{
    public interface IJwtProvider
    {
        public string? CreateNewToken(int userId);
    }
}
