using System;
using MongoDB.Bson.Serialization.Attributes;
namespace twitter_trends 
{
    [BsonIgnoreExtraElements]
    public class Trends
    {
        public string Place
        {
            get;
            private set;
        }
        public string Latest
        {
            get;
            private set;
        }
        public string UpdateTime
        {
            get;
            private set;
        }

        public Trends(string place, string latestTrends)
        {
            this.Place = place;
            this.Latest = latestTrends;
            var current = DateTime.Now;
            UpdateTime = current.ToLongDateString() + " " + current.ToLongTimeString();
        }
    }
}