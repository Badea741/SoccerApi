using System.Text;
using Newtonsoft.Json;

namespace Soccer.Mq.Helpers;
public static class DeSerilizeExtension
{
    public static object DeSerialize(this string encoded, Type type)
    {
        if (encoded == null) return new { };
        object obj = JsonConvert.DeserializeObject(encoded, type)!;
        return obj;
    }
    public static object DeSerialize(this byte[] encoded, Type type)
    {
        if (encoded == null) return new { };
        var decoded = Encoding.UTF8.GetString(encoded);
        return JsonConvert.DeserializeObject(decoded, type)!;
    }
}