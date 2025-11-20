namespace Project1
{
    partial class Browsepage
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
            this.search_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.appointmentStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.resultpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Back = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.appointmentEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(269, 160);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(96, 39);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(302, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Browse your";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(537, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dream Dress";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // appointmentStartDatePicker
            // 
            this.appointmentStartDatePicker.Location = new System.Drawing.Point(869, 138);
            this.appointmentStartDatePicker.Name = "appointmentStartDatePicker";
            this.appointmentStartDatePicker.Size = new System.Drawing.Size(200, 22);
            this.appointmentStartDatePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(726, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "appointmentStartDate";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bridal Frocks",
            "Bridal Sarees",
            "Bridesmaid dresses",
            "normal wedding dress"});
            this.comboBox1.Location = new System.Drawing.Point(83, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // resultpanel
            // 
            this.resultpanel.AutoScroll = true;
            this.resultpanel.Location = new System.Drawing.Point(83, 267);
            this.resultpanel.Name = "resultpanel";
            this.resultpanel.Size = new System.Drawing.Size(1027, 502);
            this.resultpanel.TabIndex = 6;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(830, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(130, 44);
            this.Back.TabIndex = 7;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(990, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(130, 44);
            this.exit.TabIndex = 8;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(801, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "To";
            // 
            // appointmentEndDatePicker
            // 
            this.appointmentEndDatePicker.Location = new System.Drawing.Point(869, 183);
            this.appointmentEndDatePicker.Name = "appointmentEndDatePicker";
            this.appointmentEndDatePicker.Size = new System.Drawing.Size(200, 22);
            this.appointmentEndDatePicker.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(726, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "appointmentEndDate";
            // 
            // Browsepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1122, 781);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.appointmentEndDatePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.resultpanel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.appointmentStartDatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Browsepage";
            this.Text = "Browsepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker appointmentStartDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FlowLayoutPanel resultpanel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker appointmentEndDatePicker;
        private System.Windows.Forms.Label label5;
    }
}