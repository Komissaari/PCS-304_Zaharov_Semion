using System.Text.Json;

namespace Serialization
{
    static class MySerialization
    {
        public static string Ext<T>(this T _string)
        {
            return JsonSerializer.Serialize<T>(_string);
        }
    }
}