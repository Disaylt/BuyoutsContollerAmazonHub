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

namespace BuyoutsContollerAmazonHub.Accounts
{
    public partial class AccountsForm : Form
    {
        private MongoAccounts _mongoAccounts;
        private MongoOrders _mongoOrders;
        private MongoBankCards _mongoBankCards;
        private MongoQiwiAccount _mongoQiwiAccount;
        public MainMenu MainMenu { get; set; }
        public AccountsForm()
        {
            InitializeComponent();
            DataGridViewAccounts.DataGridViewPlannigDB = dataGridViewAccounts;
        }
        private void UpdateDataGridPlanningOrders()
        {
            List<DataAccount> accounts = GetDataAccounts();
            List<OrderData> orders = _mongoOrders.GetOrders();
            DataGridViewAccounts.UpdateDataGrid(accounts, orders);
        }

        private void UpdateStatistic()
        {
            Dictionary<string, int> statistic = DataGridViewAccounts.GetStatistic();
            string statsString = string.Empty;
            foreach(var stats in statistic)
            {
                statsString += $"{stats.Key} {stats.Value}\n";
            }
            richTextBoxAccountsInfo.Text = statsString;
        }

        private List<DataAccount> GetDataAccounts()
        {
            Dictionary<string, DateTime> filterDate = GetDateFilter();
            List<DataAccount> accounts = _mongoAccounts.GetDataAccounts(filterDate);
            _mongoBankCards.UpdateAcountsBankData(accounts);
            _mongoQiwiAccount.UpdateAcountsQiwiData(accounts);
            return accounts;
        }

        private Dictionary<string, DateTime> GetDateFilter()
        {
            Dictionary<string, DateTime> dateFilter = new Dictionary<string, DateTime>();
            if (checkBoxFromDate.Checked == true)
            {
                dateFilter.Add("from", dateTimePickerFrom.Value);
            }
            if (checkBoxToDate.Checked == true)
            {
                dateFilter.Add("to", dateTimePickerTo.Value);
            }
            return dateFilter;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AccountsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ApplicationWindows.BackToMainMenu(this);
        }

        private void AccountsForm_Load(object sender, EventArgs e)
        {
            _mongoAccounts = new MongoAccounts(MainMenu.MongoConnecter);
            _mongoOrders = new MongoOrders(MainMenu.MongoConnecter);
            _mongoBankCards = new MongoBankCards(MainMenu.MongoConnecter);
            _mongoQiwiAccount = new MongoQiwiAccount(MainMenu.MongoConnecter);
            comboBoxStatusACcount.SelectedItem = "Все";
            comboBoxStatusQIWI.SelectedItem = "Все";
            UpdateDataGridPlanningOrders();
            UpdateStatistic();
        }

        private void FilterDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateDataGridPlanningOrders();
            UpdateStatistic();
        }

        private void dataGridViewAccounts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var newValue = dataGridViewAccounts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            string account = (string)dataGridViewAccounts.Rows[e.RowIndex].Cells[0].Value;
            if (newValue == DBNull.Value)
            {
                _mongoAccounts.UpdateComment(string.Empty, account);
            }
            else
            {
                _mongoAccounts.UpdateComment((string)newValue, account);
            }
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> filters = new Dictionary<string, string>
            {
                {PlanningTableColumnsName.Session, textBoxAccount.Text },
                {PlanningTableColumnsName.IsActive, (string)comboBoxStatusACcount.SelectedItem },
                {PlanningTableColumnsName.IsQIWIActive, (string)comboBoxStatusQIWI.SelectedItem }
            };
            string filterString = FilterDataGridAccounts.GetFilter(filters);
            DataGridViewAccounts.UpdateFilter(filterString);
        }
    }
}
