
namespace BuyoutsContollerAmazonHub.PlannningDB
{
    partial class PlanningDBForm
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
            this.dataGridViewPlanningDB = new System.Windows.Forms.DataGridView();
            this.comboBoxCompete = new System.Windows.Forms.ComboBox();
            this.labelComplete = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxSession = new System.Windows.Forms.TextBox();
            this.labelSession = new System.Windows.Forms.Label();
            this.textBoxSKU = new System.Windows.Forms.TextBox();
            this.labelSKU = new System.Windows.Forms.Label();
            this.textBoxManager = new System.Windows.Forms.TextBox();
            this.labelManager = new System.Windows.Forms.Label();
            this.buttonFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanningDB)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.White;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Location = new System.Drawing.Point(12, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 27;
            this.buttonClose.Text = "<- Назад";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // dataGridViewPlanningDB
            // 
            this.dataGridViewPlanningDB.AllowUserToAddRows = false;
            this.dataGridViewPlanningDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPlanningDB.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPlanningDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlanningDB.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewPlanningDB.Name = "dataGridViewPlanningDB";
            this.dataGridViewPlanningDB.Size = new System.Drawing.Size(702, 469);
            this.dataGridViewPlanningDB.TabIndex = 28;
            this.dataGridViewPlanningDB.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPlanningDB_CellValueChanged);
            this.dataGridViewPlanningDB.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewPlanningDB_UserDeletingRow);
            // 
            // comboBoxCompete
            // 
            this.comboBoxCompete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCompete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxCompete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCompete.FormattingEnabled = true;
            this.comboBoxCompete.Items.AddRange(new object[] {
            "Все",
            "Да",
            "Нет"});
            this.comboBoxCompete.Location = new System.Drawing.Point(720, 67);
            this.comboBoxCompete.Name = "comboBoxCompete";
            this.comboBoxCompete.Size = new System.Drawing.Size(130, 21);
            this.comboBoxCompete.TabIndex = 40;
            // 
            // labelComplete
            // 
            this.labelComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelComplete.AutoSize = true;
            this.labelComplete.Location = new System.Drawing.Point(856, 75);
            this.labelComplete.Name = "labelComplete";
            this.labelComplete.Size = new System.Drawing.Size(58, 13);
            this.labelComplete.TabIndex = 42;
            this.labelComplete.Text = "Выполнен";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDate.Location = new System.Drawing.Point(720, 41);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(130, 20);
            this.dateTimePickerDate.TabIndex = 43;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.DateTimePickerDate_ValueChanged);
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(856, 48);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 13);
            this.labelDate.TabIndex = 44;
            this.labelDate.Text = "Дата";
            // 
            // textBoxSession
            // 
            this.textBoxSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSession.Location = new System.Drawing.Point(720, 94);
            this.textBoxSession.Name = "textBoxSession";
            this.textBoxSession.Size = new System.Drawing.Size(130, 20);
            this.textBoxSession.TabIndex = 45;
            // 
            // labelSession
            // 
            this.labelSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSession.AutoSize = true;
            this.labelSession.Location = new System.Drawing.Point(856, 101);
            this.labelSession.Name = "labelSession";
            this.labelSession.Size = new System.Drawing.Size(48, 13);
            this.labelSession.TabIndex = 46;
            this.labelSession.Text = "Аккаунт";
            // 
            // textBoxSKU
            // 
            this.textBoxSKU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSKU.Location = new System.Drawing.Point(720, 120);
            this.textBoxSKU.Name = "textBoxSKU";
            this.textBoxSKU.Size = new System.Drawing.Size(130, 20);
            this.textBoxSKU.TabIndex = 47;
            // 
            // labelSKU
            // 
            this.labelSKU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSKU.AutoSize = true;
            this.labelSKU.Location = new System.Drawing.Point(856, 127);
            this.labelSKU.Name = "labelSKU";
            this.labelSKU.Size = new System.Drawing.Size(32, 13);
            this.labelSKU.TabIndex = 48;
            this.labelSKU.Text = "ASIN";
            // 
            // textBoxManager
            // 
            this.textBoxManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxManager.Location = new System.Drawing.Point(720, 146);
            this.textBoxManager.Name = "textBoxManager";
            this.textBoxManager.Size = new System.Drawing.Size(130, 20);
            this.textBoxManager.TabIndex = 49;
            // 
            // labelManager
            // 
            this.labelManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelManager.AutoSize = true;
            this.labelManager.Location = new System.Drawing.Point(856, 153);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(60, 13);
            this.labelManager.TabIndex = 50;
            this.labelManager.Text = "Менеджер";
            // 
            // buttonFilter
            // 
            this.buttonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilter.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFilter.Location = new System.Drawing.Point(720, 172);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(130, 21);
            this.buttonFilter.TabIndex = 51;
            this.buttonFilter.Text = "Искать";
            this.buttonFilter.UseVisualStyleBackColor = false;
            this.buttonFilter.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // PlanningDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 522);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.textBoxManager);
            this.Controls.Add(this.labelSKU);
            this.Controls.Add(this.textBoxSKU);
            this.Controls.Add(this.labelSession);
            this.Controls.Add(this.textBoxSession);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelComplete);
            this.Controls.Add(this.comboBoxCompete);
            this.Controls.Add(this.dataGridViewPlanningDB);
            this.Controls.Add(this.buttonClose);
            this.Name = "PlanningDBForm";
            this.Text = "PlanningDBForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlanningDBForm_FormClosing);
            this.Load += new System.EventHandler(this.PlanningDBForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanningDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridViewPlanningDB;
        private System.Windows.Forms.ComboBox comboBoxCompete;
        private System.Windows.Forms.Label labelComplete;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxSession;
        private System.Windows.Forms.Label labelSession;
        private System.Windows.Forms.TextBox textBoxSKU;
        private System.Windows.Forms.Label labelSKU;
        private System.Windows.Forms.TextBox textBoxManager;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.Button buttonFilter;
    }
}