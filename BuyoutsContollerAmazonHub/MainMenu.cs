using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuyoutsContollerAmazonHub.Planning;
using BuyoutsContollerAmazonHub.PlannningDB;
using BuyoutsContollerAmazonHub.Orders;
using BuyoutsContollerAmazonHub.Accounts;
using BuyoutsContollerAmazonHub.ItemsBase;
using BuyoutsContollerAmazonHub.Orders_V2;

namespace BuyoutsContollerAmazonHub
{
    public partial class MainMenu : Form
    {
        public PlanningForm PlanningForm { get; set; }
        public PlanningDBForm PlanningDBForm { get; set; }
        public OrdersForm OrdersForm { get; set; }
        public AccountsForm AccountsForm { get; set; }
        public ItemsBaseForm ItemBaseForm { get; set; }
        public MongoConnecter MongoConnecter { get; set; }
        public OrdersFormV2 OrdersFormV2 { get; set; }
        public MainMenu()
        {
            InitializeComponent();
            MongoConnecter = new MongoConnecter();
            ApplicationWindows.SetMainMenu(this);
        }

        private void ButtonPlannnig_Click(object sender, EventArgs e)
        {
            if(PlanningForm == null)
            {
                PlanningForm = new PlanningForm
                {
                    MainMenu = this
                };
            }
            ApplicationWindows.ShowNewForm(PlanningForm);

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonPlanningBd_Click(object sender, EventArgs e)
        {
            if(PlanningDBForm == null)
            {
                PlanningDBForm = new PlanningDBForm
                {
                    MainMenu = this
                };
            }
            ApplicationWindows.ShowNewForm(PlanningDBForm);
        }

        private void ButtonOrders_Click(object sender, EventArgs e)
        {
            if (OrdersForm == null)
            {
                OrdersForm = new OrdersForm
                {
                    MainMenu = this
                };
            }
            ApplicationWindows.ShowNewForm(OrdersForm);
        }

        private void ButtonAccounts_Click(object sender, EventArgs e)
        {
            if (AccountsForm == null)
            {
                AccountsForm = new AccountsForm
                {
                    MainMenu = this
                };
            }
            ApplicationWindows.ShowNewForm(AccountsForm);
        }

        private void ButtonItemsBase_Click(object sender, EventArgs e)
        {
            if (ItemBaseForm == null)
            {
                ItemBaseForm = new ItemsBaseForm
                {
                    MainMenu = this
                };
            }
            ApplicationWindows.ShowNewForm(ItemBaseForm);
        }

        private void ButtonOrderV2_Click(object sender, EventArgs e)
        {
            if (OrdersFormV2 == null)
            {
                OrdersFormV2 = new OrdersFormV2
                {
                    MainMenu = this
                };
            }
            ApplicationWindows.ShowNewForm(OrdersFormV2);
        }
    }
}
