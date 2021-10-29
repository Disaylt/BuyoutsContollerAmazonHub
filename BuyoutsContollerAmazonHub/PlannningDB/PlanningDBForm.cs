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

namespace BuyoutsContollerAmazonHub.PlannningDB
{
    public partial class PlanningDBForm : Form
    {
        private List<OrderData> _ordersData;
        private MongoPlannnigDB _mongoPlannnig;
        private MongoBankCards _mongoBankCards;
        private MongoQiwiAccounts _mongoQiwiAccounts;
        private MongoOrders _mongoOrders;
        public MainMenu MainMenu { get; set; }
        public PlanningDBForm()
        {
            InitializeComponent();
            comboBoxCompete.SelectedItem = "Все";
            DataGridViewPlanningDB.DataGridViewPlannigDB = dataGridViewPlanningDB;
        }

        private void UpdateOrderDate()
        {
            _ordersData = _mongoPlannnig.GetPlannnigOrders(dateTimePickerDate.Value);
            Dictionary<string, string> qiwiAccounts = _mongoBankCards.GetAccountsWithQiwi();
            Dictionary<string, double> qiwiBalance = _mongoQiwiAccounts.GetAccountsWithBalance();
            Dictionary<string, int> qiwiSimcardSlots = _mongoQiwiAccounts.GetAccountsWithSimSlot();
            foreach(OrderData order in _ordersData)
            {
                if(qiwiAccounts.ContainsKey(order.Session))
                {
                    string qiwiNumber = qiwiAccounts[order.Session];
                    order.PhoneNumberQiwi = qiwiNumber;
                    order.Total = qiwiBalance[qiwiNumber];
                    order.SlotSimCard = qiwiSimcardSlots[qiwiNumber];
                }
                else
                {
                    order.PhoneNumberQiwi = string.Empty;
                    order.Total = 0;
                    order.SlotSimCard = 0;
                }
            }
            _mongoOrders.UpdateCountOrders(_ordersData);
        }

        private void UpdateDataGridPlanningOrders()
        {
            UpdateOrderDate();
            DataGridViewPlanningDB.UpdateDataGridViewPlanningDB(_ordersData);
            UpdateFilter();
        }

        private void UpdateFilter()
        {
            Dictionary<string, string> filters = new Dictionary<string, string>
            {
                {PlanningTableColumnsName.IsComelete, (string)comboBoxCompete.SelectedItem },
                {PlanningTableColumnsName.Session, textBoxSession.Text },
                {PlanningTableColumnsName.SKU, textBoxSKU.Text },
                {PlanningTableColumnsName.Manager, textBoxManager.Text }
            };
            DataGridViewPlanningDB.UpdateFilter(filters);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PlanningDBForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ApplicationWindows.BackToMainMenu(this);
        }

        private void DateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateDataGridPlanningOrders();
        }

        private void PlanningDBForm_Load(object sender, EventArgs e)
        {
            _mongoPlannnig = new MongoPlannnigDB(MainMenu.MongoConnecter);
            _mongoBankCards = new MongoBankCards(MainMenu.MongoConnecter);
            _mongoQiwiAccounts = new MongoQiwiAccounts(MainMenu.MongoConnecter);
            _mongoOrders = new MongoOrders(MainMenu.MongoConnecter);
            UpdateDataGridPlanningOrders();
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void DataGridViewPlanningDB_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string id = (string)dataGridViewPlanningDB.Rows[e.RowIndex].Cells[7].Value;
            switch (e.ColumnIndex)
            {
                case 5:
                    bool status = (bool)dataGridViewPlanningDB.Rows[e.RowIndex].Cells[5].Value;
                    _mongoPlannnig.UpdateTaskStatus(id, status);
                    break;
                case 6:
                    string description;
                    try
                    {
                        description = (string)dataGridViewPlanningDB.Rows[e.RowIndex].Cells[6].Value;
                    }
                    catch(InvalidCastException)
                    {
                        description = string.Empty;
                    }
                    _mongoPlannnig.UpdateDescription(id, description);
                    break;
            }
        }

        private void dataGridViewPlanningDB_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string orderId = e.Row.Cells[7].Value as string;
            _mongoPlannnig.DeletedDocumentFromDB(orderId);
        }
    }
}
