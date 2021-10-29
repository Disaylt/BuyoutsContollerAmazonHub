using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BuyoutsContollerAmazonHub.Documents;

namespace BuyoutsContollerAmazonHub.Orders
{
    public static class DataGridViewOrders
    {
        private static readonly BindingSource _bindingSource = new BindingSource();
        public static DataGridView DataGridViewOrdersDB { get; set; }

        public static void UpdateDataGrid(List<OrderData> orders)
        {
            DataTable dataTable = CreateDataTable(orders);
            _bindingSource.DataSource = dataTable;
            DataGridViewOrdersDB.DataSource = _bindingSource;
        }

        public static void UpdateFilter(Dictionary<string, string> filters)
        {
            bool isFirstText = true;
            string filterRequst = string.Empty;
            foreach (string keyFilter in filters.Keys)
            {
                if (!string.IsNullOrEmpty(filters[keyFilter]))
                {
                    if (isFirstText)
                    {
                        filterRequst += $"{keyFilter} like '%{filters[keyFilter]}%'";
                        isFirstText = false;
                    }
                    else
                    {
                        filterRequst += $"and {keyFilter} like '%{filters[keyFilter]}%'";
                    }
                }
            }
            _bindingSource.Filter = filterRequst;
        }

        private static DataTable CreateDataTable(List<OrderData> orders)
        {
            DataTable dataTable = new DataTable();
            CreateTitleForDataTable(dataTable);
            foreach (OrderData order in orders)
            {
                object[] dataRow =
                {
                    order.SKU,
                    order.OrderId,
                    order.Session,
                    order.Status,
                    order.Total,
                    order.OrderDate.ToShortDateString()
                };
                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
        }
        private static void CreateTitleForDataTable(DataTable dataTable)
        {
            dataTable.Columns.Add(PlanningTableColumnsName.SKU, typeof(string));
            dataTable.Columns.Add(PlanningTableColumnsName.OrderId, typeof(string));
            dataTable.Columns.Add(PlanningTableColumnsName.Session, typeof(string));
            dataTable.Columns.Add(PlanningTableColumnsName.Status, typeof(string));
            dataTable.Columns.Add(PlanningTableColumnsName.Total, typeof(string));
            dataTable.Columns.Add(PlanningTableColumnsName.OrderDate, typeof(string));
        }
    }
}
