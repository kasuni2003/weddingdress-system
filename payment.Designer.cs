namespace Project1
{
    partial class payment
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
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.telephonenumber = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.remaingamount = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Pay amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Total amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Dress price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Rental period";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 22);
            this.textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(247, 268);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(392, 22);
            this.textBox2.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(247, 317);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(392, 22);
            this.textBox3.TabIndex = 26;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(247, 371);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(392, 22);
            this.textBox4.TabIndex = 27;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 41);
            this.button1.TabIndex = 28;
            this.button1.Text = "confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1271, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 41);
            this.button2.TabIndex = 29;
            this.button2.Text = "Back ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(539, 610);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 39);
            this.button3.TabIndex = 30;
            this.button3.Text = "cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Customer id";
            // 
            // telephonenumber
            // 
            this.telephonenumber.Location = new System.Drawing.Point(247, 170);
            this.telephonenumber.Name = "telephonenumber";
            this.telephonenumber.Size = new System.Drawing.Size(392, 22);
            this.telephonenumber.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 725);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1069, 267);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Remaing Amount to pay";
            // 
            // remaingamount
            // 
            this.remaingamount.Location = new System.Drawing.Point(247, 494);
            this.remaingamount.Name = "remaingamount";
            this.remaingamount.Size = new System.Drawing.Size(392, 22);
            this.remaingamount.TabIndex = 35;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "complete",
            "pending"});
            this.comboBox1.Location = new System.Drawing.Point(247, 425);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(392, 24);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Payment status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(512, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 35);
            this.label8.TabIndex = 38;
            this.label8.Text = "Payments";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(1425, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(121, 41);
            this.exit.TabIndex = 39;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1077, 739);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 236);
            this.vScrollBar1.TabIndex = 40;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1558, 1004);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.remaingamount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.telephonenumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "payment";
            this.Text = "payment";
            this.Load += new System.EventHandler(this.payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telephonenumber;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox remaingamount;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}