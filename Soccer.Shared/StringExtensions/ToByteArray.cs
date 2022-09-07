namespace Soccer.Shared.StringExtensions
{
    public static class ByteArray
    {
        public static byte[] ToByteArray(this string base64String)
        {
            return Convert.FromBase64String(base64String);
        }
        
    }
}