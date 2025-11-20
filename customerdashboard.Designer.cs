namespace Project1
{
    partial class customerdashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerdashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.feedback_btn = new System.Windows.Forms.Button();
            this.Browse_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "welcome for your ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 59);
            this.label2.TabIndex = 1;
            this.label2.Text = "dream dress";
            // 
            // feedback_btn
            // 
            this.feedback_btn.BackColor = System.Drawing.Color.Transparent;
            this.feedback_btn.Location = new System.Drawing.Point(860, 478);
            this.feedback_btn.Name = "feedback_btn";
            this.feedback_btn.Size = new System.Drawing.Size(250, 58);
            this.feedback_btn.TabIndex = 4;
            this.feedback_btn.Text = "feedback";
            this.feedback_btn.UseVisualStyleBackColor = false;
            this.feedback_btn.Click += new System.EventHandler(this.feedback_btn_Click);
            // 
            // Browse_btn
            // 
            this.Browse_btn.BackColor = System.Drawing.Color.Transparent;
            this.Browse_btn.Location = new System.Drawing.Point(860, 369);
            this.Browse_btn.Name = "Browse_btn";
            this.Browse_btn.Size = new System.Drawing.Size(250, 58);
            this.Browse_btn.TabIndex = 7;
            this.Browse_btn.Text = "Browse dresses";
            this.Browse_btn.UseVisualStyleBackColor = false;
            this.Browse_btn.Click += new System.EventHandler(this.Browse_btn_Click);
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(58, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(742, 802);
            this.label3.TabIndex = 8;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(989, 27);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(121, 45);
            this.exit.TabIndex = 9;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(851, 27);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(121, 45);
            this.back.TabIndex = 10;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // customerdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 787);
            this.Controls.Add(this.back);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Browse_btn);
            this.Controls.Add(this.feedback_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "customerdashboard";
            this.Text = "customerdashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button feedback_btn;
        private System.Windows.Forms.Button Browse_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button back;
    }
}