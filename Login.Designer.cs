namespace Project1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.loginEmail = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "welcome to Login ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.login_btn);
            this.groupBox1.Controls.Add(this.loginPassword);
            this.groupBox1.Controls.Add(this.loginEmail);
            this.groupBox1.Location = new System.Drawing.Point(513, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 349);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(248, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(57, 256);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(91, 37);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // loginPassword
            // 
            this.loginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginPassword.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPassword.Location = new System.Drawing.Point(140, 126);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.PasswordChar = '*';
            this.loginPassword.Size = new System.Drawing.Size(228, 28);
            this.loginPassword.TabIndex = 1;
            this.loginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginEmail
            // 
            this.loginEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginEmail.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginEmail.Location = new System.Drawing.Point(140, 48);
            this.loginEmail.Name = "loginEmail";
            this.loginEmail.Size = new System.Drawing.Size(228, 28);
            this.loginEmail.TabIndex = 0;
            this.loginEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1126, 781);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.TextBox loginEmail;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}