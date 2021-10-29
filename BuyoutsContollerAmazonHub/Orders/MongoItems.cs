using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace BuyoutsContollerAmazonHub.Orders
{
    public class MongoItems
    {
        private readonly IMongoCollection<BsonDocument> _mongoCollection;
        public MongoItems(MongoConnecter mongoConnecter)
        {
            _mongoCollection = mongoConnecter.GetCollection(MongoStaticData.BusinessHubDatabase, MongoStaticData.CollectionItems);
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
    }
}
