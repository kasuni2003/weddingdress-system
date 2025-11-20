namespace Project1
{
    partial class Generateinvoice
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
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.btnGenerateInvoice = new System.Windows.Forms.Button();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.invoiceTextBox = new System.Windows.Forms.TextBox();
            this.backinvoice = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "customer Id";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(331, 207);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(464, 22);
            this.txtCustomerID.TabIndex = 1;
            // 
            // btnGenerateInvoice
            // 
            this.btnGenerateInvoice.Location = new System.Drawing.Point(928, 194);
            this.btnGenerateInvoice.Name = "btnGenerateInvoice";
            this.btnGenerateInvoice.Size = new System.Drawing.Size(213, 42);
            this.btnGenerateInvoice.TabIndex = 2;
            this.btnGenerateInvoice.Text = "generate invoice";
            this.btnGenerateInvoice.UseVisualStyleBackColor = true;
            this.btnGenerateInvoice.Click += new System.EventHandler(this.btnGenerateInvoice_Click);
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.Location = new System.Drawing.Point(928, 387);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(213, 42);
            this.btnPrintInvoice.TabIndex = 3;
            this.btnPrintInvoice.Text = "print invoice";
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // invoiceTextBox
            // 
            this.invoiceTextBox.Location = new System.Drawing.Point(331, 369);
            this.invoiceTextBox.Multiline = true;
            this.invoiceTextBox.Name = "invoiceTextBox";
            this.invoiceTextBox.ReadOnly = true;
            this.invoiceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.invoiceTextBox.Size = new System.Drawing.Size(503, 278);
            this.invoiceTextBox.TabIndex = 4;
            // 
            // backinvoice
            // 
            this.backinvoice.Location = new System.Drawing.Point(928, 12);
            this.backinvoice.Name = "backinvoice";
            this.backinvoice.Size = new System.Drawing.Size(129, 38);
            this.backinvoice.TabIndex = 5;
            this.backinvoice.Text = "Back";
            this.backinvoice.UseVisualStyleBackColor = true;
            this.backinvoice.Click += new System.EventHandler(this.backinvoice_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Generate Invoice & Print";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(1080, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(129, 38);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Generateinvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1212, 828);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backinvoice);
            this.Controls.Add(this.invoiceTextBox);
            this.Controls.Add(this.btnPrintInvoice);
            this.Controls.Add(this.btnGenerateInvoice);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label1);
            this.Name = "Generateinvoice";
            this.Text = "Generateinvoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Button btnGenerateInvoice;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.TextBox invoiceTextBox;
        private System.Windows.Forms.Button backinvoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exit;
    }
}