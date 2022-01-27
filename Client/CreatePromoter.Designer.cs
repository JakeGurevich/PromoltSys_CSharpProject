namespace Client
{
    partial class CreatePromoter
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
            this.btn_CreatePromoter = new System.Windows.Forms.Button();
            this.txt_Last = new System.Windows.Forms.TextBox();
            this.txt_First = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TweeterUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(74, 298);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(150, 31);
            this.txt_email.TabIndex = 27;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(74, 226);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(150, 31);
            this.txt_Pass.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "First Name";
            // 
            // btn_CreatePromoter
            // 
            this.btn_CreatePromoter.Location = new System.Drawing.Point(363, 381);
            this.btn_CreatePromoter.Name = "btn_CreatePromoter";
            this.btn_CreatePromoter.Size = new System.Drawing.Size(112, 34);
            this.btn_CreatePromoter.TabIndex = 22;
            this.btn_CreatePromoter.Text = "Create User";
            this.btn_CreatePromoter.UseVisualStyleBackColor = true;
            this.btn_CreatePromoter.Click += new System.EventHandler(this.btn_CreatePromoter_Click);
            // 
            // txt_Last
            // 
            this.txt_Last.Location = new System.Drawing.Point(74, 164);
            this.txt_Last.Name = "txt_Last";
            this.txt_Last.Size = new System.Drawing.Size(150, 31);
            this.txt_Last.TabIndex = 21;
            // 
            // txt_First
            // 
            this.txt_First.Location = new System.Drawing.Point(74, 79);
            this.txt_First.Name = "txt_First";
            this.txt_First.Size = new System.Drawing.Size(150, 31);
            this.txt_First.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tweeter User Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_TweeterUserName
            // 
            this.txt_TweeterUserName.Location = new System.Drawing.Point(470, 148);
            this.txt_TweeterUserName.Name = "txt_TweeterUserName";
            this.txt_TweeterUserName.Size = new System.Drawing.Size(150, 31);
            this.txt_TweeterUserName.TabIndex = 29;
            this.txt_TweeterUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(491, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "If you want to be promoter you shoud have tweeter account";
            // 
            // CreatePromoter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TweeterUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CreatePromoter);
            this.Controls.Add(this.txt_Last);
            this.Controls.Add(this.txt_First);
            this.Name = "CreatePromoter";
            this.Text = "CreatePromoter";
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
        private Button btn_CreatePromoter;
        private TextBox txt_Last;
        private TextBox txt_First;
        private Label label5;
        private TextBox txt_TweeterUserName;
        private Label label6;
    }
}