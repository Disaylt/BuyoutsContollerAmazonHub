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
    class MongoPlannnigDB
    {
        private readonly IMongoCollection<BsonDocument> _mongoCollection;
        public MongoPlannnigDB(MongoConnecter mongoConnecter)
        {
            _mongoCollection = mongoConnecter.GetCollection(MongoStaticData.BusinessHubDatabase, MongoStaticData.CollectionPlanning);
        }

        public List<OrderData> GetPlannnigOrders(DateTime filterDate)
        {
            List<OrderData> planningOrders = new List<OrderData>();
            BsonDocument filter = new BsonDocument("Date", filterDate.Date.AddHours(3));
            List<BsonDocument> documents = _mongoCollection.Find(filter).ToList();
            foreach(BsonDocument document in documents)
            {
                OrderData order = new OrderData();
                order.IsDelte = document["IsDeleted"].AsBoolean;
                order.Amount = 1;
                order.KeyWord = document["Keyword"].AsString;
                order.Manager = document["Manager"].AsString;
                order.Session = document["Session"].AsString;
                order.SKU = document["ASIN"].AsString;
                order.Status = document["Status"].AsString;
                order.OrderId = document["_id"].ToString();
                try
                {
                    order.Descriprion = document["Description"].AsString;
                }
                catch(KeyNotFoundException)
                {
                    order.Descriprion = string.Empty;
                }
                planningOrders.Add(order);
            }
            return planningOrders;
        }

        public void UpdateTaskStatus(string id, bool status)
        {
            BsonDocument filter = new BsonDocument("_id", ObjectId.Parse(id));
            _mongoCollection.UpdateOne(filter, new BsonDocument("$set", new BsonDocument("IsDeleted", status)));
        }

        public void UpdateDescription(string id, string description)
        {
            BsonDocument filter = new BsonDocument("_id", ObjectId.Parse(id));
            _mongoCollection.UpdateOne(filter, new BsonDocument("$set", new BsonDocument("Description", description)));
        }

        public void DeletedDocumentFromDB(string orderId)
        {
            BsonDocument filter = new BsonDocument("_id", ObjectId.Parse(orderId));
            _mongoCollection.DeleteOne(filter);
        }
    }
}
