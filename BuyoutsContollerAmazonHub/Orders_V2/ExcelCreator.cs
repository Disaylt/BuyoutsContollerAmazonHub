using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using System.Windows.Forms;

namespace BuyoutsContollerAmazonHub.Orders_V2
{
    public static class ExcelCreator
    {
        public static void CreateNewExcelFile(string pathFile, Dictionary<string, DateTime> dateFilters)
        {
            XLWorkbook workbook = new XLWorkbook();
            DataTable dataTable = CreateDataTable(dateFilters);
            var worksheet = workbook.Worksheets.Add(dataTable, "Orders");
            SetWidthColumns(worksheet);
            try
            {
                workbook.SaveAs(pathFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void SetWidthColumns(IXLWorksheet worksheet)
        {
            worksheet.Column(1).Width = 15f;
            worksheet.Column(2).Width = 25f;
            worksheet.Column(3).Width = 25f;
            worksheet.Column(4).Width = 20f;
            worksheet.Column(5).Width = 25f;
            worksheet.Column(6).Width = 10f;
            worksheet.Column(7).Width = 13f;
            worksheet.Column(8).Width = 40f;
            worksheet.Column(9).Width = 15f;
            worksheet.Column(10).Width = 13f;
        }
        private static DataTable CreateDataTable(Dictionary<string, DateTime> dateFilters)
        {
            DataTable dataTable = new DataTable();
            InsertTitles(dataTable);

            List<string[]> orders = DataGridViewOrders.GetDataOrders(dateFilters);
            InseertDataOrders(dataTable, orders);
            return dataTable;
        }

        private static void InseertDataOrders(DataTable dataTable, List<string[]> orders)
        {
            foreach(string[] order in orders)
            {
                dataTable.Rows.Add(order);
            }
        }

        private static void InsertTitles(DataTable dataTable)
        {
            dataTable.Columns.Add("ASIN", typeof(string));
            dataTable.Columns.Add("Название", typeof(string));
            dataTable.Columns.Add("Ордер", typeof(string));
            dataTable.Columns.Add("Аккаунт", typeof(string));
            dataTable.Columns.Add("Статус ордера", typeof(string));
            dataTable.Columns.Add("Сумма", typeof(string));
            dataTable.Columns.Add("Дата ордера", typeof(string));
            dataTable.Columns.Add("Отзыв", typeof(string));
            dataTable.Columns.Add("Статус отзыва", typeof(string));
            dataTable.Columns.Add("Дата отзыва", typeof(string));
        }
    }
}
