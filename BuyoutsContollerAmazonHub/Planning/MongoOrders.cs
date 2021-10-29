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
    public class MongoOrders
    {
        private readonly IMongoCollection<BsonDocument> _mongoCollection;
        public MongoOrders(MongoConnecter mongoConnecter)
        {
            _mongoCollection = mongoConnecter.GetCollection(MongoStaticData.BusinessHubDatabase, MongoStaticData.CollectonOrders);
        }

        public List<string> GetLastAccountsWithBuyouts(int days)
        {
            DateTime startFilterDate = DateTime.Now.AddDays(days * -1).AddHours(3);
            var filter = new BsonDocument("OrderDate", new BsonDocument("$gte", startFilterDate));
            List<string> sessions = _mongoCollection.Find(filter)
                .ToList()
                .Select(x => x["Session"].AsString)
                .Distinct()
                .ToList();
            return sessions;
        }

        public List<BuyoutData> GetBuyoutsData()
        {
            List<BuyoutData> buyoutsData = _mongoCollection.Find(new BsonDocument())
                .ToList()
                .Select(x => new BuyoutData
                {
                    OrderDate = x["OrderDate"].ToUniversalTime(),
                    ProductId = x["ASIN"].ToString(),
                    Session = x["Session"].AsString
                })
                .ToList();
            return buyoutsData;
        }
    }
}
