using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyoutsContollerAmazonHub
{
    public static class MongoStaticData
    {
        public static string BusinessHubDatabase => "amazon_business_hub";
        public static string CollectionAccounts => "accounts";
        public static string CollectonOrders => "orders";
        public static string CollectionPlanning => "planning";
        public static string CollectionBankCards => "bank_cards";
        public static string CollectionItems => "items";
        public static string CollectionReviews => "rewievs";
        public static string CollectionQiwiAccounts => "qiwi_accounts";
    }
}
