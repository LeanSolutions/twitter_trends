using System;
using System.IO;

namespace twitter_trends {
    public class Constants
    {
        public static readonly string ENVIRONMENT_VARIABLE_NAME_FOR_API_KEY= "Consumer_API_Key";
        public static readonly string ENVIRONMENT_VARIABLE_NAME_FOR_API_SECRET_KEY= "Consumer_API_Secret_Key";
        public static readonly string ENVIRONMENT_VARIABLE_NAME_FOR_ACCESS_TOKEN= "Access_Token";
        public static readonly string ENVIRONMENT_VARIABLE_NAME_FOR_ACCESS_TOKEN_SECRET= "Access_Token_Secret";
        public static readonly string API_BASE_URL = "https://api.twitter.com/1.1";
        public static readonly string TRENDS_PATH = "/trends/place.json";
        public static readonly string PATH_TO_WOEID_CSV = Directory.GetCurrentDirectory()+ "/data/woeids.csv";
    }
}