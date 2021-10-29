
namespace BuyoutsContollerAmazonHub.Orders
{
    partial class OrdersForm
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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.labelSKU = new System.Windows.Forms.Label();
            this.textBoxSKU = new System.Windows.Forms.TextBox();
            this.labelSession = new System.Windows.Forms.Label();
            this.textBoxSession = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.Size = new System.Drawing.Size(659, 481);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilter.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFilter.Location = new System.Drawing.Point(677, 90);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(130, 23);
            this.buttonFilter.TabIndex = 56;
            this.buttonFilter.Text = "Искать";
            this.buttonFilter.UseVisualStyleBackColor = false;
            this.buttonFilter.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // labelSKU
            // 
            this.labelSKU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSKU.AutoSize = true;
            this.labelSKU.Location = new System.Drawing.Point(813, 71);
            this.labelSKU.Name = "labelSKU";
            this.labelSKU.Size = new System.Drawing.Size(32, 13);
            this.labelSKU.TabIndex = 55;
            this.labelSKU.Text = "ASIN";
            // 
            // textBoxSKU
            // 
            this.textBoxSKU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSKU.Location = new System.Drawing.Point(677, 64);
            this.textBoxSKU.Name = "textBoxSKU";
            this.textBoxSKU.Size = new System.Drawing.Size(130, 20);
            this.textBoxSKU.TabIndex = 54;
            // 
            // labelSession
            // 
            this.labelSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSession.AutoSize = true;
            this.labelSession.Location = new System.Drawing.Point(813, 45);
            this.labelSession.Name = "labelSession";
            this.labelSession.Size = new System.Drawing.Size(48, 13);
            this.labelSession.TabIndex = 53;
            this.labelSession.Text = "Аккаунт";
            // 
            // textBoxSession
            // 
            this.textBoxSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSession.Location = new System.Drawing.Point(677, 38);
            this.textBoxSession.Name = "textBoxSession";
            this.textBoxSession.Size = new System.Drawing.Size(130, 20);
            this.textBoxSession.TabIndex = 52;
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Location = new System.Drawing.Point(11, 9);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 57;
            this.buttonClose.Text = "<- Назад";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Location = new System.Drawing.Point(92, 9);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(579, 23);
            this.buttonRefresh.TabIndex = 58;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 531);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.labelSKU);
            this.Controls.Add(this.textBoxSKU);
            this.Controls.Add(this.labelSession);
            this.Controls.Add(this.textBoxSession);
            this.Controls.Add(this.dataGridViewOrders);
            this.MinimumSize = new System.Drawing.Size(890, 570);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrdersForm_FormClosing);
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label labelSKU;
        private System.Windows.Forms.TextBox textBoxSKU;
        private System.Windows.Forms.Label labelSession;
        private System.Windows.Forms.TextBox textBoxSession;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRefresh;
    }
}