namespace Project1
{
    partial class Viewfeedbackcs
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
            this.feedbackGridView = new System.Windows.Forms.DataGridView();
            this.backviewfeedback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // feedbackGridView
            // 
            this.feedbackGridView.BackgroundColor = System.Drawing.Color.MistyRose;
            this.feedbackGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feedbackGridView.Location = new System.Drawing.Point(31, 148);
            this.feedbackGridView.Name = "feedbackGridView";
            this.feedbackGridView.RowHeadersWidth = 51;
            this.feedbackGridView.RowTemplate.Height = 24;
            this.feedbackGridView.Size = new System.Drawing.Size(1450, 588);
            this.feedbackGridView.TabIndex = 0;
            this.feedbackGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.feedbackGridView_CellContentClick);
            // 
            // backviewfeedback
            // 
            this.backviewfeedback.Location = new System.Drawing.Point(1296, 25);
            this.backviewfeedback.Name = "backviewfeedback";
            this.backviewfeedback.Size = new System.Drawing.Size(116, 41);
            this.backviewfeedback.TabIndex = 1;
            this.backviewfeedback.Text = "Back";
            this.backviewfeedback.UseVisualStyleBackColor = true;
            this.backviewfeedback.Click += new System.EventHandler(this.backviewfeedback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "View Feedback";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(1448, 25);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(116, 41);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Viewfeedbackcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1592, 845);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backviewfeedback);
            this.Controls.Add(this.feedbackGridView);
            this.Name = "Viewfeedbackcs";
            this.Text = "Viewfeedbackcs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.feedbackGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView feedbackGridView;
        private System.Windows.Forms.Button backviewfeedback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
    }
}