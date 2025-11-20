using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project1
{
    public partial class Manegecloset : Form
    {
      
        public Manegecloset()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                    // Validate inputs
                    if (string.IsNullOrWhiteSpace(dressid.Text) ||
                        string.IsNullOrWhiteSpace(name.Text) ||
                        type.CheckedItems.Count == 0 ||
                        string.IsNullOrWhiteSpace(color.Text) ||
                        size.SelectedItem == null ||
                        string.IsNullOrWhiteSpace(price.Text) ||
                        string.IsNullOrWhiteSpace(Quantity.Text))
                    {
                        MessageBox.Show("Please fill in all required fields.");
                        return;
                    }

                    // Extract values from form controls
                    int DressId = int.Parse(dressid.Text);
                    string Name = name.Text;

                    // Convert checked items into a comma-separated string
                    string Type = string.Join(", ", type.CheckedItems.Cast<string>());

                    string Color = color.Text;
                    string Size = size.SelectedItem?.ToString();
                    decimal Price = decimal.Parse(price.Text);
                    int quantity = int.Parse(Quantity.Text);
                  
                    string ImagePath = image1.Text;

                    // Get image as byte array
                    byte[] Image = getphoto();

                    // Establish database connection
                    using (SqlConnection connection = DataBaseHelper.GetConnection())
                    {
                        connection.Open();

                        // SQL Insert Query
                        string query = @"
                INSERT INTO Manegecloset (DressId, Name, Type, Color, Size, Price, Quantity, Imagepath, Image) 
                VALUES (@DressId, @Name, @Type, @Color, @Size, @Price, @Quantity, @Imagepath, @Image)";

                        // Create SQL Command
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Add parameters with correct values
                            command.Parameters.AddWithValue("@DressId", DressId);
                            command.Parameters.AddWithValue("@Name", Name);
                            command.Parameters.AddWithValue("@Type", Type); // Use converted string for type
                            command.Parameters.AddWithValue("@Color", Color);
                            command.Parameters.AddWithValue("@Size", Size); // Use string value for size
                            command.Parameters.AddWithValue("@Price", Price);
                            command.Parameters.AddWithValue("@Quantity", quantity);
                            
                           
                            command.Parameters.AddWithValue("@Imagepath", ImagePath);
                            command.Parameters.AddWithValue("@Image", Image);

                            // Execute the query
                            command.ExecuteNonQuery();
                            MessageBox.Show("Dress added successfully!");
                        }
                    }
                LoadData();
            }
                catch (Exception ex)
                {
                    // Handle any errors
                    MessageBox.Show("Error adding dress: " + ex.Message);
                }
            }

        private byte[] getphoto()
        {
           MemoryStream stream = new MemoryStream();
            image.Image.Save(stream,image.Image.RawFormat);

            return stream.GetBuffer();
        }

        private void ClearFields()
        {
            dressid.Clear();  // Clear text field
            name.Clear();
            color.Clear();
            price.Clear();
            Quantity.Clear();
            image1.Clear();  // If image path is stored in a textbox

            size.SelectedIndex = -1; // Reset dropdown selection
            type.ClearSelected(); // Clear checked items in CheckedListBox
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Adminpage AdminForm = new Adminpage();
            AdminForm.Show();
            this.Close();
        }

        private void LoadData()
        {

            try
    {
        using (SqlConnection connection = DataBaseHelper.GetConnection())
        {
            connection.Open();
            string query = "SELECT * FROM Manegecloset";
        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
        DataTable dataTable = new DataTable();
        adapter.Fill(dataTable);

            // Add a new column for the image to the DataTable
            if (!dataTable.Columns.Contains("DisplayImage"))
            {
                dataTable.Columns.Add("DisplayImage", typeof(Image));
            }

            // Convert binary image data (byte[]) to Image for each row
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["Image"] != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row["Image"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        row["DisplayImage"] = Image.FromStream(ms); // Convert to Image
                    }
                }
            }

            // Bind DataTable to DataGridView
            dataGridView1.DataSource = dataTable;

// Remove the binary image column if it exists
if (dataGridView1.Columns.Contains("Image"))
{
    dataGridView1.Columns.Remove("Image");
}

// Add image column if it doesn’t exist
if (!dataGridView1.Columns.Contains("DisplayImage"))
{
    DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
    {
        Name = "DisplayImage",
        HeaderText = "Image",
        DataPropertyName = "DisplayImage",
        ImageLayout = DataGridViewImageCellLayout.Zoom // Adjust image layout
    };
    dataGridView1.Columns.Add(imageColumn);
}
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error loading data: " + ex.Message);
    }
}


        private void browseimage_Click(object sender, EventArgs e)
        {
        }

        private void Browse_Click(object sender, EventArgs e)
        {
           OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image.Image=new Bitmap(openFileDialog.FileName);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is selected
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                dressid.Text = row.Cells["DressId"].Value.ToString();
                name.Text = row.Cells["Name"].Value.ToString();
                color.Text = row.Cells["Color"].Value.ToString();
                size.SelectedItem = row.Cells["Size"].Value.ToString();
                price.Text = row.Cells["Price"].Value.ToString();
                Quantity.Text = row.Cells["Quantity"].Value.ToString();
                image1.Text = row.Cells["Imagepath"].Value.ToString();

                // Load checked items for type (if applicable)
                string types = row.Cells["Type"].Value.ToString();
                foreach (string t in types.Split(','))
                {
                    int index = type.Items.IndexOf(t.Trim());
                    if (index >= 0)
                    {
                        type.SetItemChecked(index, true);
                    }
                }
            }
        }

    

        private void Manegecloset_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the search term from the TextBox and validate
                if (!int.TryParse(searchTextBox.Text.Trim(), out int dressId))
                {
                    MessageBox.Show("Please enter a valid Dress ID.");
                    return;
                }

                // Establish a connection to the database
                using (SqlConnection connection = DataBaseHelper.GetConnection())
                {
                    connection.Open();

                    // SQL query to search by DressId
                    string query = @"
            SELECT DressId, Name, Type, Color, Size, Price, Quantity, Imagepath, Image 
            FROM Manegecloset WHERE DressId = @DressId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DressId", dressId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Load data into relevant textboxes
                                dressid.Text = reader["DressId"].ToString();
                                name.Text = reader["Name"].ToString();
                                type.Text = reader["Type"].ToString();
                                color.Text = reader["Color"].ToString();
                                size.Text = reader["Size"].ToString();
                                price.Text = reader["Price"].ToString();
                                Quantity.Text = reader["Quantity"].ToString();
                                image1.Text = reader["Imagepath"].ToString();

                                // Load Image if available
                                if (reader["Image"] != DBNull.Value)
                                {
                                    byte[] imageBytes = (byte[])reader["Image"];
                                    using (MemoryStream ms = new MemoryStream(imageBytes))
                                    {
                                        image.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    image.Image = null; // Clear the image if not found
                                }

                                // Highlight the row in DataGridView
                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    if (row.Cells["DressId"].Value != null && Convert.ToInt32(row.Cells["DressId"].Value) == dressId)
                                    {
                                        row.Selected = true;
                                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index; // Scroll to selected row
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Dress ID not found.");
                            }
                            ClearFields();
                        }
                    }
                }
            }

            
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching: " + ex.Message);
            }
        }

        private void Clear_search_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
            LoadData();
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected
                if (string.IsNullOrWhiteSpace(dressid.Text))
                {
                    MessageBox.Show("Please select a dress to update.");
                    return;
                }

                int selectedDressId = Convert.ToInt32(dressid.Text);

                // Validate input fields
                if (string.IsNullOrWhiteSpace(name.Text) ||
                    type.CheckedItems.Count == 0 ||
                    string.IsNullOrWhiteSpace(color.Text) ||
                    size.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(price.Text) ||
                    string.IsNullOrWhiteSpace(Quantity.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                // Get values from form fields
                string Name = name.Text;
                string Type = string.Join(", ", type.CheckedItems.Cast<string>());
                string Color = color.Text;
                string Size = size.SelectedItem?.ToString();
                decimal Price = decimal.Parse(price.Text);
                int quantity = int.Parse(Quantity.Text);
                string ImagePath = image1.Text;
                byte[] Image = getphoto();

                // SQL Update Query
                string query = @"
            UPDATE Manegecloset
            SET Name = @Name,
                Type = @Type,
                Color = @Color,
                Size = @Size,
                Price = @Price,
                Quantity = @Quantity,
                Imagepath = @Imagepath,
                Image = @Image
            WHERE DressId = @DressId";

                using (SqlConnection connection = DataBaseHelper.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DressId", selectedDressId);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Type", Type);
                        command.Parameters.AddWithValue("@Color", Color);
                        command.Parameters.AddWithValue("@Size", Size);
                        command.Parameters.AddWithValue("@Price", Price);
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@Imagepath", ImagePath);
                        command.Parameters.AddWithValue("@Image", Image);

                        command.ExecuteNonQuery();
                    }
                }

                // Show success message
                MessageBox.Show("Dress updated successfully!");

                // Refresh DataGridView
                LoadData();

                ClearFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating dress: " + ex.Message);
            }
        }

        private void Remove_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected in the DataGridView
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Get the DressId of the selected row
                    int selectedDressId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["DressId"].Value);

                    // Display a confirmation dialog
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to remove this dress from the closet?",
                        "Confirm Deletion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    // If the user confirms, delete the record
                    if (result == DialogResult.Yes)
                    {
                        // SQL DELETE Query
                        string query = "DELETE FROM Manegecloset WHERE DressId = @DressId";

                        // Establish the database connection and execute the DELETE query
                        using (SqlConnection connection = DataBaseHelper.GetConnection())
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                // Add parameter for DressId
                                command.Parameters.AddWithValue("@DressId", selectedDressId);

                                // Execute the DELETE query
                                command.ExecuteNonQuery();
                            }
                        }

                        // Inform the user that the dress has been removed
                        MessageBox.Show("Dress removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reload data into DataGridView
                        LoadData();

                        ClearFields();
                    }
                }
                else
                {
                    // Show a warning if no row is selected
                    MessageBox.Show("Please select a dress to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show("Error removing dress: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();  // Close the form if "Yes" is clicked
            }
        }
    }
    }
    


           

