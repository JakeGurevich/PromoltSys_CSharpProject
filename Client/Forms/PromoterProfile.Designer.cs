namespace Client.Forms
{
    partial class PromoterProfile
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.btn_GetDonations = new System.Windows.Forms.Button();
            this.dg_Products = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_GetBalance = new System.Windows.Forms.Button();
            this.btn_GetCampaigns = new System.Windows.Forms.Button();
            this.dg_Campaigns = new System.Windows.Forms.DataGridView();
            this.btn_Post = new System.Windows.Forms.Button();
            this.dg_Tweets = new System.Windows.Forms.DataGridView();
            this.btn_ConnectToTwiter = new System.Windows.Forms.Button();
            this.txt_Tweet = new System.Windows.Forms.TextBox();
            this.label_Balance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CampaignName = new System.Windows.Forms.TextBox();
            this.btn_ConnectToTwitter = new System.Windows.Forms.Button();
            this.txt_PoductId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Campaigns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Tweets)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Product name";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(469, 32);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(70, 31);
            this.txt_ProductName.TabIndex = 33;
            // 
            // btn_Buy
            // 
            this.btn_Buy.Location = new System.Drawing.Point(527, 69);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(112, 34);
            this.btn_Buy.TabIndex = 32;
            this.btn_Buy.Text = "Buy";
            this.btn_Buy.UseVisualStyleBackColor = true;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click_1);
            // 
            // btn_GetDonations
            // 
            this.btn_GetDonations.Location = new System.Drawing.Point(469, 138);
            this.btn_GetDonations.Name = "btn_GetDonations";
            this.btn_GetDonations.Size = new System.Drawing.Size(159, 34);
            this.btn_GetDonations.TabIndex = 31;
            this.btn_GetDonations.Text = "See Products";
            this.btn_GetDonations.UseVisualStyleBackColor = true;
            this.btn_GetDonations.Click += new System.EventHandler(this.btn_GetDonations_Click_1);
            // 
            // dg_Products
            // 
            this.dg_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Products.Location = new System.Drawing.Point(376, 187);
            this.dg_Products.Name = "dg_Products";
            this.dg_Products.RowHeadersWidth = 62;
            this.dg_Products.RowTemplate.Height = 33;
            this.dg_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Products.Size = new System.Drawing.Size(335, 319);
            this.dg_Products.TabIndex = 30;
            this.dg_Products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Products_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Balance";
            // 
            // btn_GetBalance
            // 
            this.btn_GetBalance.Location = new System.Drawing.Point(222, 38);
            this.btn_GetBalance.Name = "btn_GetBalance";
            this.btn_GetBalance.Size = new System.Drawing.Size(112, 34);
            this.btn_GetBalance.TabIndex = 27;
            this.btn_GetBalance.Text = "Get Balance";
            this.btn_GetBalance.UseVisualStyleBackColor = true;
            this.btn_GetBalance.Click += new System.EventHandler(this.btn_GetBalance_Click);
            // 
            // btn_GetCampaigns
            // 
            this.btn_GetCampaigns.Location = new System.Drawing.Point(41, 138);
            this.btn_GetCampaigns.Name = "btn_GetCampaigns";
            this.btn_GetCampaigns.Size = new System.Drawing.Size(243, 34);
            this.btn_GetCampaigns.TabIndex = 26;
            this.btn_GetCampaigns.Text = "See Campaigns";
            this.btn_GetCampaigns.UseVisualStyleBackColor = true;
            this.btn_GetCampaigns.Click += new System.EventHandler(this.btn_GetCampaigns_Click_1);
            // 
            // dg_Campaigns
            // 
            this.dg_Campaigns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Campaigns.Location = new System.Drawing.Point(5, 187);
            this.dg_Campaigns.Name = "dg_Campaigns";
            this.dg_Campaigns.RowHeadersWidth = 62;
            this.dg_Campaigns.RowTemplate.Height = 33;
            this.dg_Campaigns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Campaigns.Size = new System.Drawing.Size(329, 319);
            this.dg_Campaigns.TabIndex = 25;
            this.dg_Campaigns.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Campaigns_CellContentClick);
            // 
            // btn_Post
            // 
            this.btn_Post.Location = new System.Drawing.Point(1071, 66);
            this.btn_Post.Name = "btn_Post";
            this.btn_Post.Size = new System.Drawing.Size(112, 34);
            this.btn_Post.TabIndex = 24;
            this.btn_Post.Text = "Promote";
            this.btn_Post.UseVisualStyleBackColor = true;
            this.btn_Post.Click += new System.EventHandler(this.btn_Post_Click_1);
            // 
            // dg_Tweets
            // 
            this.dg_Tweets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Tweets.Location = new System.Drawing.Point(792, 187);
            this.dg_Tweets.Name = "dg_Tweets";
            this.dg_Tweets.RowHeadersWidth = 62;
            this.dg_Tweets.RowTemplate.Height = 33;
            this.dg_Tweets.Size = new System.Drawing.Size(406, 310);
            this.dg_Tweets.TabIndex = 23;
            // 
            // btn_ConnectToTwiter
            // 
            this.btn_ConnectToTwiter.Location = new System.Drawing.Point(939, 138);
            this.btn_ConnectToTwiter.Name = "btn_ConnectToTwiter";
            this.btn_ConnectToTwiter.Size = new System.Drawing.Size(112, 34);
            this.btn_ConnectToTwiter.TabIndex = 22;
            this.btn_ConnectToTwiter.Text = "Get Tweets";
            this.btn_ConnectToTwiter.UseVisualStyleBackColor = true;
            this.btn_ConnectToTwiter.Click += new System.EventHandler(this.btn_ConnectToTwiter_Click_1);
            // 
            // txt_Tweet
            // 
            this.txt_Tweet.Location = new System.Drawing.Point(766, 69);
            this.txt_Tweet.Name = "txt_Tweet";
            this.txt_Tweet.Size = new System.Drawing.Size(245, 31);
            this.txt_Tweet.TabIndex = 21;
            this.txt_Tweet.TextChanged += new System.EventHandler(this.txt_Tweet_TextChanged);
            // 
            // label_Balance
            // 
            this.label_Balance.AutoSize = true;
            this.label_Balance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Balance.Location = new System.Drawing.Point(90, 40);
            this.label_Balance.Name = "label_Balance";
            this.label_Balance.Size = new System.Drawing.Size(22, 25);
            this.label_Balance.TabIndex = 35;
            this.label_Balance.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Price";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(613, 32);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(70, 31);
            this.txt_Price.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Hi ,";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_Name.Location = new System.Drawing.Point(61, 9);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(0, 25);
            this.label_Name.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(766, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Choosed Campaign";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_CampaignName
            // 
            this.txt_CampaignName.Location = new System.Drawing.Point(981, 12);
            this.txt_CampaignName.Name = "txt_CampaignName";
            this.txt_CampaignName.Size = new System.Drawing.Size(144, 31);
            this.txt_CampaignName.TabIndex = 40;
            // 
            // btn_ConnectToTwitter
            // 
            this.btn_ConnectToTwitter.Location = new System.Drawing.Point(803, 138);
            this.btn_ConnectToTwitter.Name = "btn_ConnectToTwitter";
            this.btn_ConnectToTwitter.Size = new System.Drawing.Size(112, 34);
            this.btn_ConnectToTwitter.TabIndex = 42;
            this.btn_ConnectToTwitter.Text = "Connect";
            this.btn_ConnectToTwitter.UseVisualStyleBackColor = true;
            this.btn_ConnectToTwitter.Click += new System.EventHandler(this.btn_ConnectToTwitter_Click);
            // 
            // txt_PoductId
            // 
            this.txt_PoductId.Location = new System.Drawing.Point(571, 32);
            this.txt_PoductId.Name = "txt_PoductId";
            this.txt_PoductId.Size = new System.Drawing.Size(8, 31);
            this.txt_PoductId.TabIndex = 43;
            // 
            // PromoterProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 536);
            this.Controls.Add(this.txt_PoductId);
            this.Controls.Add(this.btn_ConnectToTwitter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CampaignName);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.label_Balance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.btn_Buy);
            this.Controls.Add(this.btn_GetDonations);
            this.Controls.Add(this.dg_Products);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_GetBalance);
            this.Controls.Add(this.btn_GetCampaigns);
            this.Controls.Add(this.dg_Campaigns);
            this.Controls.Add(this.btn_Post);
            this.Controls.Add(this.dg_Tweets);
            this.Controls.Add(this.btn_ConnectToTwiter);
            this.Controls.Add(this.txt_Tweet);
            this.Name = "PromoterProfile";
            this.Text = "Promoter Profile";
            this.Load += new System.EventHandler(this.PromoterProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Campaigns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Tweets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private TextBox txt_ProductName;
        private Button btn_Buy;
        private Button btn_GetDonations;
        private DataGridView dg_Products;
        private Label label4;
        private Button btn_GetBalance;
        private Button btn_GetCampaigns;
        private DataGridView dg_Campaigns;
        private Button btn_Post;
        private DataGridView dg_Tweets;
        private Button btn_ConnectToTwiter;
        private TextBox txt_Tweet;
        private Label label_Balance;
        private Label label2;
        private TextBox txt_Price;
        private Label label3;
        private Label label_Name;
        private Label label1;
        private TextBox txt_CampaignName;
        private Button btn_ConnectToTwitter;
        private TextBox txt_PoductId;
    }
}