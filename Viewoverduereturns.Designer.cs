namespace Project1
{
    partial class Viewoverduereturns
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
            this.dataGridViewOverdue = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOverdue)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOverdue
            // 
            this.dataGridViewOverdue.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewOverdue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOverdue.GridColor = System.Drawing.Color.MistyRose;
            this.dataGridViewOverdue.Location = new System.Drawing.Point(48, 225);
            this.dataGridViewOverdue.Name = "dataGridViewOverdue";
            this.dataGridViewOverdue.RowHeadersWidth = 51;
            this.dataGridViewOverdue.RowTemplate.Height = 24;
            this.dataGridViewOverdue.Size = new System.Drawing.Size(998, 476);
            this.dataGridViewOverdue.TabIndex = 0;
            this.dataGridViewOverdue.VisibleChanged += new System.EventHandler(this.dataGridViewOverdue_VisibleChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(48, 112);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(128, 47);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(980, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(128, 47);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(812, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(128, 47);
            this.back.TabIndex = 3;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "View Late Returns";
            // 
            // Viewoverduereturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1120, 787);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridViewOverdue);
            this.Name = "Viewoverduereturns";
            this.Text = "Viewoverduereturns";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOverdue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOverdue;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
    }
}