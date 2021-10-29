using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuyoutsContollerAmazonHub.Documents;

namespace BuyoutsContollerAmazonHub.Orders_V2
{
    public static class DataGridViewOrders
    {
        private static DataGridView _dataGridViewOrdersDB;
        private static MongoConnecter _mongoConnecter;

        public static void SetDataGrid(DataGridView dataGridView, MongoConnecter mongoConnecter)
        {
            _dataGridViewOrdersDB = dataGridView;
            _mongoConnecter = mongoConnecter;
        }

        public static void UpdateDataGrid(Dictionary<string, DateTime> dateFilter)
        {
           
            _dataGridViewOrdersDB.Rows.Clear();
            List<string[]> orders = GetDataOrders(dateFilter);
            foreach (string[] order in orders)
            {
                _dataGridViewOrdersDB.Rows.Add(order);
            }
        }

        public static List<string[]> GetDataOrders(Dictionary<string, DateTime> dateFilter)
        {
            List<string[]> dataOrders = new List<string[]>();
            if (_mongoConnecter != null)
            {
                MongoItems mongoItems = new MongoItems(_mongoConnecter);
                MongoOrders mongoOrders = new MongoOrders(_mongoConnecter);
                MongoReviews mongoReviews = new MongoReviews(_mongoConnecter);
                var itemsDB = mongoItems.GetItems();
                var ordersDB = mongoOrders.GetOrders(dateFilter);
                var reviewsDB = mongoReviews.GetReviews();
                foreach (OrderData order in ordersDB)
                {
                    string itemName = itemsDB.Where(x => x[0] == order.SKU).FirstOrDefault()?[1] ?? "Неизвестно";
                    DataReviews dataReview = reviewsDB.Where(x => x.OrderId == order.OrderId).FirstOrDefault();
                    var (textReview, statusReview, dateReview) = GetReview(dataReview);
                    string[] dataRow = { order.SKU, itemName, order.OrderId, order.Session, order.Status, order.Total.ToString(), order.OrderDate.ToShortDateString(), textReview, statusReview, dateReview };
                    dataOrders.Add(dataRow);
                }
            }
            return dataOrders;
        }

        public static void UpdateCell(int idColumn, string orderId, string value)
        {
            MongoReviews mongoReviews = new MongoReviews(_mongoConnecter);
            string columnName;
            switch (idColumn)
            {
                case 7:
                    columnName = "Text";
                    mongoReviews.UpdateValue(orderId, columnName, value);
                    break;
                case 8:
                    columnName = "Status";
                    mongoReviews.UpdateValue(orderId, columnName, value);
                    break;
                case 9:
                    columnName = "DateReviews";
                    mongoReviews.UpdateValue(orderId, columnName, value);
                    break;
            }
        }

        private static (string textReview, string statusReview, string dateReview) GetReview(DataReviews dataReview)
        {
            string textReview;
            string dateReview;
            string statusReview;
            if (dataReview != null)
            {
                textReview = dataReview.Text ?? string.Empty;
                dateReview = dataReview.DateReviews ?? string.Empty;
                statusReview = dataReview.Status ?? "Без отзыва";
            }
            else
            {
                textReview = string.Empty;
                dateReview = string.Empty;
                statusReview = "Без отзыва";
            }
            return (textReview, statusReview, dateReview);
        }

    }
}
