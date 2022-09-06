using System.Web;
using AuthenticationServices.Models;
using EmailSender;

namespace AuthenticationServices.Authentication;
public partial class Authentication
{
    public async Task<AuthenticationResults> ForgotPasswordAsync(string username, string newPassword)
    {
        var results = new AuthenticationResults();
        var user = await _userManager.FindByNameAsync(username);
        if (user == null)
        {
            results.Message = "User does not exist";
            return results;
        }
        var token = await _userManager.GeneratePasswordResetTokenAsync(user);
        //it has to be url encoded so that it can be sent in the url
        token = HttpUtility.UrlEncode(token);
        newPassword = HttpUtility.UrlEncode(newPassword);
        try
        {
            await Smtp.SendEmailAsync(user.Email, "Reset Password", $"Please reset your password by visiting this link: {"\n"} https://localhost:5001/Auth/ResetPassword?username={username}&token={token}&newPassword={newPassword}");
            results.Message = "Email sent successfully";
            results.IsSuccess = true;
            results.Username = username;
            results.Roles = await _userManager.GetRolesAsync(user) as List<string>;
            return results;
        }
        catch
        {
            results.Message = "Failed to send email";
            return results;
        }
    }
    public async Task<AuthenticationResults> ResetPasswordAsync(string username, string token, string password)
    {
        var results = new AuthenticationResults();
        var user = await _userManager.FindByNameAsync(username);
        if (user == null)
        {
            results.Message = "User does not exist";
            return results;
        }
        var result = await _userManager.ResetPasswordAsync(user, token, password);
        if (!result.Succeeded)
        {
            results.Message = "Failed to reset password";
            return results;
        }
        results.IsSuccess = true;
        results.Message = "Password reset successfully";
        return results;
    }
}