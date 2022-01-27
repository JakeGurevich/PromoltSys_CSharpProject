namespace Client
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_First = new System.Windows.Forms.TextBox();
            this.txt_Last = new System.Windows.Forms.TextBox();
            this.btn_GetData = new System.Windows.Forms.Button();
            this.btn_CreateUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Url = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Hashtag = new System.Windows.Forms.TextBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_OwnerId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dg_Campains = new System.Windows.Forms.DataGridView();
            this.btn_GetCampaigns = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Campains)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(227, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(384, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_First
            // 
            this.txt_First.Location = new System.Drawing.Point(54, 31);
            this.txt_First.Name = "txt_First";
            this.txt_First.Size = new System.Drawing.Size(150, 31);
            this.txt_First.TabIndex = 1;
            this.txt_First.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_Last
            // 
            this.txt_Last.Location = new System.Drawing.Point(54, 105);
            this.txt_Last.Name = "txt_Last";
            this.txt_Last.Size = new System.Drawing.Size(150, 31);
            this.txt_Last.TabIndex = 2;
            this.txt_Last.TextChanged += new System.EventHandler(this.txt_Last_TextChanged);
            // 
            // btn_GetData
            // 
            this.btn_GetData.Location = new System.Drawing.Point(499, 102);
            this.btn_GetData.Name = "btn_GetData";
            this.btn_GetData.Size = new System.Drawing.Size(112, 34);
            this.btn_GetData.TabIndex = 3;
            this.btn_GetData.Text = "Get Users";
            this.btn_GetData.UseVisualStyleBackColor = true;
            this.btn_GetData.Click += new System.EventHandler(this.btn_GetData_ClickAsync);
            // 
            // btn_CreateUser
            // 
            this.btn_CreateUser.Location = new System.Drawing.Point(92, 349);
            this.btn_CreateUser.Name = "btn_CreateUser";
            this.btn_CreateUser.Size = new System.Drawing.Size(112, 34);
            this.btn_CreateUser.TabIndex = 4;
            this.btn_CreateUser.Text = "Create User";
            this.btn_CreateUser.UseVisualStyleBackColor = true;
            this.btn_CreateUser.Click += new System.EventHandler(this.btn_CreateUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(54, 178);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(150, 31);
            this.txt_Pass.TabIndex = 8;
            this.txt_Pass.TextChanged += new System.EventHandler(this.txt_Pass_TextChanged);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(54, 250);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(150, 31);
            this.txt_email.TabIndex = 9;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_Url
            // 
            this.txt_Url.Location = new System.Drawing.Point(656, 178);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(150, 31);
            this.txt_Url.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Url";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(656, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hashtag";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(656, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Title";
            // 
            // txt_Hashtag
            // 
            this.txt_Hashtag.Location = new System.Drawing.Point(656, 105);
            this.txt_Hashtag.Name = "txt_Hashtag";
            this.txt_Hashtag.Size = new System.Drawing.Size(150, 31);
            this.txt_Hashtag.TabIndex = 12;
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(656, 31);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(150, 31);
            this.txt_Title.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(656, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Owner";
            // 
            // txt_OwnerId
            // 
            this.txt_OwnerId.Location = new System.Drawing.Point(656, 250);
            this.txt_OwnerId.Name = "txt_OwnerId";
            this.txt_OwnerId.Size = new System.Drawing.Size(150, 31);
            this.txt_OwnerId.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Create Camp\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dg_Campains
            // 
            this.dg_Campains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Campains.Location = new System.Drawing.Point(823, 200);
            this.dg_Campains.Name = "dg_Campains";
            this.dg_Campains.RowHeadersWidth = 62;
            this.dg_Campains.RowTemplate.Height = 33;
            this.dg_Campains.Size = new System.Drawing.Size(384, 301);
            this.dg_Campains.TabIndex = 20;
            // 
            // btn_GetCampaigns
            // 
            this.btn_GetCampaigns.Location = new System.Drawing.Point(1077, 102);
            this.btn_GetCampaigns.Name = "btn_GetCampaigns";
            this.btn_GetCampaigns.Size = new System.Drawing.Size(112, 34);
            this.btn_GetCampaigns.TabIndex = 21;
            this.btn_GetCampaigns.Text = "Get Camp";
            this.btn_GetCampaigns.UseVisualStyleBackColor = true;
            this.btn_GetCampaigns.Click += new System.EventHandler(this.btn_GetCampaigns_ClickAsync);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 500);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CreateUser);
            this.Controls.Add(this.btn_GetData);
            this.Controls.Add(this.txt_Last);
            this.Controls.Add(this.txt_First);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Campains)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txt_First;
        private TextBox txt_Last;
        private Button btn_GetData;
        private Button btn_CreateUser;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_Pass;
        private TextBox txt_email;
        private Label label4;
        private TextBox txt_Url;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_Hashtag;
        private TextBox txt_Title;
        private Label label8;
        private TextBox txt_OwnerId;
        private Button button1;
        private DataGridView dg_Campains;
        private Button btn_GetCampaigns;
    }
}