using Newtonsoft.Json;

namespace HelloTelegramBot.Utils
{
    public static class JsonUtil
    {
        public static string ToJson<T>(this T any, bool indented = false, bool includeNull = false)
        {
            return JsonConvert.SerializeObject(any, new JsonSerializerSettings()
            {
                Formatting = indented ? Formatting.Indented : Formatting.None,
                NullValueHandling = includeNull ? NullValueHandling.Include : NullValueHandling.Ignore
            });
        }
    }
}
