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
using System.IO;

namespace BuyoutsContollerAmazonHub.Planning
{
    public partial class PlanningForm : Form
    {
        private List<OrderData> _orders;
        private List<OrderData> _planningOrders;
        public MainMenu MainMenu { get; set; }
        public PlanningForm()
        {
            InitializeComponent();
            _orders = new List<OrderData>();
            _planningOrders = new List<OrderData>();
        }

        private void SetPlanningFormInterfaceStatus(bool status)
        {
            dateTimePickerPlannnig.Enabled = status;
            buttonDistribution.Enabled = status;
            buttonLoadExcelClientOrders.Enabled = status;
        }

        private void UpdatePlanningListBox()
        {
            listBoxPlanningOrders.Items.Clear();
            foreach(OrderData order in _planningOrders)
            {
                listBoxPlanningOrders.Items.Add($"Account - {order.Session}");
            }
        }

        private async void ButtonLoadExcelClientOrders_Click(object sender, EventArgs e)
        {
            openFileDialogExcel.ShowDialog();
            if (openFileDialogExcel.FileName != string.Empty)
            {
                _orders = ExcelReader.GetExcelClientOrder(openFileDialogExcel.FileName);
                PlanningHandler planningHandler = new PlanningHandler(MainMenu.MongoConnecter);
                SetPlanningFormInterfaceStatus(false);
                try
                {
                    ProgressBarPlanning.Value = 50;
                    await Task.Run(() => _planningOrders = planningHandler.GetPlannnigOrders(_orders));
                    UpdatePlanningListBox();
                    labelProductsPlanning.Text = $"Товаров: {_planningOrders.Count}";
                    ProgressBarPlanning.Value = 100;
                }
                catch(Exception)
                {
                    MessageBox.Show("Нехватает аккаунтов.");
                    ProgressBarPlanning.Value = 0;
                }
                SetPlanningFormInterfaceStatus(true);
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PlanningForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ApplicationWindows.BackToMainMenu(this);
        }

        private void buttonDistribution_Click(object sender, EventArgs e)
        {
            MongoPlannig mongoPlannig = new MongoPlannig(MainMenu.MongoConnecter);
            mongoPlannig.InsertNewPlanningOrders(_planningOrders, dateTimePickerPlannnig.Value);
            _orders.Clear();
            _planningOrders.Clear();
            UpdatePlanningListBox();
        }
    }
}
