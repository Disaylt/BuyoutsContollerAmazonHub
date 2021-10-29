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
    class MongoReviews
    {
        private readonly IMongoCollection<BsonDocument> _mongoCollection;
        public MongoReviews(MongoConnecter mongoConnecter)
        {
            _mongoCollection = mongoConnecter.GetCollection(MongoStaticData.BusinessHubDatabase, MongoStaticData.CollectionReviews);
        }

        public List<DataReviews> GetReviews()
        {
            List<BsonDocument> documents = _mongoCollection.Find(new BsonDocument()).ToList();
            List<DataReviews> orders = new List<DataReviews>();
            foreach(BsonDocument doc in documents)
            {
                DataReviews dataReviews = new DataReviews();
                try
                {
                    dataReviews.DateReviews = doc["DateReviews"].AsString;
                }
                catch(KeyNotFoundException)
                {
                    dataReviews.DateReviews = string.Empty;
                }
                try
                {
                    dataReviews.Text = doc["Text"].AsString;
                }
                catch (KeyNotFoundException)
                {
                    dataReviews.Text = string.Empty;
                }
                try
                {
                    dataReviews.Status = doc["Status"].AsString;
                }
                catch (KeyNotFoundException)
                {
                    dataReviews.Status = "Без отзыва";
                }
                try
                {
                    dataReviews.OrderId = doc["OrderId"].AsString;
                }
                catch (KeyNotFoundException)
                {
                    dataReviews.OrderId = string.Empty;
                }
                orders.Add(dataReviews);
            }
            return orders;
        }

        public void UpdateValue(string orederId, string key, string value)
        {
            BsonDocument filter = new BsonDocument("OrderId", orederId);
            long numberOfDocument = _mongoCollection.Find(filter).CountDocuments();

            if(string.IsNullOrEmpty(value))
            {
                value = string.Empty;
            }

            if (numberOfDocument == 0)
            {
                BsonDocument document = new BsonDocument
                {
                    {"OrderId", orederId },
                    {key, value }
                };
                _mongoCollection.InsertOne(document);
            }
            else
            {
                _mongoCollection.UpdateOne(filter, new BsonDocument("$set", new BsonDocument(key, value)));
            }
        }
    }
}
