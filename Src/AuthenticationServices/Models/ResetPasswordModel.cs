namespace AuthenticationServices.Models
{
    public class ResetPasswordModel
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
    }
}