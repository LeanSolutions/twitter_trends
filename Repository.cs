using MongoDB.Driver;
using System.Linq;
namespace twitter_trends
{
    public class Repository
    {
        public void insertTrends(Trends trends)
        {
            var mongo = new MongoClient();
            var db = mongo.GetDatabase(Constants.DB_NAME);
            var trends_collection = db.GetCollection<Trends>("trends");
            var filter = Builders<Trends>.Filter.Eq("Place", trends.Place);
            var existingTrends = trends_collection.Find(filter).FirstOrDefault();
            if(existingTrends==null)
            {
                trends_collection.InsertOne(trends);
                return;
            }
            var update = Builders<Trends>.Update.Set("Latest", trends.Latest).Set("UpdateTime", trends.UpdateTime);
            trends_collection.UpdateOne(filter,update);
        }
    }
}