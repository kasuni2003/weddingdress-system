namespace Project1
{
    partial class Manegecloset
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
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dressid = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.size = new System.Windows.Forms.ComboBox();
            this.type = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Remove_btn = new System.Windows.Forms.Button();
            this.Edit_btn = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.image1 = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dress Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quantity";
            // 
            // dressid
            // 
            this.dressid.BackColor = System.Drawing.Color.White;
            this.dressid.Location = new System.Drawing.Point(273, 69);
            this.dressid.Name = "dressid";
            this.dressid.Size = new System.Drawing.Size(318, 22);
            this.dressid.TabIndex = 10;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(273, 127);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(318, 22);
            this.name.TabIndex = 11;
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(273, 272);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(318, 22);
            this.color.TabIndex = 13;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(273, 384);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(318, 22);
            this.price.TabIndex = 15;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(273, 436);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(318, 22);
            this.Quantity.TabIndex = 16;
            // 
            // size
            // 
            this.size.FormattingEnabled = true;
            this.size.Items.AddRange(new object[] {
            "S",
            "XS",
            "M",
            "L",
            "XL",
            "XXL",
            "XXXL"});
            this.size.Location = new System.Drawing.Point(273, 321);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(318, 24);
            this.size.TabIndex = 20;
            this.size.Text = "select the size";
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Bridal frocks",
            "Bridal sarees",
            "Bridesmaid dresses",
            "normal wedding dresses"});
            this.type.Location = new System.Drawing.Point(273, 165);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(318, 89);
            this.type.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 593);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1403, 450);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(47, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 21);
            this.label11.TabIndex = 24;
            this.label11.Text = "Name";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 25;
            this.label2.Text = "Type";
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(1355, 272);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(169, 48);
            this.Add_btn.TabIndex = 26;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(1420, 202);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(115, 29);
            this.Search_btn.TabIndex = 27;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Remove_btn
            // 
            this.Remove_btn.Location = new System.Drawing.Point(1355, 358);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(169, 48);
            this.Remove_btn.TabIndex = 28;
            this.Remove_btn.Text = "Remove";
            this.Remove_btn.UseVisualStyleBackColor = true;
            this.Remove_btn.Click += new System.EventHandler(this.Remove_btn_Click);
            // 
            // Edit_btn
            // 
            this.Edit_btn.Location = new System.Drawing.Point(1355, 448);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(169, 48);
            this.Edit_btn.TabIndex = 29;
            this.Edit_btn.Text = "Edit";
            this.Edit_btn.UseVisualStyleBackColor = true;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.Location = new System.Drawing.Point(1290, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(125, 39);
            this.Back.TabIndex = 31;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(766, 65);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(318, 22);
            this.image1.TabIndex = 33;
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(1090, 65);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 34;
            this.Browse.Text = "browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Size";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(50, 381);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 25);
            this.label12.TabIndex = 36;
            this.label12.Text = "Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(47, 429);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 25);
            this.label13.TabIndex = 37;
            this.label13.Text = "Quantity";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(628, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 25);
            this.label16.TabIndex = 40;
            this.label16.Text = "Imagepath";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(1324, 165);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(211, 22);
            this.searchTextBox.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1251, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "search";
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(633, 130);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(532, 410);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 22;
            this.image.TabStop = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Location = new System.Drawing.Point(1421, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(125, 39);
            this.exit.TabIndex = 45;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(532, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 42);
            this.label5.TabIndex = 46;
            this.label5.Text = "Manage Closet";
            // 
            // Manegecloset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1547, 1055);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.image1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Edit_btn);
            this.Controls.Add(this.Remove_btn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.image);
            this.Controls.Add(this.type);
            this.Controls.Add(this.size);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.price);
            this.Controls.Add(this.color);
            this.Controls.Add(this.name);
            this.Controls.Add(this.dressid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Manegecloset";
            this.Text = "Manegecloset";
            this.Load += new System.EventHandler(this.Manegecloset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dressid;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox color;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.ComboBox size;
        private System.Windows.Forms.CheckedListBox type;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Remove_btn;
        private System.Windows.Forms.Button Edit_btn;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox image1;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label5;
    }
}