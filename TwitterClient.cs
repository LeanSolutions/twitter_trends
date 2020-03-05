using System;
using RestSharp;
using RestSharp.Authenticators;

namespace twitter_trends 
{
    public class TwitterClient 
    {
        private string _consumerApiKey;
        private string _consumerApiSecretKey;
        private string _accessToken;
        private string _accessTokenSecret;

        public TwitterClient() 
        {
            _consumerApiKey = Environment.GetEnvironmentVariable(Constants.ENVIRONMENT_VARIABLE_NAME_FOR_API_KEY);
            _consumerApiSecretKey = Environment.GetEnvironmentVariable(Constants.ENVIRONMENT_VARIABLE_NAME_FOR_API_SECRET_KEY);
            _accessToken = Environment.GetEnvironmentVariable(Constants.ENVIRONMENT_VARIABLE_NAME_FOR_ACCESS_TOKEN);
            _accessTokenSecret = Environment.GetEnvironmentVariable(Constants.ENVIRONMENT_VARIABLE_NAME_FOR_ACCESS_TOKEN_SECRET);
        }

        public void GetTrendsNear(string location) 
        {
            var client = new RestClient(Constants.API_BASE_URL);
            client.Authenticator = OAuth1Authenticator.ForProtectedResource(_consumerApiKey, _consumerApiSecretKey, _accessToken, _accessTokenSecret);
            var request = new RestRequest(Constants.TRENDS_PATH,Method.GET,DataFormat.Json).AddQueryParameter("id", "2450022");
            var response = client.Get(request);
            Console.WriteLine(response.Content);
        }
    }
}