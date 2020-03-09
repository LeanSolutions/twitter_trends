using System;
namespace twitter_trends 
{
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

        public Trends(string place, string latestTrends)
        {
            this.Place = place;
            this.Latest = latestTrends;
        }
    }
}