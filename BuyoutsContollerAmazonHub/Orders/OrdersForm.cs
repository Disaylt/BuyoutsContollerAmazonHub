using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuyoutsContollerAmazonHub.Documents;

namespace BuyoutsContollerAmazonHub.Orders
{
    public partial class OrdersForm : Form
    {
        public MainMenu MainMenu { get; set; }
        public OrdersForm()
        {
            InitializeComponent();
            DataGridViewOrders.DataGridViewOrdersDB = dataGridViewOrders;
        }

        private void UpdateDataGridPlanningOrders()
        {
            MongoOrders mongoOrders = new MongoOrders(MainMenu.MongoConnecter);
            List<OrderData> orders = mongoOrders.GetOrders();
            DataGridViewOrders.UpdateDataGrid(orders);
            UpdateFilter();
        }
        private void UpdateFilter()
        {
            Dictionary<string, string> filters = new Dictionary<string, string>
            {
                {PlanningTableColumnsName.Session, textBoxSession.Text },
                {PlanningTableColumnsName.SKU, textBoxSKU.Text },
            };
            DataGridViewOrders.UpdateFilter(filters);
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OrdersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ApplicationWindows.BackToMainMenu(this);
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            UpdateDataGridPlanningOrders();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            UpdateDataGridPlanningOrders();
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            UpdateFilter();
        }
    }
}
