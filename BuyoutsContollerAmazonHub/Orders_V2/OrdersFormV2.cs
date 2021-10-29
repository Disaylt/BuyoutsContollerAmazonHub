using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyoutsContollerAmazonHub.Orders_V2
{
    public partial class OrdersFormV2 : Form
    {
        public MainMenu MainMenu { get; set; }
        public OrdersFormV2()
        {
            InitializeComponent();
        }

        private void UpdateDataGrid()
        {
            Dictionary<string, DateTime> dateFilter = GetDateFilter();
            DataGridViewOrders.UpdateDataGrid(dateFilter);
        }

        private Dictionary<string, DateTime> GetDateFilter()
        {
            Dictionary<string, DateTime> dateFilter = new Dictionary<string, DateTime>();
            if(checkBoxFromDate.Checked == true)
            {
                dateFilter.Add("from", dateTimePickerFrom.Value);
            }
            if(checkBoxToDate.Checked == true)
            {
                dateFilter.Add("to", dateTimePickerTo.Value);
            }
            return dateFilter;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OrdersFormV2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ApplicationWindows.BackToMainMenu(this);
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void OrdersFormV2_Load(object sender, EventArgs e)
        {
            DataGridViewOrders.SetDataGrid(dataGridViewOrders, MainMenu.MongoConnecter);
            UpdateDataGrid();
        }

        private void DataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxCellValue.Text = (string)dataGridViewOrders.SelectedCells[0].Value;
            }
            catch (ArgumentOutOfRangeException)
            {
                textBoxCellValue.Text = "Неизвестно";
            }
        }

        private void DataGridViewOrders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewOrders.Rows.Count != 0)
            {
                string orderId = (string)dataGridViewOrders.Rows[e.RowIndex].Cells[2].Value;
                string value = (string)dataGridViewOrders.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                DataGridViewOrders.UpdateCell(e.ColumnIndex, orderId, value);
            }
        }

        private void ButtonExportExcel_Click(object sender, EventArgs e)
        {
            saveFileDialogExcel.ShowDialog();
            Dictionary<string, DateTime> dateFilter = GetDateFilter();
            ExcelCreator.CreateNewExcelFile(saveFileDialogExcel.FileName, dateFilter);
        }

        private void FilterDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }
    }
}
