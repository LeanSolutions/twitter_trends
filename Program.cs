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
                client.GetTrendsNear(allSupportedPlaces.FindWoeId(location));
            }
            Console.ReadLine();
        }
    }
}

