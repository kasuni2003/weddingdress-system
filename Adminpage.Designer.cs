namespace Project1
{
    partial class Adminpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminpage));
            this.button1 = new System.Windows.Forms.Button();
            this.Manege_closet = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.recivedapp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(898, 735);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "View latereturns";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Manege_closet
            // 
            this.Manege_closet.Location = new System.Drawing.Point(898, 630);
            this.Manege_closet.Name = "Manege_closet";
            this.Manege_closet.Size = new System.Drawing.Size(169, 52);
            this.Manege_closet.TabIndex = 1;
            this.Manege_closet.Text = "Manege closet";
            this.Manege_closet.UseVisualStyleBackColor = true;
            this.Manege_closet.Click += new System.EventHandler(this.Manege_closet_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(898, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "Veiw customer feed back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(898, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 54);
            this.button4.TabIndex = 3;
            this.button4.Text = "Manage appointments";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(898, 164);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 52);
            this.button5.TabIndex = 4;
            this.button5.Text = "view Home page";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // recivedapp
            // 
            this.recivedapp.Location = new System.Drawing.Point(898, 510);
            this.recivedapp.Name = "recivedapp";
            this.recivedapp.Size = new System.Drawing.Size(169, 54);
            this.recivedapp.TabIndex = 5;
            this.recivedapp.Text = "Return Dress";
            this.recivedapp.UseVisualStyleBackColor = true;
            this.recivedapp.Click += new System.EventHandler(this.recivedapp_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1006, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 47);
            this.button2.TabIndex = 6;
            this.button2.Text = "sign out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 46);
            this.label2.TabIndex = 8;
            this.label2.Text = "Admin Dashboard";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(868, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(115, 47);
            this.exit.TabIndex = 9;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(70, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(797, 690);
            this.label1.TabIndex = 7;
            // 
            // Adminpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1133, 890);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.recivedapp);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Manege_closet);
            this.Controls.Add(this.button1);
            this.Name = "Adminpage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Adminpage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Manege_closet;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button recivedapp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exit;
    }
}