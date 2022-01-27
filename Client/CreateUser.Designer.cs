namespace Client
{
    partial class CreateUser
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CreateUser = new System.Windows.Forms.Button();
            this.txt_Last = new System.Windows.Forms.TextBox();
            this.txt_First = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(188, 271);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(150, 31);
            this.txt_email.TabIndex = 18;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(188, 199);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(150, 31);
            this.txt_Pass.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "First Name";
            // 
            // btn_CreateUser
            // 
            this.btn_CreateUser.Location = new System.Drawing.Point(226, 370);
            this.btn_CreateUser.Name = "btn_CreateUser";
            this.btn_CreateUser.Size = new System.Drawing.Size(112, 34);
            this.btn_CreateUser.TabIndex = 13;
            this.btn_CreateUser.Text = "Create User";
            this.btn_CreateUser.UseVisualStyleBackColor = true;
            this.btn_CreateUser.Click += new System.EventHandler(this.btn_CreateUser_Click);
            // 
            // txt_Last
            // 
            this.txt_Last.Location = new System.Drawing.Point(188, 126);
            this.txt_Last.Name = "txt_Last";
            this.txt_Last.Size = new System.Drawing.Size(150, 31);
            this.txt_Last.TabIndex = 12;
            // 
            // txt_First
            // 
            this.txt_First.Location = new System.Drawing.Point(188, 52);
            this.txt_First.Name = "txt_First";
            this.txt_First.Size = new System.Drawing.Size(150, 31);
            this.txt_First.TabIndex = 11;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CreateUser);
            this.Controls.Add(this.txt_Last);
            this.Controls.Add(this.txt_First);
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private TextBox txt_email;
        private TextBox txt_Pass;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_CreateUser;
        private TextBox txt_Last;
        private TextBox txt_First;
    }
}