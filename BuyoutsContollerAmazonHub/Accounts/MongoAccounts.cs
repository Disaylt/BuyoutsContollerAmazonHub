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
    public class MongoAccounts
    {
        private readonly IMongoCollection<BsonDocument> _mongoCollection;
        public MongoAccounts(MongoConnecter mongoConnecter)
        {
            _mongoCollection = mongoConnecter.GetCollection(MongoStaticData.BusinessHubDatabase, MongoStaticData.CollectionAccounts);
        }

        public List<DataAccount> GetDataAccounts(Dictionary<string, DateTime> dateFilter)
        {
            BsonDocument filter = GetDateFilter(dateFilter);
            List<BsonDocument> accounts = _mongoCollection.Find(filter).ToList();
            List<DataAccount> dataAcounts = new List<DataAccount>();
            foreach(BsonDocument doc in accounts)
            {
                DataAccount dataAccount = new DataAccount
                {
                    DateCreated = doc["CreatedAt"].ToUniversalTime(),
                    Email = doc["Email"].AsString,
                    IsActive = doc["IsActive"].AsBoolean,
                    Name = doc["Session"].AsString,
                    Password = doc["Password"].AsString,
                    Description = GetDescription(doc)
                };
                dataAcounts.Add(dataAccount);
            }
            return dataAcounts;
        }

        public void UpdateComment(string newComment, string account)
        {
            BsonDocument filter = new BsonDocument("Session", account);
            BsonDocument newValue = new BsonDocument("$set", new BsonDocument("Comment", newComment));
            _mongoCollection.UpdateOne(filter, newValue);
        }

        private string GetDescription(BsonDocument document)
        {
            if (document.TryGetValue("Comment", out BsonValue description) && description != BsonNull.Value)
            {
                return description.AsString;
            }
            else
            {
                return string.Empty;
            }
        }
        private BsonDocument GetDateFilter(Dictionary<string, DateTime> dateFilter)
        {
            BsonDocument filter = new BsonDocument();
            if(dateFilter.Count > 0)
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
                            dates.Add("$lte", dateFilter[key].Date.AddDays(1).AddHours(2).AddMinutes(59));
                            break;
                    }
                }
                filter.Add("CreatedAt", dates);
            }
            return filter;
        }
    }
}
