using System.Text.Json;

namespace ExtentionSerialization
{
    public static class MyExtentionSerialization
    {
        public static string ExtSer<T>(this T _string)
        {
            return JsonSerializer.Serialize<T>(_string);
        }
    }
}
