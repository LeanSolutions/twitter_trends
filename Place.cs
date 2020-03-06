
using System;
namespace twitter_trends 
{
    class Place
    {
        public string Name
        { get; private set; }
 
        //Unqiue ID for each place on earth
        public string Woeid
        { get; private set; }

        public Place(string name) 
        {
            this.Name = name;

            
        }

    }
}