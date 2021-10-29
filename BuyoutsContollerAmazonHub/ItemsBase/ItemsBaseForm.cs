using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyoutsContollerAmazonHub.ItemsBase
{
    public partial class ItemsBaseForm : Form
    {
        private MongoItems _mongoItems;
        public MainMenu MainMenu { get; set; }
        public ItemsBaseForm()
        {
            InitializeComponent(); 
            DataGridViewItemsBase.DataGridViewPlannigDB = dataGridViewItems;
        }

        private void UpdateDataGridPlanningOrders()
        {
            List<string[]> items = _mongoItems.GetItems();
            DataGridViewItemsBase.UpdateDataGrid(items);
            DataGridViewItemsBase.UpdateFilter(textBoxAsin.Text);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ItemBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ApplicationWindows.BackToMainMenu(this);
        }

        private void ItemBaseForm_Load(object sender, EventArgs e)
        {
            _mongoItems = new MongoItems(MainMenu.MongoConnecter);
            UpdateDataGridPlanningOrders();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxAsin.Text) && !string.IsNullOrEmpty(textBoxTitle.Text))
            {
                _mongoItems.UpdateTitle(textBoxAsin.Text, textBoxTitle.Text);
                UpdateDataGridPlanningOrders();
                textBoxTitle.Text = string.Empty;
            }
        }

        private void dataGridViewItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void dataGridViewItems_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridViewItems.Rows.Count != 0)
            {
                string asin = (string)e.Row.Cells[0].Value;
                _mongoItems.DeleteAsin(asin);
            }
        }

        private void TextBoxAsin_TextChanged(object sender, EventArgs e)
        {
            DataGridViewItemsBase.UpdateFilter(textBoxAsin.Text);
        }
    }
}
