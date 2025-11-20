using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project1
{
    public partial class Browsepage : Form
    {
        public Browsepage()
        {
            InitializeComponent();

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            resultpanel.Controls.Clear(); // Clear previous results

            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    MessageBox.Show("Please select a dress type.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the selected dress type
                string selectedType = comboBox1.Text;



                // Get the selected start and end appointment dates
                DateTime appointmentStartDate = appointmentStartDatePicker.Value;
                DateTime appointmentEndDate = appointmentEndDatePicker.Value;

                // Establish database connection
                using (SqlConnection connection = DataBaseHelper.GetConnection())
                {
                    connection.Open();

                    // SQL query with appointment conflict check
                    string query = @"
        SELECT DressId, Name, Type, Color, Size, Price, Quantity, Imagepath, Image
        FROM Manegecloset
        WHERE LOWER(Type) = LOWER(@Type)
        AND NOT EXISTS (
            SELECT 1
            FROM Appointment
            WHERE Appointment.DressId = Manegecloset.DressId
            AND (
                (AppointmentDate <= @AppointmentEndDate AND ReturnDate >= @AppointmentStartDate)
                OR (AppointmentDate <= @AppointmentStartDate AND ReturnDate >= @AppointmentStartDate)
                OR (AppointmentDate <= @AppointmentEndDate AND ReturnDate >= @AppointmentEndDate)
            )
        )";

                    // Create the command
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Type", selectedType);
                    command.Parameters.AddWithValue("@AppointmentStartDate", appointmentStartDate);
                    command.Parameters.AddWithValue("@AppointmentEndDate", appointmentEndDate);
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // Process results
                            }
                            else
                            {
                                MessageBox.Show("No dresses found.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Query execution error: " + ex.Message);
                    }

                    // Create a list to store dress data
                    var dressList = new List<dynamic>();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dressList.Add(new
                            {
                                DressId = reader["DressId"].ToString(),
                                Name = reader["Name"].ToString(),
                                Type = reader["Type"].ToString(),
                                Color = reader["Color"].ToString(),
                                Size = reader["Size"].ToString(),
                                Price = reader["Price"].ToString(),
                                Image = reader["Image"] as byte[]
                            });
                        }
                    }

                    // Process each dress and check for appointments
                    foreach (var dress in dressList)
                    {
                        // Create a panel to display each dress
                        Panel dressPanel = new Panel
                        {
                            Size = new Size(200, 400),
                            BorderStyle = BorderStyle.FixedSingle,
                            Margin = new Padding(10)
                        };

                        // Display image if it exists
                        if (dress.Image != null && dress.Image.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(dress.Image))
                            {
                                PictureBox pictureBox = new PictureBox
                                {
                                    Size = new Size(180, 150),
                                    Location = new Point(10, 10),
                                    BorderStyle = BorderStyle.FixedSingle,
                                    SizeMode = PictureBoxSizeMode.StretchImage,
                                    Image = Image.FromStream(ms)
                                };
                                dressPanel.Controls.Add(pictureBox);
                            }
                        }
                        else
                        {
                            PictureBox pictureBox = new PictureBox
                            {
                                Size = new Size(180, 150),
                                Location = new Point(10, 10),
                                BorderStyle = BorderStyle.FixedSingle,
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Image = Properties.Resources._1 // Placeholder image if no image is found
                            };
                            dressPanel.Controls.Add(pictureBox);
                        }

                        // Add dress details (ID, name, color, size, price)
                        Label dressidLabel = new Label
                        {
                            Text = "DressId: " + dress.DressId,
                            Location = new Point(10, 170),
                            AutoSize = true
                        };
                        dressPanel.Controls.Add(dressidLabel);

                        Label nameLabel = new Label
                        {
                            Text = "Name: " + dress.Name,
                            Location = new Point(10, 190),
                            AutoSize = true
                        };
                        dressPanel.Controls.Add(nameLabel);

                        Label colorLabel = new Label
                        {
                            Text = "Color: " + dress.Color,
                            Location = new Point(10, 210),
                            AutoSize = true
                        };
                        dressPanel.Controls.Add(colorLabel);

                        Label sizeLabel = new Label
                        {
                            Text = "Size: " + dress.Size,
                            Location = new Point(10, 230),
                            AutoSize = true
                        };
                        dressPanel.Controls.Add(sizeLabel);

                        Label priceLabel = new Label
                        {
                            Text = "Price: $" + dress.Price,
                            Location = new Point(10, 250),
                            AutoSize = true
                        };
                        dressPanel.Controls.Add(priceLabel);

                        // Add "Make Appointment" button
                       
                        // Check if this dress has existing appointments
                        string checkAppointmentQuery = @"
    SELECT AppointmentDate, ReturnDate
    FROM Appointment
    WHERE DressId = @DressId";

                        SqlCommand checkCommand = new SqlCommand(checkAppointmentQuery, connection);
                        checkCommand.Parameters.AddWithValue("@DressId", dress.DressId);

                        int appointmentLabelYOffset = 300; // Start Y offset for the appointment labels

                        using (SqlDataReader appointmentReader = checkCommand.ExecuteReader())
                        {
                            while (appointmentReader.Read())
                            {
                                DateTime appointmentDate = appointmentReader.GetDateTime(0);
                                DateTime returnDate = appointmentReader.GetDateTime(1);

                                Label appointmentDateLabel = new Label
                                {
                                    Text = $"Booked: {appointmentDate:dd-MM-yyyy} to {returnDate:dd-MM-yyyy}",
                                    Location = new Point(10, appointmentLabelYOffset), // Increment Y offset for each appointment
                                    AutoSize = true,
                                    ForeColor = Color.Red
                                };

                                dressPanel.Controls.Add(appointmentDateLabel);

                                // Adjust the Y offset for the next label
                                appointmentLabelYOffset += 20; // Increment by 20 pixels for each label
                            }
                        }
                        // Add "Make Appointment" button
                        Button appointmentButton = new Button
                        {
                            Text = "Make Appointment",
                            Location = new Point(20, 350),
                            Size = new Size(180, 30),
                            BackColor = Color.LightBlue
                        };


                        // Allow the user to book another appointment
                        appointmentButton.Click += (s, args) =>
                        {
                            MessageBox.Show($"Proceeding to make an appointment for Dress ID: {dress.DressId}.", "Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Pass the DressId to the Appointment form
                            Appointment appointmentForm = new Appointment(dress.DressId); // Pass DressId
                            appointmentForm.Show(); // Show the appointment form
                            this.Hide(); // Optionally hide the current form
                        };

                        // Add the button to the panel
                        dressPanel.Controls.Add(appointmentButton);

                        // Add the panel to the resultsPanel
                        resultpanel.Controls.Add(dressPanel);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();  // Close the form if "Yes" is clicked
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            customerdashboard form = new customerdashboard();
            form.Show();
            this.Close();
        }
    }
}




