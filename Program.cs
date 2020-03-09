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
                //ToDo: Support places with blank spaces in the name
                Console.WriteLine("Please enter at least one location.");
                return;
            }
            foreach(var location in args) 
            {
                Console.WriteLine("Location Entered: {0}", location);
                if (allSupportedPlaces.FindWoeId(location)==null) 
                {
                    Console.WriteLine("This location is currently not supported.");
                    return;
                }
                Twitter client = new Twitter();
                var trends = client.GetTrendsNear(allSupportedPlaces.FindWoeId(location));
                Console.WriteLine(JsonFormatter.Format(trends));
            }
            Console.ReadLine();
        }
    }
}

