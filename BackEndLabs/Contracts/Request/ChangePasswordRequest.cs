namespace BackEndLabs.Contracts.Request
{
    public record ChangePasswordRequest(string oldPassword, string newPassword);
}
