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

    public class MongoOrders
    {
        private readonly IMongoCollection<BsonDocument> _mongoCollection;
        public MongoOrders(MongoConnecter mongoConnecter)
        {
            _mongoCollection = mongoConnecter.GetCollection(MongoStaticData.BusinessHubDatabase, MongoStaticData.CollectonOrders);
        }

        public List<OrderData> GetOrders()
        {
            BsonDocument filter = new BsonDocument();
            List<OrderData> orders = _mongoCollection.Find(filter)
                .ToList()
                .Select(x => new OrderData
                {
                    Session = x["Session"].AsString,
                    OrderDate = x["OrderDate"].ToUniversalTime()
                })
                .ToList();
            return orders;
        }
    }
}
