using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using BuyoutsContollerAmazonHub.Documents;

namespace BuyoutsContollerAmazonHub.PlannningDB
{
    public class MongoQiwiAccounts
    {
        private readonly IMongoCollection<BsonDocument> _mongoCollection;
        public MongoQiwiAccounts(MongoConnecter mongoConnecter)
        {
            _mongoCollection = mongoConnecter.GetCollection(MongoStaticData.BusinessHubDatabase, MongoStaticData.CollectionQiwiAccounts);
        }

        public Dictionary<string, double> GetAccountsWithBalance()
        {
            BsonDocument filter = new BsonDocument("IsActive", true);
            List<BsonDocument> documents = _mongoCollection.Find(filter)
                .ToList();
            Dictionary<string, double> accountsWithBalance = new Dictionary<string, double>();
            foreach (BsonDocument document in documents)
            {
                try
                {
                    accountsWithBalance.Add(document["Login"].AsString, document["Balance"].ToDouble());
                }
                catch
                {
                    continue;
                }
            }
            return accountsWithBalance;
        }

        public Dictionary<string, int> GetAccountsWithSimSlot()
        {
            BsonDocument filter = new BsonDocument("IsActive", true);
            List<BsonDocument> documents = _mongoCollection.Find(filter)
                .ToList();
            Dictionary<string, int> accountsWithSimSlot = new Dictionary<string, int>();
            foreach (BsonDocument document in documents)
            {
                try
                {
                    accountsWithSimSlot.Add(document["Login"].AsString, document["SimcardSlot"].AsInt32);
                }
                catch
                {
                    continue;
                }
            }
            return accountsWithSimSlot;
        }
    }
}
