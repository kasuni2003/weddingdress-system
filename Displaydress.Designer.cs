namespace Project1
{
    partial class Displaydress
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadDresses = new System.Windows.Forms.Button();
            this.panelDresses = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Dresses";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Load dress";
            // 
            // btnLoadDresses
            // 
            this.btnLoadDresses.Location = new System.Drawing.Point(192, 161);
            this.btnLoadDresses.Name = "btnLoadDresses";
            this.btnLoadDresses.Size = new System.Drawing.Size(109, 27);
            this.btnLoadDresses.TabIndex = 2;
            this.btnLoadDresses.Text = "Load Dresses";
            this.btnLoadDresses.UseVisualStyleBackColor = true;
            this.btnLoadDresses.Click += new System.EventHandler(this.btnLoadDresses_Click);
            // 
            // panelDresses
            // 
            this.panelDresses.AutoScroll = true;
            this.panelDresses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDresses.Location = new System.Drawing.Point(52, 232);
            this.panelDresses.Name = "panelDresses";
            this.panelDresses.Size = new System.Drawing.Size(1500, 795);
            this.panelDresses.TabIndex = 3;
            this.panelDresses.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDresses_Paint);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(1634, 31);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(94, 38);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(1746, 31);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(94, 38);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Displaydress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1866, 1055);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.back);
            this.Controls.Add(this.panelDresses);
            this.Controls.Add(this.btnLoadDresses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Displaydress";
            this.Text = "Displaydress";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Displaydress_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoadDresses;
        private System.Windows.Forms.Panel panelDresses;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button exit;
    }
}