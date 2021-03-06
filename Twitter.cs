using System;
using RestSharp;
using RestSharp.Authenticators;

namespace twitter_trends 
{
    public class Twitter 
    {
        private string _consumerApiKey;
        private string _consumerApiSecretKey;
        private string _accessToken;
        private string _accessTokenSecret;

        public Twitter() 
        {
            this._consumerApiKey = Environment.GetEnvironmentVariable(Constants.ENVIRONMENT_VARIABLE_NAME_FOR_API_KEY);
            this._consumerApiSecretKey = Environment.GetEnvironmentVariable(Constants.ENVIRONMENT_VARIABLE_NAME_FOR_API_SECRET_KEY);
            this._accessToken = Environment.GetEnvironmentVariable(Constants.ENVIRONMENT_VARIABLE_NAME_FOR_ACCESS_TOKEN);
            this._accessTokenSecret = Environment.GetEnvironmentVariable(Constants.ENVIRONMENT_VARIABLE_NAME_FOR_ACCESS_TOKEN_SECRET);
        }

        public String GetTrendsNear(string location) 
        {
            var client = new RestClient(Constants.API_BASE_URL);
            client.Authenticator = OAuth1Authenticator.ForProtectedResource(_consumerApiKey, _consumerApiSecretKey, _accessToken, _accessTokenSecret);
            var request = new RestRequest(Constants.TRENDS_PATH,Method.GET,DataFormat.Json).AddQueryParameter("id", location);
            var response = client.Get(request);
            return response.Content;
        }
    }
}