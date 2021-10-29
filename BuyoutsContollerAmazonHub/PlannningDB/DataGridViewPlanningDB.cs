using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BuyoutsContollerAmazonHub.Documents;

namespace BuyoutsContollerAmazonHub.PlannningDB
{
    public static class DataGridViewPlanningDB
    {
        private static BindingSource _bindingSource = new BindingSource();
        public static DataGridView DataGridViewPlannigDB { get; set; }

        public static void UpdateDataGridViewPlanningDB(List<OrderData> orders)
        {
            DataTable dataTable = CreateDataTable(orders);
            _bindingSource.DataSource = dataTable;
            DataGridViewPlannigDB.DataSource = _bindingSource;
            UpdatePropertiesTable();
        }

        public static void UpdateFilter(Dictionary<string, string> filters)
        {
            bool isFirstText = true;
            string filterRequst = string.Empty;
            foreach (string keyFilter in filters.Keys)
            {
                string defoultValue = GetDefoultValue(keyFilter);

                if (filters[keyFilter] != defoultValue && filters[keyFilter] != null && filters[keyFilter] != string.Empty)
                {
                    string valueFilter = UpdateValueFilter(filters[keyFilter].Trim());
                    string operatorAndValueRequest = GetOperatorRequest(keyFilter, valueFilter);
                    if (isFirstText)
                    {

                        filterRequst = $"{keyFilter} {operatorAndValueRequest}";
                        isFirstText = false;
                    }
                    else
                    {
                        filterRequst += $" and {keyFilter} {operatorAndValueRequest}";
                    }
                }
            }
            _bindingSource.Filter = filterRequst;
        }

        private static void UpdatePropertiesTable()
        {
            if(DataGridViewPlannigDB != null)
            {
                DataGridViewPlannigDB.Columns[7].Visible = false;
                for(int i = 0; i<5; i++)
                {
                    DataGridViewPlannigDB.Columns[i].ReadOnly = true;
                }
            }
        }

        private static DataTable CreateDataTable(List<OrderData> orders)
        {
            DataTable dataTable = new DataTable();
            CreateTitleForDataTable(dataTable);
            foreach(OrderData order in orders)
            {
                object[] dataRow =
                {
                    order.SKU,
                    order.Session,
                    order.KeyWord,
                    order.Manager,
                    order.Status,
                    order.IsDelte,
                    order.Descriprion,
                    order.OrderId,
                    order.PhoneNumberQiwi,
                    order.Total,
                    order.SlotSimCard,
                    order.Amount
                };
                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
        }

        private static string GetOperatorRequest(string filterType, string valueFilter)
        {
            if (filterType == PlanningTableColumnsName.IsComelete)
            {
                return $"= '{valueFilter}'";
            }
            else
            {
                return $"like '%{valueFilter}%'";
            }
        }
        private static string UpdateValueFilter(string value)
        {
            switch (value)
            {
                case "Да":
                    return "true";
                case "Нет":
                    return "false";
                default:
                    return value;
            }
        }
        private static string GetDefoultValue(string keyFilter)
        {
            string typeFilter = GetTypeFilter(keyFilter);
            string defoultValue;
            switch (typeFilter)
            {
                case "comboBox":
                    defoultValue = "Все";
                    break;
                default:
                    defoultValue = string.Empty;
                    break;
            }
            return defoultValue;

        }
        private static string GetTypeFilter(string keyFilter)
        {
            string[] typesComboBox = { PlanningTableColumnsName.IsComelete };
            string typeFilter;
            if (typesComboBox.Contains(keyFilter))
            {
                typeFilter = "comboBox";
            }
            else
            {
                typeFilter = string.Empty;
            }
            return typeFilter;
        }
        private static void CreateTitleForDataTable(DataTable dataTable)
        {
            dataTable.Columns.Add(PlanningTableColumnsName.SKU, typeof(string));
            dataTable.Columns.Add(PlanningTableColumnsName.Session, typeof(string));
            dataTable.Columns.Add(PlanningTableColumnsName.Key, typeof(string));
            dataTable.Columns.Add(PlanningTableColumnsName.Manager, typeof(string));
            dataTable.Columns.Add(PlanningTableColumnsName.Status, typeof(string));
            dataTable.Columns.Add(PlanningTableColumnsName.IsComelete, typeof(bool));
            dataTable.Columns.Add(PlanningTableColumnsName.Description, typeof(string));
            dataTable.Columns.Add("id", typeof(string));
            dataTable.Columns.Add(PlanningTableColumnsName.QiwiPhoneNumber, typeof(string));
            dataTable.Columns.Add(PlanningTableColumnsName.Balance, typeof(double));
            dataTable.Columns.Add(PlanningTableColumnsName.SimcardSlot, typeof(string));
            dataTable.Columns.Add(PlanningTableColumnsName.AmountOrders, typeof(int));
        }
    }
}
