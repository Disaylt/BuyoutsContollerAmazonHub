using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using BuyoutsContollerAmazonHub.Documents;

namespace BuyoutsContollerAmazonHub.Orders
{
    class MongoOrders
    {
        private readonly IMongoCollection<BsonDocument> _mongoCollection;
        public MongoOrders(MongoConnecter mongoConnecter)
        {
            _mongoCollection = mongoConnecter.GetCollection(MongoStaticData.BusinessHubDatabase, MongoStaticData.CollectonOrders);
        }
        public List<OrderData> GetOrders()
        {
            List<OrderData> orders = _mongoCollection.Find(new BsonDocument())
                .ToList()
                .Select(x => new OrderData
                {
                    OrderDate = x["OrderDate"].ToUniversalTime(),
                    SKU = x["ASIN"].ToString(),
                    Session = x["Session"].AsString,
                    Total = x["Total"].AsDouble,
                    Status = x["Status"].AsString,
                    OrderId = x["OrderId"].AsString
                })
                .ToList();
            return orders;
        }
    }
}
