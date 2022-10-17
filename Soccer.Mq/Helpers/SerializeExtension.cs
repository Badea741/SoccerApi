using System.Text;
using Newtonsoft.Json;

namespace Soccer.Mq.Helpers;
public static class SerializeExtension
{
    public static byte[] Serialize(this object obj)
    {
        if (obj == null) return new byte[] { };

        string json = JsonConvert.SerializeObject(obj);
        return Encoding.UTF8.GetBytes(json);
    }
}