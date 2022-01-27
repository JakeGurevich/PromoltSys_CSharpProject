namespace Client
{
    partial class Home
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
            this.btn_CreateUser = new System.Windows.Forms.Button();
            this.btn_CreateSponsor = new System.Windows.Forms.Button();
            this.btn_CreatePromoter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CreateUser
            // 
            this.btn_CreateUser.Location = new System.Drawing.Point(673, 181);
            this.btn_CreateUser.Name = "btn_CreateUser";
            this.btn_CreateUser.Size = new System.Drawing.Size(112, 34);
            this.btn_CreateUser.TabIndex = 0;
            this.btn_CreateUser.Text = "User";
            this.btn_CreateUser.UseVisualStyleBackColor = true;
            this.btn_CreateUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_CreateSponsor
            // 
            this.btn_CreateSponsor.Location = new System.Drawing.Point(844, 181);
            this.btn_CreateSponsor.Name = "btn_CreateSponsor";
            this.btn_CreateSponsor.Size = new System.Drawing.Size(112, 34);
            this.btn_CreateSponsor.TabIndex = 1;
            this.btn_CreateSponsor.Text = "Sponsor";
            this.btn_CreateSponsor.UseVisualStyleBackColor = true;
            this.btn_CreateSponsor.Click += new System.EventHandler(this.btn_CreateSponsor_Click);
            // 
            // btn_CreatePromoter
            // 
            this.btn_CreatePromoter.Location = new System.Drawing.Point(1024, 181);
            this.btn_CreatePromoter.Name = "btn_CreatePromoter";
            this.btn_CreatePromoter.Size = new System.Drawing.Size(112, 34);
            this.btn_CreatePromoter.TabIndex = 2;
            this.btn_CreatePromoter.Text = "Promoter";
            this.btn_CreatePromoter.UseVisualStyleBackColor = true;
            this.btn_CreatePromoter.Click += new System.EventHandler(this.btn_CreatePromoter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(692, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "To create an account please choose";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(25, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "If you have alredy an account please Sign In";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(170, 153);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(150, 31);
            this.txt_email.TabIndex = 14;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(170, 235);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(150, 31);
            this.txt_Pass.TabIndex = 13;
            this.txt_Pass.TextChanged += new System.EventHandler(this.txt_Pass_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(208, 334);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(112, 34);
            this.btn_Login.TabIndex = 11;
            this.btn_Login.Text = "Sign In";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 493);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CreatePromoter);
            this.Controls.Add(this.btn_CreateSponsor);
            this.Controls.Add(this.btn_CreateUser);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_CreateUser;
        private Button btn_CreateSponsor;
        private Button btn_CreatePromoter;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txt_email;
        private TextBox txt_Pass;
        private Label label3;
        private Button btn_Login;
    }
}