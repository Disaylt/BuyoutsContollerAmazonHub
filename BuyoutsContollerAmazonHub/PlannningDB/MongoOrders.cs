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
    class MongoOrders
    {
        private readonly IMongoCollection<BsonDocument> _mongoCollection;
        public MongoOrders(MongoConnecter mongoConnecter)
        {
            _mongoCollection = mongoConnecter.GetCollection(MongoStaticData.BusinessHubDatabase, MongoStaticData.CollectonOrders);
        }

        public void UpdateCountOrders(List<OrderData> orders)
        {
            BsonDocument filter = new BsonDocument();
            List<OrderData> buyoutsOrders = _mongoCollection.Find(filter)
                .ToList()
                .Select(x => new OrderData
                {
                    Session = x["Session"].AsString,
                    OrderDate = x["OrderDate"].ToUniversalTime()
                })
                .ToList();
            foreach(OrderData orderData in orders)
            {
                int amount = buyoutsOrders.Where(x => x.Session == orderData.Session).Count();
                orderData.Amount = amount;
            }
        }
    }
}
