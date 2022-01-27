namespace Client.Forms
{
    partial class UserProfile
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
            this.btn_GetCampaigns = new System.Windows.Forms.Button();
            this.dg_Campains = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_OwnerId = new System.Windows.Forms.TextBox();
            this.txt_Url = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Hashtag = new System.Windows.Forms.TextBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Campains)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_GetCampaigns
            // 
            this.btn_GetCampaigns.Location = new System.Drawing.Point(635, 50);
            this.btn_GetCampaigns.Name = "btn_GetCampaigns";
            this.btn_GetCampaigns.Size = new System.Drawing.Size(112, 34);
            this.btn_GetCampaigns.TabIndex = 32;
            this.btn_GetCampaigns.Text = "Get Camp";
            this.btn_GetCampaigns.UseVisualStyleBackColor = true;
            this.btn_GetCampaigns.Click += new System.EventHandler(this.btn_GetCampaigns_Click);
            // 
            // dg_Campains
            // 
            this.dg_Campains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Campains.Location = new System.Drawing.Point(389, 145);
            this.dg_Campains.Name = "dg_Campains";
            this.dg_Campains.RowHeadersWidth = 62;
            this.dg_Campains.RowTemplate.Height = 33;
            this.dg_Campains.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Campains.Size = new System.Drawing.Size(412, 302);
            this.dg_Campains.TabIndex = 31;
            this.dg_Campains.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Campains_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 32);
            this.button1.TabIndex = 30;
            this.button1.Text = "Create Camp\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Owner";
            // 
            // txt_OwnerId
            // 
            this.txt_OwnerId.Location = new System.Drawing.Point(55, 278);
            this.txt_OwnerId.Name = "txt_OwnerId";
            this.txt_OwnerId.Size = new System.Drawing.Size(150, 31);
            this.txt_OwnerId.TabIndex = 28;
            // 
            // txt_Url
            // 
            this.txt_Url.Location = new System.Drawing.Point(55, 206);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(150, 31);
            this.txt_Url.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Url";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Hashtag";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, -24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Title";
            // 
            // txt_Hashtag
            // 
            this.txt_Hashtag.Location = new System.Drawing.Point(55, 133);
            this.txt_Hashtag.Name = "txt_Hashtag";
            this.txt_Hashtag.Size = new System.Drawing.Size(150, 31);
            this.txt_Hashtag.TabIndex = 23;
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(55, 59);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(150, 31);
            this.txt_Title.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Title";
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GetCampaigns);
            this.Controls.Add(this.dg_Campains);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_OwnerId);
            this.Controls.Add(this.txt_Url);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Hashtag);
            this.Controls.Add(this.txt_Title);
            this.Name = "UserProfile";
            this.Text = "UserProfile";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Campains)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_GetCampaigns;
        private DataGridView dg_Campains;
        private Button button1;
        private Label label8;
        private TextBox txt_OwnerId;
        private TextBox txt_Url;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_Hashtag;
        private TextBox txt_Title;
        private Label label1;
    }
}