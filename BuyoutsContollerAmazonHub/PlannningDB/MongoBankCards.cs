using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using BuyoutsContollerAmazonHub.Documents;
using System.Windows.Forms;

namespace BuyoutsContollerAmazonHub.PlannningDB
{
    public class MongoBankCards
    {
        private readonly IMongoCollection<BsonDocument> _mongoCollection;
        public MongoBankCards(MongoConnecter mongoConnecter)
        {
            _mongoCollection = mongoConnecter.GetCollection(MongoStaticData.BusinessHubDatabase, MongoStaticData.CollectionBankCards);
        }

        public Dictionary<string, string> GetAccountsWithQiwi()
        {
            BsonDocument filter = new BsonDocument("IsActive", true);
            List<BsonDocument> documents = _mongoCollection.Find(filter)
                .ToList();
            Dictionary<string, string> accountsWithQiwi = new Dictionary<string, string>();
            foreach (BsonDocument document in documents)
            {
                try
                {
                    accountsWithQiwi.Add(document["Session"].AsString, document["QiwiAccount"].AsString);
                }
                catch
                {
                    continue;
                }
            }
            return accountsWithQiwi;
        }
    }
}
