namespace Client.Forms
{
    partial class AdminProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_Campaigns = new System.Windows.Forms.Label();
            this.l_Donations = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.l_Promotions = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.l_Orders = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.l_Cash = new System.Windows.Forms.Label();
            this.btn_GetCampaigns = new System.Windows.Forms.Button();
            this.btn_GetDonations = new System.Windows.Forms.Button();
            this.btn_GetOrders = new System.Windows.Forms.Button();
            this.dg_Campaigns = new System.Windows.Forms.DataGridView();
            this.dg_Donations = new System.Windows.Forms.DataGridView();
            this.dg_Orders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Campaigns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Donations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Orders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hi ,";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(73, 23);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(65, 25);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Admin";
            this.label_Name.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Donations";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Campaigns";
            // 
            // l_Campaigns
            // 
            this.l_Campaigns.AutoSize = true;
            this.l_Campaigns.Location = new System.Drawing.Point(175, 67);
            this.l_Campaigns.Name = "l_Campaigns";
            this.l_Campaigns.Size = new System.Drawing.Size(22, 25);
            this.l_Campaigns.TabIndex = 4;
            this.l_Campaigns.Text = "0";
            // 
            // l_Donations
            // 
            this.l_Donations.AutoSize = true;
            this.l_Donations.Location = new System.Drawing.Point(175, 105);
            this.l_Donations.Name = "l_Donations";
            this.l_Donations.Size = new System.Drawing.Size(22, 25);
            this.l_Donations.TabIndex = 5;
            this.l_Donations.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Promotions";
            // 
            // l_Promotions
            // 
            this.l_Promotions.AutoSize = true;
            this.l_Promotions.Location = new System.Drawing.Point(175, 146);
            this.l_Promotions.Name = "l_Promotions";
            this.l_Promotions.Size = new System.Drawing.Size(22, 25);
            this.l_Promotions.TabIndex = 7;
            this.l_Promotions.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Total Orders";
            // 
            // l_Orders
            // 
            this.l_Orders.AutoSize = true;
            this.l_Orders.Location = new System.Drawing.Point(175, 196);
            this.l_Orders.Name = "l_Orders";
            this.l_Orders.Size = new System.Drawing.Size(22, 25);
            this.l_Orders.TabIndex = 9;
            this.l_Orders.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Total paid cash";
            // 
            // l_Cash
            // 
            this.l_Cash.AutoSize = true;
            this.l_Cash.Location = new System.Drawing.Point(175, 245);
            this.l_Cash.Name = "l_Cash";
            this.l_Cash.Size = new System.Drawing.Size(22, 25);
            this.l_Cash.TabIndex = 11;
            this.l_Cash.Text = "0";
            // 
            // btn_GetCampaigns
            // 
            this.btn_GetCampaigns.Location = new System.Drawing.Point(392, 62);
            this.btn_GetCampaigns.Name = "btn_GetCampaigns";
            this.btn_GetCampaigns.Size = new System.Drawing.Size(152, 34);
            this.btn_GetCampaigns.TabIndex = 12;
            this.btn_GetCampaigns.Text = "See Campaigns";
            this.btn_GetCampaigns.UseVisualStyleBackColor = true;
            this.btn_GetCampaigns.Click += new System.EventHandler(this.btn_GetCampaigns_Click);
            // 
            // btn_GetDonations
            // 
            this.btn_GetDonations.Location = new System.Drawing.Point(684, 62);
            this.btn_GetDonations.Name = "btn_GetDonations";
            this.btn_GetDonations.Size = new System.Drawing.Size(141, 34);
            this.btn_GetDonations.TabIndex = 13;
            this.btn_GetDonations.Text = "See Donations";
            this.btn_GetDonations.UseVisualStyleBackColor = true;
            this.btn_GetDonations.Click += new System.EventHandler(this.btn_GetDonations_Click);
            // 
            // btn_GetOrders
            // 
            this.btn_GetOrders.Location = new System.Drawing.Point(974, 62);
            this.btn_GetOrders.Name = "btn_GetOrders";
            this.btn_GetOrders.Size = new System.Drawing.Size(112, 34);
            this.btn_GetOrders.TabIndex = 14;
            this.btn_GetOrders.Text = "See Orders";
            this.btn_GetOrders.UseVisualStyleBackColor = true;
            // 
            // dg_Campaigns
            // 
            this.dg_Campaigns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Campaigns.Location = new System.Drawing.Point(318, 121);
            this.dg_Campaigns.Name = "dg_Campaigns";
            this.dg_Campaigns.RowHeadersWidth = 62;
            this.dg_Campaigns.RowTemplate.Height = 33;
            this.dg_Campaigns.Size = new System.Drawing.Size(281, 317);
            this.dg_Campaigns.TabIndex = 16;
            // 
            // dg_Donations
            // 
            this.dg_Donations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Donations.Location = new System.Drawing.Point(605, 121);
            this.dg_Donations.Name = "dg_Donations";
            this.dg_Donations.RowHeadersWidth = 62;
            this.dg_Donations.RowTemplate.Height = 33;
            this.dg_Donations.Size = new System.Drawing.Size(281, 317);
            this.dg_Donations.TabIndex = 17;
            // 
            // dg_Orders
            // 
            this.dg_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Orders.Location = new System.Drawing.Point(891, 121);
            this.dg_Orders.Name = "dg_Orders";
            this.dg_Orders.RowHeadersWidth = 62;
            this.dg_Orders.RowTemplate.Height = 33;
            this.dg_Orders.Size = new System.Drawing.Size(281, 317);
            this.dg_Orders.TabIndex = 18;
            // 
            // AdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 450);
            this.Controls.Add(this.dg_Orders);
            this.Controls.Add(this.dg_Donations);
            this.Controls.Add(this.dg_Campaigns);
            this.Controls.Add(this.btn_GetOrders);
            this.Controls.Add(this.btn_GetDonations);
            this.Controls.Add(this.btn_GetCampaigns);
            this.Controls.Add(this.l_Cash);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.l_Orders);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.l_Promotions);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.l_Donations);
            this.Controls.Add(this.l_Campaigns);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label1);
            this.Name = "AdminProfile";
            this.Text = "AdminProfile";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Campaigns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Donations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label_Name;
        private Label label2;
        private Label label3;
        private Label l_Campaigns;
        private Label l_Donations;
        private Label label6;
        private Label l_Promotions;
        private Label label8;
        private Label l_Orders;
        private Label label10;
        private Label l_Cash;
        private Button btn_GetCampaigns;
        private Button btn_GetDonations;
        private Button btn_GetOrders;
        private DataGridView dg_Campaigns;
        private DataGridView dg_Donations;
        private DataGridView dg_Orders;
    }
}