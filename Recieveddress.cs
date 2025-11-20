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

namespace Project1
{
    public partial class Recieveddress : Form
    {
        private decimal _lateFinePerDay = 5m; // Example fine per day
        public Recieveddress()
        {
            InitializeComponent();
        }

        private void received_Click(object sender, EventArgs e)
        {
            try
            {
                string customerId = customerid.Text;
                if (string.IsNullOrEmpty(customerId))
                {
                    MessageBox.Show("Please enter a valid Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(dressid.Text, out int dressId))
                {
                    MessageBox.Show("Invalid Dress ID. It should be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime receivedDate = dateTimePicker1.Value; // User-selected Received Date

                using (SqlConnection connection = DataBaseHelper.GetConnection())
                {
                    connection.Open();

                    // Step 1: Retrieve PaymentStatus, RemainingAmount, and ReturnDate from database
                    string fetchQuery = @"
                        SELECT Paymentstatus, Remaingamount, ReturnDate
                        FROM Appointments
                        WHERE CustomerId = @CustomerId AND DressId = @DressId";

                    using (SqlCommand fetchCmd = new SqlCommand(fetchQuery, connection))
                    {
                        fetchCmd.Parameters.AddWithValue("@CustomerId", customerId);
                        fetchCmd.Parameters.AddWithValue("@DressId", dressId);

                        using (SqlDataReader reader = fetchCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string paymentStatus = reader["Paymentstatus"].ToString();
                                decimal remainingAmount = Convert.ToDecimal(reader["Remaingamount"]);
                                DateTime returnDate = Convert.ToDateTime(reader["ReturnDate"]);

                                // Display payment info
                                paymentstatus.Text = paymentStatus;
                                remaingamunt.Text = remainingAmount.ToString("0.00");

                                // Step 2: Calculate Late Fine based on Received Date
                                int lateDays = (receivedDate - returnDate).Days;
                                decimal lateFine = 0;
                                decimal finalAmountToPay = remainingAmount;

                                if (lateDays > 0)
                                {
                                    lateFine = lateDays * _lateFinePerDay;
                                    MessageBox.Show($"Late fine calculated: {lateFine:C}", "Late Fine", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    latefine.Text = lateFine.ToString("0.00");
                                    finalAmountToPay += lateFine;
                                }
                                else
                                {
                                    latefine.Text = "0.00";
                                }

                                // If Payment is complete but there is a late fine, show the late fine amount
                                if (paymentStatus.ToLower() == "complete" && remainingAmount == 0)
                                {
                                    if (lateFine > 0)
                                    {
                                        payamounttotal.Text = lateFine.ToString("0.00"); // Show only the late fine
                                    }
                                    else
                                    {
                                        payamounttotal.Text = "0.00"; // No payment needed
                                    }
                                }
                                else
                                {
                                    payamounttotal.Text = finalAmountToPay.ToString("0.00"); // Include remaining balance + late fine
                                }

                                reader.Close();

                                // Step 3: Update ReceivedDress and LateFine in the database
                                string insertQuery = @"
                                    INSERT INTO Returndress (DressId, LateFine, ReceivedDate) 
                                    VALUES (@DressId, @LateFine, @ReceivedDate)";

                                using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                                {
                                    insertCmd.Parameters.AddWithValue("@LateFine", lateFine);
                                    insertCmd.Parameters.AddWithValue("@ReceivedDate", receivedDate);
                                    insertCmd.Parameters.AddWithValue("@DressId", dressId);

                                    int rowsInserted = insertCmd.ExecuteNonQuery();

                                    if (rowsInserted > 0)
                                    {
                                        MessageBox.Show("Dress return recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error recording return.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No record found for this Customer ID and Dress ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void invoive_Click(object sender, EventArgs e)
        {
            Generateinvoice Form = new Generateinvoice();
            Form.Show();
            this.Close();
        }

        private void checkBoxPaymentSuccess_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPaymentSuccess.Checked)
            {
                try
                {
                    string customerId = customerid.Text;
                    int dressId = int.Parse(dressid.Text);

                    using (SqlConnection connection = DataBaseHelper.GetConnection())
                    {
                        connection.Open();

                        // Remove the appointment record after successful payment
                        string deleteQuery = "DELETE FROM Appointments WHERE CustomerId = @CustomerId AND DressId = @DressId";
                        using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection))
                        {
                            deleteCmd.Parameters.AddWithValue("@CustomerId", customerId);
                            deleteCmd.Parameters.AddWithValue("@DressId", dressId);

                            int rowsDeleted = deleteCmd.ExecuteNonQuery();

                            if (rowsDeleted > 0)
                            {
                                MessageBox.Show("Payment completed! Appointment record removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No matching appointment found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Backreturn_Click(object sender, EventArgs e)
        {
            Adminpage form = new Adminpage();
            form.Show();
            this.Close();
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
    
    

            
            
    

    

    



    