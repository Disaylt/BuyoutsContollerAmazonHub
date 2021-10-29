using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuyoutsContollerAmazonHub.Documents;

namespace BuyoutsContollerAmazonHub.Planning
{
    public class PlanningHandler
    {
        private readonly MongoAccounts _mongoAccounts;
        private readonly MongoOrders _mongoOrders;
        private readonly MongoPlannig _mongoPlannig;

        public PlanningHandler(MongoConnecter mongoConnecter)
        {
            _mongoAccounts = new MongoAccounts(mongoConnecter);
            _mongoOrders = new MongoOrders(mongoConnecter);
            _mongoPlannig = new MongoPlannig(mongoConnecter);
        }

        public List<OrderData> GetPlannnigOrders(List<OrderData> clientOrders)
        {
            List<OrderData> planningOrders = new List<OrderData>();
            clientOrders.Sort((amount0, amount1) => (amount1.Amount.CompareTo(amount0.Amount)));
            List<string> accountsWithBuyouts = GetAccountWithBuyouts(1);
            List<BuyoutData> buyoutOrders = _mongoOrders.GetBuyoutsData();
            List<string> accounts = _mongoAccounts.GetAccounts();

            foreach(OrderData orderData in clientOrders)
            {
                List<string> suitaleAccounts = GetSuitableAccounts(planningOrders, orderData, buyoutOrders);
                int numberOfSuitableAccounts = suitaleAccounts.Count;
                int numProducts = orderData.Amount;
                for(int i = 0; i < numProducts; i++)
                {
                    if(numberOfSuitableAccounts > i)
                    {
                        planningOrders.Add(orderData);
                    }
                    else
                    {
                        InsertNewAccount(planningOrders, accounts, accountsWithBuyouts, orderData, buyoutOrders);
                    }
                }
            }
            return planningOrders;
        }

        private List<string> GetAccountWithBuyouts(int days)
        {
            List<string> planningAccounts = _mongoPlannig.GetLastPlanningAccounts(days);
            List<string> orderAccounts = _mongoOrders.GetLastAccountsWithBuyouts(days);
            List<string> accountsWithBuyouts = planningAccounts.Concat(orderAccounts)
                .Distinct()
                .ToList();
            return accountsWithBuyouts;
        }

        private List<string> GetSuitableAccounts(List<OrderData> planningOrders, OrderData orderData, List<BuyoutData> buyoutOrders)
        {
            List<string> suitableAccounts = new List<string>();
            string[] accountsWithProduct = GetAccountsWithProduct(buyoutOrders, orderData);
            foreach(OrderData acccount in planningOrders)
            {
                if(!accountsWithProduct.Contains(acccount.Session)
                    && planningOrders.Where(x=> x.SKU == orderData.SKU).Count() == 0
                    && planningOrders.Where(x=> x.Session == orderData.Session).Count() < 1
                    && orderData.Session != null)
                {
                    suitableAccounts.Add(acccount.Session);
                }
            }
            return suitableAccounts;
        }

        private string[] GetAccountsWithProduct(List<BuyoutData> buyoutOrders, OrderData orderData)
        {
            string[] accountsWithProduct = buyoutOrders.Where(x => x.ProductId == orderData.SKU)
                    .Select(x => x.Session)
                    .ToArray();
            return accountsWithProduct;
        }

        private void InsertNewAccount(List<OrderData> planningOrders, List<string> accounts, List<string> accountsWithBuyouts, OrderData orderData, List<BuyoutData> buyoutsOrders)
        {
            Random random = new Random();
            string[] accountsWithOrders = buyoutsOrders.Select(x => x.Session)
                .Distinct()
                .ToArray();
            string[] accountsWithProduct = GetAccountsWithProduct(buyoutsOrders, orderData);
            string[] suitableAccounts = accounts.Where(x =>
            !accountsWithBuyouts.Contains(x)
            && !accountsWithProduct.Contains(x))
            .ToArray();
            string[] newSuitableAccounts = suitableAccounts.Where(x =>
            !accountsWithOrders.Contains(x))
                .ToArray();

            string sessionName;
            if(newSuitableAccounts.Count() > 0)
            {
                int randomNum = random.Next(0, newSuitableAccounts.Count());
                sessionName = newSuitableAccounts[randomNum];
            }
            else
            {
                if (suitableAccounts.Count() == 0)
                {
                    throw new Exception();
                }
                int randomNum = random.Next(0, suitableAccounts.Count());
                sessionName = suitableAccounts[randomNum];
            }

            OrderData planningOrder = new OrderData
            {
                Session = sessionName,
                SKU = orderData.SKU,
                Manager = orderData.Manager,
                KeyWord = orderData.KeyWord
            };
            planningOrders.Add(planningOrder);
            accountsWithBuyouts.Add(sessionName);
        }
    }
}
