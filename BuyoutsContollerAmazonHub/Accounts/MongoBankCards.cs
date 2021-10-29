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
    public class MongoBankCards
    {
        private readonly IMongoCollection<BsonDocument> _mongoCollection;
        public MongoBankCards(MongoConnecter mongoConnecter)
        {
            _mongoCollection = mongoConnecter.GetCollection(MongoStaticData.BusinessHubDatabase, MongoStaticData.CollectionBankCards);
        }

        public void UpdateAcountsBankData(List<DataAccount> dataAccounts)
        {
            BsonDocument filter = new BsonDocument
            {
                { "IsActive", true},
                {"Session", new BsonDocument("$ne", BsonNull.Value) }
            };
            List<BsonDocument> documentsBankCard = _mongoCollection.Find(filter).ToList();
            foreach(DataAccount dataAcount in dataAccounts)
            {

                BsonDocument document = documentsBankCard.Where(x => x["Session"].AsString == dataAcount.Name).FirstOrDefault();
                if(document != null)
                {
                    dataAcount.PhoneNumberQiwi = document.GetValue("QiwiAccount").AsString;
                    dataAcount.IsActiveCard = true;
                }
                else
                {
                    dataAcount.PhoneNumberQiwi = string.Empty;
                    dataAcount.IsActiveCard = false;
                }
            }
        }
    }
}
