using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using BuyoutsContollerAmazonHub.Documents;

namespace BuyoutsContollerAmazonHub.Accounts
{
    public class MongoQiwiAccount
    {
        private readonly IMongoCollection<BsonDocument> _mongoCollection;
        public MongoQiwiAccount(MongoConnecter mongoConnecter)
        {
            _mongoCollection = mongoConnecter.GetCollection(MongoStaticData.BusinessHubDatabase, MongoStaticData.CollectionQiwiAccounts);
        }

        public void UpdateAcountsQiwiData(List<DataAccount> dataAccounts)
        {
            BsonDocument filter = new BsonDocument();
            List<BsonDocument> documents = _mongoCollection.Find(filter).ToList();
            foreach(DataAccount dataAccount in dataAccounts)
            {
                BsonDocument document = documents.Where(x => x.GetValue("Login") == dataAccount.PhoneNumberQiwi).FirstOrDefault();
                if(document != null)
                {
                    double balance = document.GetValue("Balance").AsDouble;
                    dataAccount.Balance = Math.Round(balance, 2).ToString();
                    dataAccount.SimcardSlot = document.GetValue("SimcardSlot").AsInt32;
                }
                else
                {
                    dataAccount.Balance = "0";
                    dataAccount.SimcardSlot = 0;
                }
            }
        }
    }
}
