using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Displaydress : Form
    {
        public Displaydress()
        {
            InitializeComponent();
        
            btnLoadDresses.Click += BtnLoadDresses_Click; // Attach click event
        }

        private void BtnLoadDresses_Click(object sender, EventArgs e)
        {
            LoadDressImages();
        }

        private void panelDresses_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLoadDresses_Click(object sender, EventArgs e)
        {
            LoadDressImages();
        }

        private void LoadDressImages()
        {
            panelDresses.Controls.Clear(); // Clear existing controls

            using (SqlConnection connection = DataBaseHelper.GetConnection())
            {
                connection.Open();

                string query = "SELECT DressId, Name, Image FROM Manegecloset";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                int x = 10; // X Position (Horizontal)
                int y = 10; // Y Position (Vertical)
                int count = 0;

                while (reader.Read())
                {
                    // Convert Image (byte array) from database
                    byte[] imageBytes = reader["Image"] as byte[];
                    Image image = null;

                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        image = Properties.Resources._1; // Placeholder if no image
                    }

                    // Create PictureBox
                    PictureBox pb = new PictureBox
                    {
                        Image = image,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Width = 100,
                        Height = 100,
                        Location = new Point(x, y),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    // Create Label for DressId & Name
                    Label lbl = new Label
                    {
                        Text = $"ID: {reader["DressId"]} - {reader["Name"]}",
                        Location = new Point(x, y + 105),
                        AutoSize = true
                    };

                    // Add Controls to Panel
                    panelDresses.Controls.Add(pb);
                    panelDresses.Controls.Add(lbl);

                    // Adjust position for next item
                    x += 120; // Move right
                    count++;

                    // Move to next row after 4 images
                    if (count % 4 == 0)
                    {
                        x = 10;
                        y += 150; // Move down
                    }
                }
                reader.Close();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Adminpage Form = new Adminpage();
            Form.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();  // Close the form if "Yes" is clicked
            }
        }

        private void Displaydress_Load(object sender, EventArgs e)
        {

        }
    }
}
