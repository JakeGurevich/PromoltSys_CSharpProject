namespace Client.Forms
{
    partial class SponsorProfile
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
            this.label_Name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Balance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_GetOrders = new System.Windows.Forms.Button();
            this.btn_GetDonationss = new System.Windows.Forms.Button();
            this.dg_Campaigns = new System.Windows.Forms.DataGridView();
            this.dg_Orders = new System.Windows.Forms.DataGridView();
            this.txt_OrderProductName = new System.Windows.Forms.TextBox();
            this.txt_OrderPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Qty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_DonateProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Campaigns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Orders)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_Name.Location = new System.Drawing.Point(83, 14);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(0, 25);
            this.label_Name.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Hi ,";
            // 
            // label_Balance
            // 
            this.label_Balance.AutoSize = true;
            this.label_Balance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Balance.Location = new System.Drawing.Point(112, 45);
            this.label_Balance.Name = "label_Balance";
            this.label_Balance.Size = new System.Drawing.Size(0, 25);
            this.label_Balance.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 43;
            // 
            // btn_GetOrders
            // 
            this.btn_GetOrders.Location = new System.Drawing.Point(758, 137);
            this.btn_GetOrders.Name = "btn_GetOrders";
            this.btn_GetOrders.Size = new System.Drawing.Size(112, 34);
            this.btn_GetOrders.TabIndex = 42;
            this.btn_GetOrders.Text = "See Orders";
            this.btn_GetOrders.UseVisualStyleBackColor = true;
            this.btn_GetOrders.Click += new System.EventHandler(this.btn_GetOrders_Click);
            // 
            // btn_GetDonationss
            // 
            this.btn_GetDonationss.Location = new System.Drawing.Point(401, 137);
            this.btn_GetDonationss.Name = "btn_GetDonationss";
            this.btn_GetDonationss.Size = new System.Drawing.Size(196, 34);
            this.btn_GetDonationss.TabIndex = 41;
            this.btn_GetDonationss.Text = "See Donations";
            this.btn_GetDonationss.UseVisualStyleBackColor = true;
            this.btn_GetDonationss.Click += new System.EventHandler(this.btn_GetDonationss_Click);
            // 
            // dg_Campaigns
            // 
            this.dg_Campaigns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Campaigns.Location = new System.Drawing.Point(385, 177);
            this.dg_Campaigns.Name = "dg_Campaigns";
            this.dg_Campaigns.RowHeadersWidth = 62;
            this.dg_Campaigns.RowTemplate.Height = 33;
            this.dg_Campaigns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Campaigns.Size = new System.Drawing.Size(329, 289);
            this.dg_Campaigns.TabIndex = 40;
            // 
            // dg_Orders
            // 
            this.dg_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Orders.Location = new System.Drawing.Point(749, 177);
            this.dg_Orders.Name = "dg_Orders";
            this.dg_Orders.RowHeadersWidth = 62;
            this.dg_Orders.RowTemplate.Height = 33;
            this.dg_Orders.Size = new System.Drawing.Size(360, 279);
            this.dg_Orders.TabIndex = 47;
            // 
            // txt_OrderProductName
            // 
            this.txt_OrderProductName.Location = new System.Drawing.Point(789, 28);
            this.txt_OrderProductName.Name = "txt_OrderProductName";
            this.txt_OrderProductName.Size = new System.Drawing.Size(150, 31);
            this.txt_OrderProductName.TabIndex = 48;
            // 
            // txt_OrderPrice
            // 
            this.txt_OrderPrice.Location = new System.Drawing.Point(988, 28);
            this.txt_OrderPrice.Name = "txt_OrderPrice";
            this.txt_OrderPrice.Size = new System.Drawing.Size(150, 31);
            this.txt_OrderPrice.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(865, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 34);
            this.button1.TabIndex = 50;
            this.button1.Text = "Proceed Order";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Product Name";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(37, 120);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(150, 31);
            this.txt_Name.TabIndex = 52;
            // 
            // txt_Qty
            // 
            this.txt_Qty.Location = new System.Drawing.Point(39, 193);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(150, 31);
            this.txt_Qty.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "Qty";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(35, 266);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(150, 31);
            this.txt_Price.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 55;
            this.label5.Text = "Price";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_DonateProduct
            // 
            this.btn_DonateProduct.Location = new System.Drawing.Point(83, 352);
            this.btn_DonateProduct.Name = "btn_DonateProduct";
            this.btn_DonateProduct.Size = new System.Drawing.Size(112, 34);
            this.btn_DonateProduct.TabIndex = 57;
            this.btn_DonateProduct.Text = "Donate Product";
            this.btn_DonateProduct.UseVisualStyleBackColor = true;
            this.btn_DonateProduct.Click += new System.EventHandler(this.btn_DonateProduct_Click);
            // 
            // SponsorProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 450);
            this.Controls.Add(this.btn_DonateProduct);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Qty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_OrderPrice);
            this.Controls.Add(this.txt_OrderProductName);
            this.Controls.Add(this.dg_Orders);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Balance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_GetOrders);
            this.Controls.Add(this.btn_GetDonationss);
            this.Controls.Add(this.dg_Campaigns);
            this.Name = "SponsorProfile";
            this.Text = "SponsorProfile";
            this.Load += new System.EventHandler(this.SponsorProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Campaigns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Name;
        private Label label3;
        private Label label_Balance;
        private Label label4;
        private Button btn_GetOrders;
        private Button btn_GetDonationss;
        private DataGridView dg_Campaigns;
        private DataGridView dg_Orders;
        private TextBox txt_OrderProductName;
        private TextBox txt_OrderPrice;
        private Button button1;
        private Label label1;
        private TextBox txt_Name;
        private TextBox txt_Qty;
        private Label label2;
        private TextBox txt_Price;
        private Label label5;
        private Button btn_DonateProduct;
    }
}