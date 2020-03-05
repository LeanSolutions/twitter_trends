using System;

namespace twitter_trends
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get Twittter Trends near you!");
            if(args.Length==0) 
            {
                Console.WriteLine("Please enter at least one location.");
            }
            foreach(var location in args) 
            {
                Console.WriteLine("Location Entered: {0}", location);
                TwitterClient client = new TwitterClient();
                client.GetTrendsNear(location);
            }
            Console.ReadLine();
        }
    }
}

