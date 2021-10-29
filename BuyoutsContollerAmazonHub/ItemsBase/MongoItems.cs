using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace BuyoutsContollerAmazonHub.ItemsBase
{
    public class MongoItems
    {
        private readonly IMongoCollection<BsonDocument> _mongoCollection;
        public MongoItems(MongoConnecter mongoConnecter)
        {
            _mongoCollection = mongoConnecter.GetCollection(MongoStaticData.BusinessHubDatabase, MongoStaticData.CollectionItems);
        }

        public void DeleteAsin(string asin)
        {
            BsonDocument filter = new BsonDocument("ASIN", asin);
            _mongoCollection.DeleteOne(filter);
        }

        public List<string[]> GetItems()
        {
            BsonDocument filter = new BsonDocument();
            List<string[]> items;
            try
            {
                items = _mongoCollection.Find(filter)
                .ToList()
                .Select(x => new string[] { x["ASIN"].AsString, x["Title"].AsString })
                .ToList();
            }
            catch
            {
                items = new List<string[]>();
            }
            return items;
        }

        public void UpdateTitle(string asin, string title)
        {
            asin = asin.Trim();
            BsonDocument filter = new BsonDocument("ASIN", asin);
            long numberOfDocument = _mongoCollection.Find(filter).CountDocuments();
            if(numberOfDocument == 0)
            {
                BsonDocument document = new BsonDocument
                {
                    {"ASIN", asin },
                    {"Title", title }
                };
                _mongoCollection.InsertOne(document);
            }
            else
            {
                _mongoCollection.UpdateOne(filter, new BsonDocument("$set", new BsonDocument("Title", title)));
            }
        }
    }
}
