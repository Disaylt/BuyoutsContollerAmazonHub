using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace BuyoutsContollerAmazonHub
{
    public class MongoConnecter
    {
        public IMongoClient MongoClient { get; set; }
        public MongoConnecter()
        {
            string connectString = "mongodb://10.100.1.250:27017";
            MongoClient = new MongoClient(connectString);
        }

        public IMongoCollection<BsonDocument> GetCollection(string database, string collection)
        {
            IMongoDatabase mongoDatabase = MongoClient.GetDatabase(database);
            IMongoCollection<BsonDocument> mongoCollection = mongoDatabase.GetCollection<BsonDocument>(collection);
            return mongoCollection;
        }
    }
}