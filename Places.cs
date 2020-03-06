using System;
using System.Collections.Generic;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Linq;

namespace twitter_trends
{
    public class Places
    {
        public Dictionary<String, String> List
        {
            get;
            private set;
        }

        public Places() 
        {
            List = new Dictionary<string, string>();
            using (var reader = new StreamReader(Constants.PATH_TO_WOEID_CSV))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var woeid = csv.GetField("WoeId").Trim();
                    var name = csv.GetField("Name").Trim();
                
                    List.Add(woeid, name);
                }
            }
        }

        public String FindWoeId(String name)
        {
            return List.FirstOrDefault(p => p.Value == name).Key;
        }
    }
}