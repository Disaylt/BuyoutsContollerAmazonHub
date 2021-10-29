using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using BuyoutsContollerAmazonHub.Documents;

namespace BuyoutsContollerAmazonHub.Planning
{
    public class MongoCards
    {
        private readonly IMongoCollection<BsonDocument> _mongoCollection;
        public MongoCards(MongoConnecter mongoConnecter)
        {
            _mongoCollection = mongoConnecter.GetCollection(MongoStaticData.BusinessHubDatabase, MongoStaticData.CollectionBankCards);
        }

        public List<string> GetAccounts()
        {
            var filter = new BsonDocument("Session", new BsonDocument{
                {"$exists", true},
                {"$ne", BsonNull.Value}
            });
            List<string> sessions = _mongoCollection.Find(filter).ToList()
                .Select(x => x["Session"].AsString)
                .ToList();
            return sessions;
        }
    }
}
