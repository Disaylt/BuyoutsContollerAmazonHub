using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using BuyoutsContollerAmazonHub.Documents;

namespace BuyoutsContollerAmazonHub.Orders_V2
{
    class MongoOrders
    {
        private readonly IMongoCollection<BsonDocument> _mongoCollection;
        public MongoOrders(MongoConnecter mongoConnecter)
        {
            _mongoCollection = mongoConnecter.GetCollection(MongoStaticData.BusinessHubDatabase, MongoStaticData.CollectonOrders);
        }
        public List<OrderData> GetOrders(Dictionary<string, DateTime> dateFilter)
        {
            BsonDocument filter = GetDateFilter(dateFilter);
            List<OrderData> orders = _mongoCollection.Find(filter)
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

        private BsonDocument GetDateFilter(Dictionary<string, DateTime> dateFilter)
        {
            BsonDocument filter = new BsonDocument();
            if (dateFilter.Count > 0)
            {
                BsonDocument dates = new BsonDocument();
                foreach (string key in dateFilter.Keys)
                {
                    switch (key)
                    {
                        case "from":
                            dates.Add("$gte", dateFilter[key].Date.AddHours(3));
                            break;
                        case "to":
                            dates.Add("$lte", dateFilter[key].Date.AddHours(3));
                            break;
                    }
                }
                filter.Add("OrderDate", dates);
            }
            return filter;
        }
    }
}
