
namespace BuyoutsContollerAmazonHub.Orders_V2
{
    partial class OrdersFormV2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxCellValue = new System.Windows.Forms.TextBox();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.OrdersColumnASIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersColumnItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersColumnOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersColumnAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersColumnStatusOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersColumnDateOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersColumnReviewText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersColumnStatusReview = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OrdersColumnDateReview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxFromDate = new System.Windows.Forms.CheckBox();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.checkBoxToDate = new System.Windows.Forms.CheckBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.buttonExportExcel = new System.Windows.Forms.Button();
            this.saveFileDialogExcel = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Location = new System.Drawing.Point(12, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 22);
            this.buttonClose.TabIndex = 58;
            this.buttonClose.Text = "<- Назад";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Location = new System.Drawing.Point(666, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(81, 22);
            this.buttonRefresh.TabIndex = 60;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // textBoxCellValue
            // 
            this.textBoxCellValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCellValue.BackColor = System.Drawing.Color.White;
            this.textBoxCellValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCellValue.Location = new System.Drawing.Point(93, 12);
            this.textBoxCellValue.Name = "textBoxCellValue";
            this.textBoxCellValue.ReadOnly = true;
            this.textBoxCellValue.Size = new System.Drawing.Size(567, 22);
            this.textBoxCellValue.TabIndex = 61;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrders.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrdersColumnASIN,
            this.OrdersColumnItemName,
            this.OrdersColumnOrderId,
            this.OrdersColumnAccount,
            this.OrdersColumnStatusOrder,
            this.OrdersColumnTotal,
            this.OrdersColumnDateOrder,
            this.OrdersColumnReviewText,
            this.OrdersColumnStatusReview,
            this.OrdersColumnDateReview});
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(735, 509);
            this.dataGridViewOrders.TabIndex = 62;
            this.dataGridViewOrders.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewOrders_CellValueChanged);
            this.dataGridViewOrders.SelectionChanged += new System.EventHandler(this.DataGridViewOrders_SelectionChanged);
            // 
            // OrdersColumnASIN
            // 
            this.OrdersColumnASIN.HeaderText = "ASIN";
            this.OrdersColumnASIN.Name = "OrdersColumnASIN";
            this.OrdersColumnASIN.ReadOnly = true;
            // 
            // OrdersColumnItemName
            // 
            this.OrdersColumnItemName.HeaderText = "Название";
            this.OrdersColumnItemName.Name = "OrdersColumnItemName";
            this.OrdersColumnItemName.ReadOnly = true;
            // 
            // OrdersColumnOrderId
            // 
            this.OrdersColumnOrderId.HeaderText = "Ордер";
            this.OrdersColumnOrderId.Name = "OrdersColumnOrderId";
            this.OrdersColumnOrderId.ReadOnly = true;
            // 
            // OrdersColumnAccount
            // 
            this.OrdersColumnAccount.HeaderText = "Аккаунт";
            this.OrdersColumnAccount.Name = "OrdersColumnAccount";
            this.OrdersColumnAccount.ReadOnly = true;
            // 
            // OrdersColumnStatusOrder
            // 
            this.OrdersColumnStatusOrder.HeaderText = "Статус ордера";
            this.OrdersColumnStatusOrder.Name = "OrdersColumnStatusOrder";
            this.OrdersColumnStatusOrder.ReadOnly = true;
            // 
            // OrdersColumnTotal
            // 
            this.OrdersColumnTotal.HeaderText = "Сумма";
            this.OrdersColumnTotal.Name = "OrdersColumnTotal";
            this.OrdersColumnTotal.ReadOnly = true;
            // 
            // OrdersColumnDateOrder
            // 
            this.OrdersColumnDateOrder.HeaderText = "Дата ордера";
            this.OrdersColumnDateOrder.Name = "OrdersColumnDateOrder";
            this.OrdersColumnDateOrder.ReadOnly = true;
            // 
            // OrdersColumnReviewText
            // 
            this.OrdersColumnReviewText.HeaderText = "Текст отзыва";
            this.OrdersColumnReviewText.Name = "OrdersColumnReviewText";
            // 
            // OrdersColumnStatusReview
            // 
            this.OrdersColumnStatusReview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OrdersColumnStatusReview.HeaderText = "Статус отзыва";
            this.OrdersColumnStatusReview.Items.AddRange(new object[] {
            "На модерации",
            "5 звезд",
            "Опубликован",
            "Не опубликован",
            "Без отзыва",
            "Удален"});
            this.OrdersColumnStatusReview.Name = "OrdersColumnStatusReview";
            this.OrdersColumnStatusReview.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersColumnStatusReview.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // OrdersColumnDateReview
            // 
            this.OrdersColumnDateReview.HeaderText = "Дата отзыва";
            this.OrdersColumnDateReview.Name = "OrdersColumnDateReview";
            // 
            // checkBoxFromDate
            // 
            this.checkBoxFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxFromDate.AutoSize = true;
            this.checkBoxFromDate.Location = new System.Drawing.Point(753, 46);
            this.checkBoxFromDate.Name = "checkBoxFromDate";
            this.checkBoxFromDate.Size = new System.Drawing.Size(32, 17);
            this.checkBoxFromDate.TabIndex = 63;
            this.checkBoxFromDate.Text = "с";
            this.checkBoxFromDate.UseVisualStyleBackColor = true;
            this.checkBoxFromDate.CheckedChanged += new System.EventHandler(this.FilterDate_ValueChanged);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFrom.Location = new System.Drawing.Point(792, 43);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(180, 20);
            this.dateTimePickerFrom.TabIndex = 64;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.FilterDate_ValueChanged);
            // 
            // checkBoxToDate
            // 
            this.checkBoxToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxToDate.AutoSize = true;
            this.checkBoxToDate.Location = new System.Drawing.Point(753, 69);
            this.checkBoxToDate.Name = "checkBoxToDate";
            this.checkBoxToDate.Size = new System.Drawing.Size(38, 17);
            this.checkBoxToDate.TabIndex = 65;
            this.checkBoxToDate.Text = "по";
            this.checkBoxToDate.UseVisualStyleBackColor = true;
            this.checkBoxToDate.CheckedChanged += new System.EventHandler(this.FilterDate_ValueChanged);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTo.Location = new System.Drawing.Point(792, 69);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(180, 20);
            this.dateTimePickerTo.TabIndex = 66;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.FilterDate_ValueChanged);
            // 
            // buttonExportExcel
            // 
            this.buttonExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExportExcel.Location = new System.Drawing.Point(753, 12);
            this.buttonExportExcel.Name = "buttonExportExcel";
            this.buttonExportExcel.Size = new System.Drawing.Size(219, 22);
            this.buttonExportExcel.TabIndex = 67;
            this.buttonExportExcel.Text = "Экспорт (Excel)";
            this.buttonExportExcel.UseVisualStyleBackColor = true;
            this.buttonExportExcel.Click += new System.EventHandler(this.ButtonExportExcel_Click);
            // 
            // saveFileDialogExcel
            // 
            this.saveFileDialogExcel.Filter = "Excel|*.xlsx";
            // 
            // OrdersFormV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.buttonExportExcel);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.checkBoxToDate);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.checkBoxFromDate);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.textBoxCellValue);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonClose);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "OrdersFormV2";
            this.Text = "OrdersFormV2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrdersFormV2_FormClosing);
            this.Load += new System.EventHandler(this.OrdersFormV2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxCellValue;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdersColumnASIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdersColumnItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdersColumnOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdersColumnAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdersColumnStatusOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdersColumnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdersColumnDateOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdersColumnReviewText;
        private System.Windows.Forms.DataGridViewComboBoxColumn OrdersColumnStatusReview;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdersColumnDateReview;
        private System.Windows.Forms.CheckBox checkBoxFromDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.CheckBox checkBoxToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Button buttonExportExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExcel;
    }
}