namespace Soccer.Shared.StringExtensions
{
    public static class Base64
    {
        public static string ToBase64(this byte[] byteArray)
        {
            return Convert.ToBase64String(byteArray);
        }
    }
}