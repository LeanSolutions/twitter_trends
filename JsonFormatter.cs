
using Newtonsoft.Json.Linq;
namespace twitter_trends
{
    public class JsonFormatter
    {
        public static string Format(string inputJson)
        {
            return JValue.Parse(inputJson).ToString();
        }
    }
}