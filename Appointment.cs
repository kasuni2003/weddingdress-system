using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Project1
{
    public partial class Appointment : Form
    {
        private string _dressId;
        private decimal _dressPrice;

        // Constructor to receive DressId
        public Appointment(string dressId)
        {
            InitializeComponent();
            _dressId = dressId;

            // Use _dressId to display or process the appointment
            MessageBox.Show($"Creating appointment for Dress ID: {_dressId}");
        }

        // Constructor to receive DressId and DressPrice
        public Appointment(string dressId, decimal dressPrice)
        {
            InitializeComponent();
            _dressId = dressId;
            _dressPrice = dressPrice;

            // Display dress price
            rentalfee.Text = $"Dress Price: ${_dressPrice}";

            // Automatically calculate rental fee when dates change
            dateTimePicker2.ValueChanged += DateTimePicker_ValueChanged;
            dateTimePicker3.ValueChanged += DateTimePicker_ValueChanged;
        }

        // Event handler for when either the start or end date is changed
        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            CalculateRentalFee();
        }

        // Method to calculate rental fee
        private void CalculateRentalFee()
        {
            if (dateTimePicker3.Value > dateTimePicker2.Value)
            {
                int rentalDays = (dateTimePicker3.Value - dateTimePicker2.Value).Days;

                if (rentalDays < 1)
                {
                    MessageBox.Show("The rental period must be at least one day.", "Invalid Rental Period", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                rentalperiod.Text = $"Rental Period: {rentalDays} days";

                decimal rentalFeePerDay = 10m;
                decimal totalRentalFee = _dressPrice + (rentalDays * rentalFeePerDay);

                // Update the newly added TextBox
                rentalFeeTextBox.Text = totalRentalFee.ToString("C");  // Formats as currency
            }
            else
            {
                MessageBox.Show("Return date must be after the appointment date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event handler for confirming the appointment and saving to database
        private void ConfirmAppointment()
        {
            try
            {
                // Calculate rental fee automatically before confirming
                CalculateRentalFee();

                if (string.IsNullOrWhiteSpace(rentalFeeTextBox.Text))
                {
                    MessageBox.Show("Rental fee cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Remove currency symbol and spaces before parsing
                string feeText = rentalFeeTextBox.Text.Replace("$", "").Trim();

                // Ensure it contains only valid decimal numbers
                if (!decimal.TryParse(feeText, out decimal rentalFee))
                {
                    MessageBox.Show("Invalid rental fee format. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Bind the parsed decimal value to the SQL parameter
                

                // Create a new appointment entry in the database
                using (SqlConnection connection = DataBaseHelper.GetConnection())
                {
                    connection.Open();

                    // Updated SQL query to include customer details
                    string query = @"
                    INSERT INTO Appointments 
                    (DressId, AppointmentDate, ReturnDate,FittingDate, RentalFee, CustomerId, CustomerName, CustomerEmail, CustomerTp, CustomerAddress) 
                    VALUES 
                    (@DressId, @AppointmentDate, @ReturnDate,@FittingDate, @RentalFee, @CustomerId, @CustomerName, @CustomerEmail, @CustomerTp, @CustomerAddress)";

                    // Execute the SQL command
                    SqlCommand command = new SqlCommand(query, connection);

                    // Bind parameters
                 
                    command.Parameters.AddWithValue("@DressId", _dressId);
                    command.Parameters.AddWithValue("@AppointmentDate", dateTimePicker2.Value);
                    command.Parameters.AddWithValue("@ReturnDate", dateTimePicker3.Value);
                    command.Parameters.AddWithValue("@FittingDate", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@RentalFee", rentalFee);
                    command.Parameters.AddWithValue("@CustomerId", customerid.Text);
                    command.Parameters.AddWithValue("@CustomerName", customername.Text);
                    command.Parameters.AddWithValue("@CustomerEmail", customeremail.Text);
                    command.Parameters.AddWithValue("@CustomerTp", customertelephone.Text);
                    command.Parameters.AddWithValue("@CustomerAddress", customeraddress.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Appointment confirmed and saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Update the data grid with the new data
                        RefreshAppointmentsGrid();

                        
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

        // Method to refresh the appointments grid
        private void RefreshAppointmentsGrid()
        {
            try
            {
                using (SqlConnection connection = DataBaseHelper.GetConnection())
                {
                    connection.Open();

                    // Retrieve data from Appointment table
                    string query = "SELECT * FROM Appointment";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Bind the data to the grid
                    dataGridView2.DataSource = dataTable;

                    dataGridView2.Columns["CustomerName"].Visible = true;
                    dataGridView2.Columns["CustomerEmail"].Visible = true;
                    dataGridView2.Columns["CustomerTp"].Visible = true;
                    dataGridView2.Columns["CustomerAddress"].Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading appointments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for confirming the appointment
        private void button3_Click(object sender, EventArgs e)
        {
            ConfirmAppointment();

            // Fetch rental period and dress price
            int rentalPeriod = CalculateRentalPeriod();
            decimal dressPrice = GetDressPrice(int.Parse(textBox6.Text));
          


            // Open the Payment Form and pass rental period and dress price
            payment paymentForm = new payment(rentalPeriod, dressPrice, this);
            paymentForm.Show(); // Show the Payment Form
            this.Hide(); // Hide the current form (optional)
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


        // Event handler for text box change (if necessary)
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Any necessary code here
        }

        // Event handler for label click (if necessary)
        private void label7_Click(object sender, EventArgs e)
        {
            // Any necessary code here
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Prompt the user to enter the UserId
                string CustomerId = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter the UserId to find the relevant appointment:",
                    "Enter UserId",
                    ""
                );

                if (string.IsNullOrEmpty(CustomerId))
                {
                    MessageBox.Show("UserId cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Search the DataGridView for matching rows
                bool rowFound = false;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    // Log the value of the current cell to debug
                    Console.WriteLine($"Checking CustomerId: {row.Cells["CustomerId"].Value}");

                    if (row.Cells["CustomerId"].Value != null && row.Cells["CustomerId"].Value.ToString().Trim() == CustomerId.Trim())
                    {
                        // Select the matching row
                        row.Selected = true;
                        rowFound = true;
                        break;
                    }
                }

                if (!rowFound)
                {
                    MessageBox.Show("No matching UserId found in the DataGridView.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Confirm cancellation
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to cancel the selected appointment?",
                    "Confirm Cancellation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    // Get AppointmentId from the selected row
                    string appointmentId = dataGridView2.SelectedRows[0].Cells["AppointmentId"].Value.ToString();

                    // Delete the appointment from the database
                    using (SqlConnection connection = DataBaseHelper.GetConnection())
                    {
                        connection.Open();

                        string deleteQuery = "DELETE FROM Appointment WHERE AppointmentId = @AppointmentId";
                        SqlCommand command = new SqlCommand(deleteQuery, connection);
                        command.Parameters.AddWithValue("@AppointmentId", appointmentId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Appointment canceled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the grid
                            RefreshAppointmentsGrid();
                        }
                        else
                        {
                            MessageBox.Show("Failed to cancel the appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (edit.Text == "Save")
                {
                    // Validate the required fields
                    if (string.IsNullOrEmpty(customerid.Text) || string.IsNullOrEmpty(customername.Text) || string.IsNullOrEmpty(customeremail.Text))
                    {
                        MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Update the record in the database
                    using (SqlConnection connection = DataBaseHelper.GetConnection())
                    {
                        connection.Open();

                        string updateQuery = @"
                    UPDATE Appointment
                    SET AppointmentDate = @AppointmentDate, 
                        ReturnDate = @ReturnDate, 
                        RentalFee = @RentalFee, 
                        CustomerName = @CustomerName, 
                        CustomerEmail = @CustomerEmail, 
                        CustomerTp = @CustomerTp, 
                        CustomerAddress = @CustomerAddress
                    WHERE CustomerId = @CustomerId";

                        SqlCommand command = new SqlCommand(updateQuery, connection);

                        // Bind parameters
                        command.Parameters.AddWithValue("@CustomerId", customerid.Text);
                        command.Parameters.AddWithValue("@AppointmentDate", dateTimePicker2.Value);
                        command.Parameters.AddWithValue("@ReturnDate", dateTimePicker3.Value);
                        command.Parameters.AddWithValue("@RentalFee", rentfee.Text.Split('$')[1]);
                        command.Parameters.AddWithValue("@CustomerName", customername.Text);
                        command.Parameters.AddWithValue("@CustomerEmail", customeremail.Text);
                        command.Parameters.AddWithValue("@CustomerTp", customertelephone.Text);
                        command.Parameters.AddWithValue("@CustomerAddress", customeraddress.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Appointment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cancel.Text = "Edit";
                            RefreshAppointmentsGrid();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    // Prompt the user to enter the UserId
                    string userId = Interaction.InputBox(
                        "Enter the UserId to find the relevant appointment:",
                        "Enter UserId",
                        ""
                    );

                    if (string.IsNullOrEmpty(userId))
                    {
                        MessageBox.Show("UserId cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Search for the appointment in the database
                    using (SqlConnection connection = DataBaseHelper.GetConnection())
                    {
                        connection.Open();

                        string query = "SELECT * FROM Appointment WHERE CustomerId = @CustomerId";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@CustomerId", userId);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            // Load the data into the text fields
                            customerid.Text = reader["CustomerId"].ToString();
                            customername.Text = reader["CustomerName"].ToString();
                            customeremail.Text = reader["CustomerEmail"].ToString();
                            customertelephone.Text = reader["CustomerTp"].ToString();
                            customeraddress.Text = reader["CustomerAddress"].ToString();
                            dateTimePicker2.Value = Convert.ToDateTime(reader["AppointmentDate"]);
                            dateTimePicker3.Value = Convert.ToDateTime(reader["ReturnDate"]);
                            rentfee.Text = $"Rental Fee: ${reader["RentalFee"]}";

                            // Change the button text to "Save"
                            edit.Text = "Save";

                            MessageBox.Show("Appointment details loaded. You can now edit and save.", "Edit Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No matching appointment found for the given UserId.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void customertelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            customerdashboard closetForm = new customerdashboard();
            closetForm.Show();
            this.Hide(); // Hide the current form (optional)
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















