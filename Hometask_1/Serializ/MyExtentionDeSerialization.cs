using System.Text.Json;

namespace ExtentionDeSerialization
{
    public static class MyExtentionDeSerialization
    {
        public static T ExtDeSer<T>(this string json)
        {

            return JsonSerializer.Deserialize<T>(json);
        }
    }
}