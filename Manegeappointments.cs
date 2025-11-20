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
using System.Xml.Linq;

namespace Project1
{
    public partial class Manegeappointments : Form
    {
        public Manegeappointments()
        {
            InitializeComponent();
          
        }

        private void customername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConfirmAppointment();

            // Fetch rental period and dress price
            int rentalPeriod = CalculateRentalPeriod();
            decimal dressPrice = GetDressPrice(int.Parse(did.Text));

            // Open the Payment Form and pass rental period and dress price
            payment paymentForm = new payment(rentalPeriod,dressPrice, this);
            paymentForm.Show(); // Show the Payment Form
            this.Hide(); // Hide the current form (optional)
        }





        private void ConfirmAppointment()
        {
            try
            {
                // Check if there's an existing appointment with the same DressId and overlapping dates
                if (IsAppointmentDateConflict())
                {
                    MessageBox.Show("There is already an appointment for this dress during the selected date range.", "Appointment Conflict", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Prevent appointment confirmation if there's a conflict
                }

                using (SqlConnection connection = DataBaseHelper.GetConnection())
                {
                    connection.Open();

                    // Insert appointment data into the database
                    string query = @"
            INSERT INTO Appointments 
            (DressId, AppointmentDate, ReturnDate, CustomerId, CustomerName, CustomerEmail, CustomerTp, CustomerAddress, RentalPeriod) 
            VALUES 
            (@DressId, @AppointmentDate, @ReturnDate, @CustomerId, @CustomerName, @CustomerEmail, @CustomerTp, @CustomerAddress, @RentalPeriod)";

                    SqlCommand command = new SqlCommand(query, connection);

                    // Bind parameters
                    command.Parameters.AddWithValue("@DressId", did.Text);
                    command.Parameters.AddWithValue("@AppointmentDate", dateTimePicker2.Value);
                    command.Parameters.AddWithValue("@ReturnDate", dateTimePicker3.Value);
                    command.Parameters.AddWithValue("@CustomerId", customerid.Text);
                    command.Parameters.AddWithValue("@CustomerName", customername.Text);
                    command.Parameters.AddWithValue("@CustomerEmail", customeremail.Text);
                    command.Parameters.AddWithValue("@CustomerTp", customertlephone.Text);
                    command.Parameters.AddWithValue("@CustomerAddress", customeraddress.Text);
                    command.Parameters.AddWithValue("@RentalPeriod", CalculateRentalPeriod());

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Appointment confirmed and saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to save the appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsAppointmentDateConflict()
        {
            try
            {
                using (SqlConnection connection = DataBaseHelper.GetConnection())
                {
                    connection.Open();

                    // Check for overlapping appointment date ranges for the same dress
                    string query = @"
            SELECT COUNT(*) 
            FROM Appointments 
            WHERE DressId = @DressId 
            AND (
                (AppointmentDate BETWEEN @AppointmentDate AND @ReturnDate) 
                OR 
                (ReturnDate BETWEEN @AppointmentDate AND @ReturnDate)
            )";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DressId", did.Text);
                    command.Parameters.AddWithValue("@AppointmentDate", dateTimePicker2.Value);
                    command.Parameters.AddWithValue("@ReturnDate", dateTimePicker3.Value);

                    int count = (int)command.ExecuteScalar();

                    // If count is greater than 0, there is an existing appointment conflict
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking for appointment conflict: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private int CalculateRentalPeriod()
        {
            // Calculate rental period in days
            TimeSpan rentalPeriod = dateTimePicker3.Value - dateTimePicker2.Value;
            return rentalPeriod.Days;
        }

        private decimal GetDressPrice(int dressId)
        {
            decimal dressPrice = 0;

            try
            {
                using (SqlConnection connection = DataBaseHelper.GetConnection())
                {
                    connection.Open();

                    // Fetch dress price from Manegecloset table
                    string query = "SELECT Price FROM Manegecloset WHERE DressId = @DressId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DressId", dressId);

                    object result = command.ExecuteScalar();
                    if (result != null && decimal.TryParse(result.ToString(), out dressPrice))
                    {
                        return dressPrice; // Return the dress price
                    }
                    else
                    {
                        MessageBox.Show("Dress not found or price is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dressPrice;
        }

       

        private void LoadAppointments()
        {
            try
            {
                using (SqlConnection connection = DataBaseHelper.GetConnection())
                {
                    connection.Open();

                    // SQL query to fetch appointment data
                    string query = "SELECT AppointmentId,DressId, CustomerName,CustomerId,CustomerEmail,CustomerAddress, CustomerTp, AppointmentDate, ReturnDate FROM Appointments";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView2.DataSource = dataTable;
                   
               
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Manegeappointments_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0) // Ensure a row is selected
            {
                // Get the AppointmentId from the selected row
                string appointmentId = dataGridView2.SelectedRows[0].Cells["AppointmentId"].Value.ToString();

                // Ask for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to cancel this appointment?",
                                                      "Confirm Cancellation",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) // If user confirms
                {
                    try
                    {
                        using (SqlConnection connection = DataBaseHelper.GetConnection())
                        {
                            connection.Open();

                            // Delete appointment from database using AppointmentId
                            string query = "DELETE FROM Appointments WHERE AppointmentId = @AppointmentId";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@AppointmentId", appointmentId);

                           
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Appointment canceled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Refresh the DataGridView
                                LoadAppointments();
                            }
                            else
                            {
                                MessageBox.Show("Failed to cancel appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Clear textboxes after deletion
                did.Text = "";
                customerid.Text = "";
                customername.Text = "";
                customeremail.Text = "";
                customertlephone.Text = "";
                customeraddress.Text = "";
                dateTimePicker2.Value = DateTime.Now; // Reset to the current date/time
                dateTimePicker3.Value = DateTime.Now; // Reset to the current date/time
            }
            else
            {
                MessageBox.Show("Please select an appointment to cancel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void edit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(did.Text)) // Ensure a record is selected
            {
                // Ask for confirmation before updating
                DialogResult result = MessageBox.Show("Are you sure you want to update this appointment?",
                                                      "Confirm Update",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes) // If user confirms
                {
                    try
                    {
                        using (SqlConnection connection = DataBaseHelper.GetConnection())
                        {
                            connection.Open();

                            // Update appointment details
                            string query = @"
                    UPDATE Appointments 
                    SET AppointmentDate = @AppointmentDate, 
                        ReturnDate = @ReturnDate, 
                        CustomerName = @CustomerName, 
                        CustomerEmail = @CustomerEmail, 
                        CustomerTp = @CustomerTp, 
                        CustomerAddress = @CustomerAddress
                    WHERE DressId = @DressId AND CustomerId = @CustomerId";

                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@DressId", did.Text);
                            command.Parameters.AddWithValue("@CustomerId", customerid.Text);
                            command.Parameters.AddWithValue("@AppointmentDate", dateTimePicker2.Value);
                            command.Parameters.AddWithValue("@ReturnDate", dateTimePicker3.Value);
                            command.Parameters.AddWithValue("@CustomerName", customername.Text);
                            command.Parameters.AddWithValue("@CustomerEmail", customeremail.Text);
                            command.Parameters.AddWithValue("@CustomerTp", customertlephone.Text);
                            command.Parameters.AddWithValue("@CustomerAddress", customeraddress.Text);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Appointment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadAppointments(); // Refresh DataGridView
                            }
                            else
                            {
                                MessageBox.Show("Failed to update the appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is selected
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                // Populate textboxes with selected row data
                did.Text = row.Cells["DressId"].Value.ToString();
                customerid.Text = row.Cells["CustomerId"].Value.ToString();
                customername.Text = row.Cells["CustomerName"].Value.ToString();
                customeremail.Text = row.Cells["CustomerEmail"].Value.ToString();
                customertlephone.Text = row.Cells["CustomerTp"].Value.ToString();
                customeraddress.Text = row.Cells["CustomerAddress"].Value.ToString();
                dateTimePicker2.Value = Convert.ToDateTime(row.Cells["AppointmentDate"].Value);
                dateTimePicker3.Value = Convert.ToDateTime(row.Cells["ReturnDate"].Value);


               
               


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

        private void backmanageappointmant_Click(object sender, EventArgs e)
        {
            Adminpage form = new Adminpage();
            form.Show();
            this.Close();
        }
    }
    }
    

