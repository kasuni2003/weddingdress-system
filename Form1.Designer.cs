namespace Project1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.Register_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(27, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 59);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wedding ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(199, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 100);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dresses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(412, 75);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rental system";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Linen;
            this.login_btn.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(845, 164);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(202, 56);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // Register_btn
            // 
            this.Register_btn.BackColor = System.Drawing.Color.Linen;
            this.Register_btn.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_btn.Location = new System.Drawing.Point(845, 301);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(202, 52);
            this.Register_btn.TabIndex = 5;
            this.Register_btn.Text = "Register";
            this.Register_btn.UseVisualStyleBackColor = false;
            this.Register_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Linen;
            this.button3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(845, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 52);
            this.button3.TabIndex = 6;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Linen;
            this.exit.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(980, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(156, 56);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 713);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Register_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button Register_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button exit;
    }
}

