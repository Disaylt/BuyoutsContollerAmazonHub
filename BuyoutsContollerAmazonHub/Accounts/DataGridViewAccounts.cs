using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BuyoutsContollerAmazonHub.Documents;

namespace BuyoutsContollerAmazonHub.Accounts
{
    public static class DataGridViewAccounts
    {
        private static List<OrderData> _orders;
        private static List<DataAccount> _accounts;
        private static readonly BindingSource _bindingSource = new BindingSource();
        public static DataGridView DataGridViewPlannigDB { get; set; }

        public static void UpdateDataGrid(List<DataAccount> accounts, List<OrderData> orders)
        {
            _orders = orders;
            _accounts = accounts;
            DataTable dataTable = CreateDataTable();
            _bindingSource.DataSource = dataTable;
            DataGridViewPlannigDB.DataSource = _bindingSource;
            SetWidthDataGrid();
            SetReadOnlyeColumn();
            _orders = null;
        }

        public static void UpdateFilter(string filter)
        {
            _bindingSource.Filter = filter;
        }

        public static Dictionary<string, int> GetStatistic()
        {
            Dictionary<string, int> statistic = new Dictionary<string, int>();
            statistic.Add("Аккаунтов зарегано:", _accounts.Count);
            statistic.Add("Неактивных аккаунтов:", _accounts.Where(x=> x.IsActive == false).Count());
            statistic.Add("Аккаунты с картой", _accounts.Where(x=> x.IsActiveCard == true).Count());
            return statistic;
        }

        private static DataTable CreateDataTable()
        {
            DataTable dataTable = new DataTable();
            CreateTitleForDataTable(dataTable);
            foreach (DataAccount account in _accounts)
            {
                int amountOrders = CountOrders(account.Name);
                string dateOfLastOrder = GetDateOfLastOrder(account.Name);
                object[] dataRow =
                {
                    account.Name,
                    account.Email,
                    account.Password,
                    account.DateCreated.ToShortDateString(),
                    account.IsActive,
                    account.IsActiveCard,
                    amountOrders,
                    dateOfLastOrder,
                    account.PhoneNumberQiwi,
                    account.SimcardSlot,
                    account.Balance,
                    account.Description
                };
                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
        }

        private static int CountOrders(string session)
        {
            int amountOrders = _orders
                .Where(x => x.Session == session)
                .Count();
            return amountOrders;
        }

        private static string GetDateOfLastOrder(string session)
        {
            string lastDate = _orders
                .Where(x => x.Session == session)
                ?.OrderByDescending(x=> x.OrderDate)
                ?.FirstOrDefault()?.OrderDate.ToShortDateString() ?? string.Empty;
            return lastDate;
        }

        private static void CreateTitleForDataTable(DataTable dataTable)
        {
            dataTable.Columns.Add(PlanningTableColumnsName.Session, typeof(string));
            dataTable.Columns.Add(PlanningTableColumnsName.Email, typeof(string));
            dataTable.Columns.Add(PlanningTableColumnsName.Password, typeof(string));
            dataTable.Columns.Add(PlanningTableColumnsName.DateCreated, typeof(string));
            dataTable.Columns.Add(PlanningTableColumnsName.IsActive, typeof(bool));
            dataTable.Columns.Add(PlanningTableColumnsName.IsQIWIActive, typeof(bool));
            dataTable.Columns.Add(PlanningTableColumnsName.AmountOrders, typeof(int));
            dataTable.Columns.Add(PlanningTableColumnsName.LastOrderDate, typeof(string));
            dataTable.Columns.Add(PlanningTableColumnsName.QiwiPhoneNumber, typeof(string));
            dataTable.Columns.Add(PlanningTableColumnsName.SimcardSlot, typeof(string));
            dataTable.Columns.Add(PlanningTableColumnsName.Balance, typeof(string));
            dataTable.Columns.Add(PlanningTableColumnsName.Description, typeof(string));
        }

        private static void SetWidthDataGrid()
        {
            DataGridViewPlannigDB.Columns[0].Width = 130;
            DataGridViewPlannigDB.Columns[1].Width = 180;
            DataGridViewPlannigDB.Columns[2].Width = 150;
            DataGridViewPlannigDB.Columns[4].Width = 60;
            DataGridViewPlannigDB.Columns[5].Width = 60;
            DataGridViewPlannigDB.Columns[6].Width = 75;
            DataGridViewPlannigDB.Columns[7].Width = 80;
            DataGridViewPlannigDB.Columns[9].Width = 50;
            DataGridViewPlannigDB.Columns[10].Width = 60;
            DataGridViewPlannigDB.Columns[11].Width = 150;
        }

        private static void SetReadOnlyeColumn()
        {
            for(int i = 0; i< 11; i++)
            {
                DataGridViewPlannigDB.Columns[i].ReadOnly = true;
            }
            DataGridViewPlannigDB.Columns[11].ReadOnly = false;
        }
    }
}
