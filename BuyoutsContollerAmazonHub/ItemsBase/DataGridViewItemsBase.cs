using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BuyoutsContollerAmazonHub.Documents;

namespace BuyoutsContollerAmazonHub.ItemsBase
{
    public static class DataGridViewItemsBase
    {
        private static readonly BindingSource _bindingSource = new BindingSource();
        public static DataGridView DataGridViewPlannigDB { get; set; }

        public static void UpdateDataGrid(List<string[]> items)
        {
            if(items.Count != 0 )
            {
                DataTable dataTable = CreateDataTable(items);
                _bindingSource.DataSource = dataTable;
                DataGridViewPlannigDB.DataSource = _bindingSource;
                SetWidthDataGrid();
            }
        }
        public static void UpdateFilter(string asin)
        {
            string filterRequst = $"ASIN like '%{asin}%'";
            _bindingSource.Filter = filterRequst;
        }
        private static DataTable CreateDataTable(List<string[]> items)
        {
            DataTable dataTable = new DataTable();
            CreateTitleForDataTable(dataTable);
            foreach (string[] item in items)
            {
                dataTable.Rows.Add(item);
            }
            return dataTable;
        }

        private static void CreateTitleForDataTable(DataTable dataTable)
        {
            dataTable.Columns.Add(PlanningTableColumnsName.SKU, typeof(string));
            dataTable.Columns.Add(PlanningTableColumnsName.Key, typeof(string));
        }

        private static void SetWidthDataGrid()
        {
            DataGridViewPlannigDB.Columns[0].Width = 130;
            DataGridViewPlannigDB.Columns[1].Width = 350;
        }
    }
}
