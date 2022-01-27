namespace PromoterClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_UserId = new System.Windows.Forms.TextBox();
            this.txt_Tweet = new System.Windows.Forms.TextBox();
            this.btn_ConnectToTwiter = new System.Windows.Forms.Button();
            this.dg_Tweets = new System.Windows.Forms.DataGridView();
            this.btn_Post = new System.Windows.Forms.Button();
            this.dg_Campaigns = new System.Windows.Forms.DataGridView();
            this.btn_GetCampaigns = new System.Windows.Forms.Button();
            this.btn_GetBalance = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Balance = new System.Windows.Forms.TextBox();
            this.dg_Products = new System.Windows.Forms.DataGridView();
            this.btn_GetDonations = new System.Windows.Forms.Button();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.txt_ProductId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Tweets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Campaigns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(29, 43);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(150, 31);
            this.txt_Email.TabIndex = 0;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(29, 123);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(150, 31);
            this.txt_Pass.TabIndex = 1;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(67, 199);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(112, 34);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "User id";
            // 
            // txt_UserId
            // 
            this.txt_UserId.Location = new System.Drawing.Point(29, 428);
            this.txt_UserId.Name = "txt_UserId";
            this.txt_UserId.Size = new System.Drawing.Size(150, 31);
            this.txt_UserId.TabIndex = 6;
            // 
            // txt_Tweet
            // 
            this.txt_Tweet.Location = new System.Drawing.Point(836, 55);
            this.txt_Tweet.Name = "txt_Tweet";
            this.txt_Tweet.Size = new System.Drawing.Size(245, 31);
            this.txt_Tweet.TabIndex = 7;
            this.txt_Tweet.TextChanged += new System.EventHandler(this.txt_twiterUser_TextChanged);
            // 
            // btn_ConnectToTwiter
            // 
            this.btn_ConnectToTwiter.Location = new System.Drawing.Point(1100, 123);
            this.btn_ConnectToTwiter.Name = "btn_ConnectToTwiter";
            this.btn_ConnectToTwiter.Size = new System.Drawing.Size(112, 34);
            this.btn_ConnectToTwiter.TabIndex = 8;
            this.btn_ConnectToTwiter.Text = "Get Tweets";
            this.btn_ConnectToTwiter.UseVisualStyleBackColor = true;
            this.btn_ConnectToTwiter.Click += new System.EventHandler(this.btn_ConnectToTwiter_Click);
            // 
            // dg_Tweets
            // 
            this.dg_Tweets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Tweets.Location = new System.Drawing.Point(836, 188);
            this.dg_Tweets.Name = "dg_Tweets";
            this.dg_Tweets.RowHeadersWidth = 62;
            this.dg_Tweets.RowTemplate.Height = 33;
            this.dg_Tweets.Size = new System.Drawing.Size(406, 310);
            this.dg_Tweets.TabIndex = 9;
            // 
            // btn_Post
            // 
            this.btn_Post.Location = new System.Drawing.Point(1100, 53);
            this.btn_Post.Name = "btn_Post";
            this.btn_Post.Size = new System.Drawing.Size(112, 34);
            this.btn_Post.TabIndex = 10;
            this.btn_Post.Text = "Post";
            this.btn_Post.UseVisualStyleBackColor = true;
            this.btn_Post.Click += new System.EventHandler(this.btn_Post_Click);
            // 
            // dg_Campaigns
            // 
            this.dg_Campaigns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Campaigns.Location = new System.Drawing.Point(214, 188);
            this.dg_Campaigns.Name = "dg_Campaigns";
            this.dg_Campaigns.RowHeadersWidth = 62;
            this.dg_Campaigns.RowTemplate.Height = 33;
            this.dg_Campaigns.Size = new System.Drawing.Size(275, 310);
            this.dg_Campaigns.TabIndex = 11;
            // 
            // btn_GetCampaigns
            // 
            this.btn_GetCampaigns.Location = new System.Drawing.Point(232, 135);
            this.btn_GetCampaigns.Name = "btn_GetCampaigns";
            this.btn_GetCampaigns.Size = new System.Drawing.Size(243, 34);
            this.btn_GetCampaigns.TabIndex = 12;
            this.btn_GetCampaigns.Text = "Get Campaigns";
            this.btn_GetCampaigns.UseVisualStyleBackColor = true;
            this.btn_GetCampaigns.Click += new System.EventHandler(this.btn_GetCampaigns_Click);
            // 
            // btn_GetBalance
            // 
            this.btn_GetBalance.Location = new System.Drawing.Point(477, 59);
            this.btn_GetBalance.Name = "btn_GetBalance";
            this.btn_GetBalance.Size = new System.Drawing.Size(112, 34);
            this.btn_GetBalance.TabIndex = 13;
            this.btn_GetBalance.Text = "Get Balance";
            this.btn_GetBalance.UseVisualStyleBackColor = true;
            this.btn_GetBalance.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Balance";
            // 
            // txt_Balance
            // 
            this.txt_Balance.Location = new System.Drawing.Point(277, 61);
            this.txt_Balance.Name = "txt_Balance";
            this.txt_Balance.Size = new System.Drawing.Size(150, 31);
            this.txt_Balance.TabIndex = 15;
            // 
            // dg_Products
            // 
            this.dg_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Products.Location = new System.Drawing.Point(495, 188);
            this.dg_Products.Name = "dg_Products";
            this.dg_Products.RowHeadersWidth = 62;
            this.dg_Products.RowTemplate.Height = 33;
            this.dg_Products.Size = new System.Drawing.Size(335, 298);
            this.dg_Products.TabIndex = 16;
            // 
            // btn_GetDonations
            // 
            this.btn_GetDonations.Location = new System.Drawing.Point(571, 135);
            this.btn_GetDonations.Name = "btn_GetDonations";
            this.btn_GetDonations.Size = new System.Drawing.Size(159, 34);
            this.btn_GetDonations.TabIndex = 17;
            this.btn_GetDonations.Text = "Get Products";
            this.btn_GetDonations.UseVisualStyleBackColor = true;
            this.btn_GetDonations.Click += new System.EventHandler(this.btn_GetDonations_Click);
            // 
            // btn_Buy
            // 
            this.btn_Buy.Location = new System.Drawing.Point(675, 61);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(112, 34);
            this.btn_Buy.TabIndex = 18;
            this.btn_Buy.Text = "Buy";
            this.btn_Buy.UseVisualStyleBackColor = true;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // txt_ProductId
            // 
            this.txt_ProductId.Location = new System.Drawing.Point(717, 12);
            this.txt_ProductId.Name = "txt_ProductId";
            this.txt_ProductId.Size = new System.Drawing.Size(70, 31);
            this.txt_ProductId.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(668, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 487);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ProductId);
            this.Controls.Add(this.btn_Buy);
            this.Controls.Add(this.btn_GetDonations);
            this.Controls.Add(this.dg_Products);
            this.Controls.Add(this.txt_Balance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_GetBalance);
            this.Controls.Add(this.btn_GetCampaigns);
            this.Controls.Add(this.dg_Campaigns);
            this.Controls.Add(this.btn_Post);
            this.Controls.Add(this.dg_Tweets);
            this.Controls.Add(this.btn_ConnectToTwiter);
            this.Controls.Add(this.txt_Tweet);
            this.Controls.Add(this.txt_UserId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_Email);
            this.Name = "Form1";
            this.Text = "Promoter";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Tweets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Campaigns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_Email;
        private TextBox txt_Pass;
        private Button btn_Login;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_UserId;
        private TextBox txt_Tweet;
        private Button btn_ConnectToTwiter;
        private DataGridView dg_Tweets;
        private Button btn_Post;
        private DataGridView dg_Campaigns;
        private Button btn_GetCampaigns;
        private Button btn_GetBalance;
        private Label label4;
        private TextBox txt_Balance;
        private DataGridView dg_Products;
        private Button btn_GetDonations;
        private Button btn_Buy;
        private TextBox txt_ProductId;
        private Label label5;
    }
}