
namespace BuyoutsContollerAmazonHub.Planning
{
    partial class PlanningForm
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
            this.buttonLoadExcelClientOrders = new System.Windows.Forms.Button();
            this.openFileDialogExcel = new System.Windows.Forms.OpenFileDialog();
            this.buttonClose = new System.Windows.Forms.Button();
            this.listBoxPlanningOrders = new System.Windows.Forms.ListBox();
            this.ProgressBarPlanning = new System.Windows.Forms.ProgressBar();
            this.dateTimePickerPlannnig = new System.Windows.Forms.DateTimePicker();
            this.buttonDistribution = new System.Windows.Forms.Button();
            this.labelDescriptionPlanning = new System.Windows.Forms.Label();
            this.labelProductsPlanning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLoadExcelClientOrders
            // 
            this.buttonLoadExcelClientOrders.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonLoadExcelClientOrders.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonLoadExcelClientOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLoadExcelClientOrders.Location = new System.Drawing.Point(272, 403);
            this.buttonLoadExcelClientOrders.Name = "buttonLoadExcelClientOrders";
            this.buttonLoadExcelClientOrders.Size = new System.Drawing.Size(150, 23);
            this.buttonLoadExcelClientOrders.TabIndex = 24;
            this.buttonLoadExcelClientOrders.Text = "Загрузить excel";
            this.buttonLoadExcelClientOrders.UseVisualStyleBackColor = false;
            this.buttonLoadExcelClientOrders.Click += new System.EventHandler(this.ButtonLoadExcelClientOrders_Click);
            // 
            // openFileDialogExcel
            // 
            this.openFileDialogExcel.Filter = "Excel|*.xlsx";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Location = new System.Drawing.Point(15, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 26;
            this.buttonClose.Text = "<- Назад";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // listBoxPlanningOrders
            // 
            this.listBoxPlanningOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listBoxPlanningOrders.FormattingEnabled = true;
            this.listBoxPlanningOrders.Location = new System.Drawing.Point(15, 41);
            this.listBoxPlanningOrders.Name = "listBoxPlanningOrders";
            this.listBoxPlanningOrders.Size = new System.Drawing.Size(251, 355);
            this.listBoxPlanningOrders.TabIndex = 27;
            // 
            // ProgressBarPlanning
            // 
            this.ProgressBarPlanning.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProgressBarPlanning.Location = new System.Drawing.Point(96, 12);
            this.ProgressBarPlanning.Name = "ProgressBarPlanning";
            this.ProgressBarPlanning.Size = new System.Drawing.Size(170, 23);
            this.ProgressBarPlanning.TabIndex = 28;
            // 
            // dateTimePickerPlannnig
            // 
            this.dateTimePickerPlannnig.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateTimePickerPlannnig.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight;
            this.dateTimePickerPlannnig.Location = new System.Drawing.Point(15, 403);
            this.dateTimePickerPlannnig.Name = "dateTimePickerPlannnig";
            this.dateTimePickerPlannnig.Size = new System.Drawing.Size(149, 20);
            this.dateTimePickerPlannnig.TabIndex = 29;
            // 
            // buttonDistribution
            // 
            this.buttonDistribution.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDistribution.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonDistribution.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDistribution.Location = new System.Drawing.Point(170, 403);
            this.buttonDistribution.Name = "buttonDistribution";
            this.buttonDistribution.Size = new System.Drawing.Size(96, 23);
            this.buttonDistribution.TabIndex = 30;
            this.buttonDistribution.Text = "Запланировать";
            this.buttonDistribution.UseVisualStyleBackColor = false;
            this.buttonDistribution.Click += new System.EventHandler(this.buttonDistribution_Click);
            // 
            // labelDescriptionPlanning
            // 
            this.labelDescriptionPlanning.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDescriptionPlanning.AutoSize = true;
            this.labelDescriptionPlanning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescriptionPlanning.Location = new System.Drawing.Point(272, 19);
            this.labelDescriptionPlanning.Name = "labelDescriptionPlanning";
            this.labelDescriptionPlanning.Size = new System.Drawing.Size(107, 16);
            this.labelDescriptionPlanning.TabIndex = 32;
            this.labelDescriptionPlanning.Text = "Распределено:";
            // 
            // labelProductsPlanning
            // 
            this.labelProductsPlanning.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelProductsPlanning.AutoSize = true;
            this.labelProductsPlanning.Location = new System.Drawing.Point(272, 41);
            this.labelProductsPlanning.Name = "labelProductsPlanning";
            this.labelProductsPlanning.Size = new System.Drawing.Size(53, 13);
            this.labelProductsPlanning.TabIndex = 34;
            this.labelProductsPlanning.Text = "Товаров:";
            // 
            // PlanningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 444);
            this.Controls.Add(this.labelProductsPlanning);
            this.Controls.Add(this.labelDescriptionPlanning);
            this.Controls.Add(this.buttonDistribution);
            this.Controls.Add(this.dateTimePickerPlannnig);
            this.Controls.Add(this.ProgressBarPlanning);
            this.Controls.Add(this.listBoxPlanningOrders);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonLoadExcelClientOrders);
            this.MinimumSize = new System.Drawing.Size(455, 483);
            this.Name = "PlanningForm";
            this.Text = "Planning";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlanningForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadExcelClientOrders;
        private System.Windows.Forms.OpenFileDialog openFileDialogExcel;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ListBox listBoxPlanningOrders;
        public System.Windows.Forms.ProgressBar ProgressBarPlanning;
        private System.Windows.Forms.DateTimePicker dateTimePickerPlannnig;
        private System.Windows.Forms.Button buttonDistribution;
        private System.Windows.Forms.Label labelDescriptionPlanning;
        private System.Windows.Forms.Label labelProductsPlanning;
    }
}