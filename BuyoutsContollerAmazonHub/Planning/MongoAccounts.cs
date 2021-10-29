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
    public class MongoAccounts
    {
        private readonly IMongoCollection<BsonDocument> _mongoCollection;
        private readonly MongoConnecter _mongoConnecter;
        public MongoAccounts(MongoConnecter mongoConnecter)
        {
            _mongoConnecter = mongoConnecter;
            _mongoCollection = mongoConnecter.GetCollection(MongoStaticData.BusinessHubDatabase, MongoStaticData.CollectionAccounts);
        }

        public List<string> GetAccounts()
        {
            MongoCards mongoCards = new MongoCards(_mongoConnecter);
            List<string> accountsWithCard = mongoCards.GetAccounts();

            BsonDocument filter = new BsonDocument("IsActive", true);
            List<string> accounts = _mongoCollection.Find(filter)
                .ToList()
                .Select(x => x["Session"].AsString)
                .Where(x=> accountsWithCard.Contains(x))
                .ToList();
            return accounts;
        }
    }
}
