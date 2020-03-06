using System;

namespace twitter_trends
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get Twittter Trends near you!");

            //ToDo: Places should be singleton
            var allSupportedPlaces = new Places();
            
            if(args.Length==0) 
            {
                Console.WriteLine("Please enter at least one location.");
            }
            foreach(var location in args) 
            {
                Console.WriteLine("Location Entered: {0}", location);
                Twitter client = new Twitter();
                client.GetTrendsNear(location);
            }
            Console.ReadLine();
        }
    }
}

