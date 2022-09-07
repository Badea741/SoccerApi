using System.Security.Cryptography;
using System.Text;

namespace Soccer.Shared.StringExtensions;

public static partial class Sha256
{
    public static string ToSha256(this string input)
    {
        using (var sha256 = SHA256.Create())
        {
            var bytes = Encoding.UTF8.GetBytes(input);
            var hash = sha256.ComputeHash(bytes);
            StringBuilder sb = new();
            foreach (byte b in hash)
            {
                sb.Append(b.ToString("X2"));
            }
            return sb.ToString();
        }
    }
}