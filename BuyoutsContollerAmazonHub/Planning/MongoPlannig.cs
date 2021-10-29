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
    public class MongoPlannig 
    {
        private readonly IMongoCollection<BsonDocument> _mongoCollection;
        public MongoPlannig(MongoConnecter mongoConnecter)
        {
            _mongoCollection = mongoConnecter.GetCollection(MongoStaticData.BusinessHubDatabase, MongoStaticData.CollectionPlanning);
        }

        public List<string> GetLastPlanningAccounts(int days)
        {
            DateTime startFilterDate = DateTime.Now.AddDays(days * -1).AddHours(3);
            var filter = new BsonDocument("Date", new BsonDocument("$gte", startFilterDate));
            List<string> sessions = _mongoCollection.Find(filter)
                .ToList()
                .Select(x => x["Session"].AsString)
                .Distinct()
                .ToList();
            return sessions;
        }

        public void InsertNewPlanningOrders(List<OrderData> planningOrders, DateTime dateTime)
        {
            foreach(OrderData order in planningOrders)
            {
                BsonDocument planningOrder = new BsonDocument
                {
                    {"ASIN", order.SKU },
                    {"Date", dateTime.Date.AddHours(3) },
                    {"Amount", BsonInt32.Create(1) },
                    {"Keyword", order.KeyWord },
                    {"Manager", order.Manager },
                    {"Status", "new" },
                    {"Session", order.Session },
                    {"IsDeleted", false },
                    {"AttemptsAddToBasket", 0 }
                };
                _mongoCollection.InsertOne(planningOrder);
            }
        }
    }
}
