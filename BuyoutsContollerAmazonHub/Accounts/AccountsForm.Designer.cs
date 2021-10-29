
namespace BuyoutsContollerAmazonHub.Accounts
{
    partial class AccountsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridViewAccounts = new System.Windows.Forms.DataGridView();
            this.richTextBoxAccountsInfo = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.checkBoxToDate = new System.Windows.Forms.CheckBox();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.checkBoxFromDate = new System.Windows.Forms.CheckBox();
            this.textBoxTitleStatusAccount = new System.Windows.Forms.TextBox();
            this.comboBoxStatusQIWI = new System.Windows.Forms.ComboBox();
            this.textBoxConstStatusQIWI = new System.Windows.Forms.TextBox();
            this.comboBoxStatusACcount = new System.Windows.Forms.ComboBox();
            this.textBoxConstAccount = new System.Windows.Forms.TextBox();
            this.textBoxAccount = new System.Windows.Forms.TextBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Location = new System.Drawing.Point(12, 13);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 58;
            this.buttonClose.Text = "<- Назад";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // dataGridViewAccounts
            // 
            this.dataGridViewAccounts.AllowUserToAddRows = false;
            this.dataGridViewAccounts.AllowUserToDeleteRows = false;
            this.dataGridViewAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAccounts.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAccounts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAccounts.Location = new System.Drawing.Point(12, 42);
            this.dataGridViewAccounts.Name = "dataGridViewAccounts";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAccounts.Size = new System.Drawing.Size(885, 517);
            this.dataGridViewAccounts.TabIndex = 59;
            this.dataGridViewAccounts.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccounts_CellValueChanged);
            // 
            // richTextBoxAccountsInfo
            // 
            this.richTextBoxAccountsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxAccountsInfo.Location = new System.Drawing.Point(903, 201);
            this.richTextBoxAccountsInfo.Name = "richTextBoxAccountsInfo";
            this.richTextBoxAccountsInfo.Size = new System.Drawing.Size(219, 358);
            this.richTextBoxAccountsInfo.TabIndex = 60;
            this.richTextBoxAccountsInfo.Text = "";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTo.Location = new System.Drawing.Point(942, 68);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(180, 20);
            this.dateTimePickerTo.TabIndex = 70;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.FilterDate_ValueChanged);
            // 
            // checkBoxToDate
            // 
            this.checkBoxToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxToDate.AutoSize = true;
            this.checkBoxToDate.Location = new System.Drawing.Point(903, 68);
            this.checkBoxToDate.Name = "checkBoxToDate";
            this.checkBoxToDate.Size = new System.Drawing.Size(38, 17);
            this.checkBoxToDate.TabIndex = 69;
            this.checkBoxToDate.Text = "по";
            this.checkBoxToDate.UseVisualStyleBackColor = true;
            this.checkBoxToDate.CheckedChanged += new System.EventHandler(this.FilterDate_ValueChanged);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFrom.Location = new System.Drawing.Point(942, 42);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(180, 20);
            this.dateTimePickerFrom.TabIndex = 68;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.FilterDate_ValueChanged);
            // 
            // checkBoxFromDate
            // 
            this.checkBoxFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxFromDate.AutoSize = true;
            this.checkBoxFromDate.Location = new System.Drawing.Point(903, 45);
            this.checkBoxFromDate.Name = "checkBoxFromDate";
            this.checkBoxFromDate.Size = new System.Drawing.Size(32, 17);
            this.checkBoxFromDate.TabIndex = 67;
            this.checkBoxFromDate.Text = "с";
            this.checkBoxFromDate.UseVisualStyleBackColor = true;
            this.checkBoxFromDate.CheckedChanged += new System.EventHandler(this.FilterDate_ValueChanged);
            // 
            // textBoxTitleStatusAccount
            // 
            this.textBoxTitleStatusAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitleStatusAccount.BackColor = System.Drawing.Color.White;
            this.textBoxTitleStatusAccount.Location = new System.Drawing.Point(903, 94);
            this.textBoxTitleStatusAccount.Name = "textBoxTitleStatusAccount";
            this.textBoxTitleStatusAccount.ReadOnly = true;
            this.textBoxTitleStatusAccount.Size = new System.Drawing.Size(140, 20);
            this.textBoxTitleStatusAccount.TabIndex = 71;
            this.textBoxTitleStatusAccount.Text = "Статус аккаунта";
            this.textBoxTitleStatusAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxStatusQIWI
            // 
            this.comboBoxStatusQIWI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatusQIWI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatusQIWI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxStatusQIWI.FormattingEnabled = true;
            this.comboBoxStatusQIWI.Items.AddRange(new object[] {
            "Все",
            "Активные",
            "Неактивные"});
            this.comboBoxStatusQIWI.Location = new System.Drawing.Point(1049, 120);
            this.comboBoxStatusQIWI.Name = "comboBoxStatusQIWI";
            this.comboBoxStatusQIWI.Size = new System.Drawing.Size(73, 21);
            this.comboBoxStatusQIWI.TabIndex = 74;
            // 
            // textBoxConstStatusQIWI
            // 
            this.textBoxConstStatusQIWI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConstStatusQIWI.BackColor = System.Drawing.Color.White;
            this.textBoxConstStatusQIWI.Location = new System.Drawing.Point(903, 120);
            this.textBoxConstStatusQIWI.Name = "textBoxConstStatusQIWI";
            this.textBoxConstStatusQIWI.ReadOnly = true;
            this.textBoxConstStatusQIWI.Size = new System.Drawing.Size(140, 20);
            this.textBoxConstStatusQIWI.TabIndex = 73;
            this.textBoxConstStatusQIWI.Text = "Статус QIWI";
            this.textBoxConstStatusQIWI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxStatusACcount
            // 
            this.comboBoxStatusACcount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatusACcount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatusACcount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxStatusACcount.FormattingEnabled = true;
            this.comboBoxStatusACcount.Items.AddRange(new object[] {
            "Все",
            "Активные",
            "Неактивные"});
            this.comboBoxStatusACcount.Location = new System.Drawing.Point(1049, 93);
            this.comboBoxStatusACcount.Name = "comboBoxStatusACcount";
            this.comboBoxStatusACcount.Size = new System.Drawing.Size(73, 21);
            this.comboBoxStatusACcount.TabIndex = 75;
            // 
            // textBoxConstAccount
            // 
            this.textBoxConstAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConstAccount.BackColor = System.Drawing.Color.White;
            this.textBoxConstAccount.Location = new System.Drawing.Point(903, 146);
            this.textBoxConstAccount.Name = "textBoxConstAccount";
            this.textBoxConstAccount.ReadOnly = true;
            this.textBoxConstAccount.Size = new System.Drawing.Size(56, 20);
            this.textBoxConstAccount.TabIndex = 76;
            this.textBoxConstAccount.Text = "Аккаунт";
            this.textBoxConstAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAccount
            // 
            this.textBoxAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAccount.BackColor = System.Drawing.Color.White;
            this.textBoxAccount.Location = new System.Drawing.Point(965, 146);
            this.textBoxAccount.Name = "textBoxAccount";
            this.textBoxAccount.Size = new System.Drawing.Size(157, 20);
            this.textBoxAccount.TabIndex = 77;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFilter.Location = new System.Drawing.Point(903, 172);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(219, 23);
            this.buttonFilter.TabIndex = 78;
            this.buttonFilter.Text = "Поиск";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // AccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1134, 571);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.textBoxAccount);
            this.Controls.Add(this.textBoxConstAccount);
            this.Controls.Add(this.comboBoxStatusACcount);
            this.Controls.Add(this.comboBoxStatusQIWI);
            this.Controls.Add(this.textBoxConstStatusQIWI);
            this.Controls.Add(this.textBoxTitleStatusAccount);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.checkBoxToDate);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.checkBoxFromDate);
            this.Controls.Add(this.richTextBoxAccountsInfo);
            this.Controls.Add(this.dataGridViewAccounts);
            this.Controls.Add(this.buttonClose);
            this.MinimumSize = new System.Drawing.Size(1150, 610);
            this.Name = "AccountsForm";
            this.Text = "AccountsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountsForm_FormClosing);
            this.Load += new System.EventHandler(this.AccountsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridViewAccounts;
        private System.Windows.Forms.RichTextBox richTextBoxAccountsInfo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.CheckBox checkBoxToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.CheckBox checkBoxFromDate;
        private System.Windows.Forms.TextBox textBoxTitleStatusAccount;
        private System.Windows.Forms.ComboBox comboBoxStatusQIWI;
        private System.Windows.Forms.TextBox textBoxConstStatusQIWI;
        private System.Windows.Forms.ComboBox comboBoxStatusACcount;
        private System.Windows.Forms.TextBox textBoxConstAccount;
        private System.Windows.Forms.TextBox textBoxAccount;
        private System.Windows.Forms.Button buttonFilter;
    }
}