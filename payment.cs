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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project1
{
    public partial class payment : Form
    {

        private int _rentalPeriod;
        private decimal _dressPrice;
        private decimal _totalAmount;
        private Form previousForm;




        public payment(int rentalPeriod, decimal dressPrice, Form previous)
        {
            InitializeComponent();
            this.Load += new EventHandler(payment_Load);


            _rentalPeriod = rentalPeriod;
            _dressPrice = dressPrice;
            previousForm = previous;



            CalculateTotalAmount();
            DisplayValues();
        }

        private void CalculateTotalAmount()
        {
            decimal rentalFeePerDay = 10m;
            _totalAmount = _dressPrice + (_rentalPeriod * rentalFeePerDay);
        }

        private void DisplayValues()
        {
            textBox1.Text = $"Rental Period: {_rentalPeriod} days";
            textBox2.Text = $"Dress Price: ${_dressPrice}";
            textBox3.Text = $"Total Amount: ${_totalAmount}";

            // Add payment status options
            comboBox1.Items.Add("Complete");
            comboBox1.Items.Add("Pending");
            comboBox1.SelectedIndex = 0; // Default to "Complete"
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    if (!decimal.TryParse(textBox4.Text, out decimal payedAmount))
                    {
                        MessageBox.Show("Invalid payment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!decimal.TryParse(remaingamount.Text, out decimal remainingAmount))
                    {
                        MessageBox.Show("Invalid remaining amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string customerId = telephonenumber.Text;
                    if (string.IsNullOrEmpty(customerId))
                    {
                        MessageBox.Show("Please enter a valid customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string paymentStatus = comboBox1.SelectedItem.ToString();

                    using (SqlConnection connection = DataBaseHelper.GetConnection())
                    {
                        connection.Open();

                        string query = @"
                    UPDATE Appointments 
                    SET 
                        Payedamount = @Payedamount, 
                        Remaingamount = @Remaingamount, 
                        Paymentstatus = @Paymentstatus,
                        Finalprice = @Finalprice
                    WHERE CustomerId = @CustomerId ";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Payedamount", payedAmount);
                        command.Parameters.AddWithValue("@Remaingamount", remainingAmount);
                        command.Parameters.AddWithValue("Paymentstatus", paymentStatus);
                        command.Parameters.AddWithValue("@Finalprice", _totalAmount);
                        command.Parameters.AddWithValue("@CustomerId", customerId);
                       

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Payment details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No matching record found. Please check Customer ID and Dress ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
                   catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (previousForm != null)
            {
                previousForm.Show();  // Show the previous form
                this.Close();  // Close the current form
            }
        }
    

        private void button3_Click(object sender, EventArgs e)
        {
            Adminpage form = new Adminpage();
            form.Show(); // Show the Payment Form
            this.Hide(); // Hide the current form (optional)
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Complete")
            {
                textBox4.Text = _totalAmount.ToString("0.00"); // Full amount paid
                remaingamount.Text = "0.00"; // No remaining balance
                textBox4.ReadOnly = true;
            }
            else
            {
                textBox4.Text = ""; // User needs to enter amount
                remaingamount.Text = _totalAmount.ToString("0.00"); // Show full remaining amount
                textBox4.ReadOnly = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox4.Text, out decimal payedAmount))
            {
                decimal remaining = _totalAmount - payedAmount;
                remaingamount.Text = remaining.ToString("0.00");

                if (remaining == 0)
                {
                    comboBox1.SelectedItem = "Complete";
                }
                else
                {
                    comboBox1.SelectedItem = "Pending";
                }
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

        private void LoadDataIntoGrid()
        {
            try
            {
                using (SqlConnection connection = DataBaseHelper.GetConnection()) // Use your DB connection
                {
                    connection.Open();
                    string query = @"
                SELECT 
                    DressId, 
                    CustomerId, 
                    Finalprice, 
                    RentalPeriod, 
                    Payedamount, 
                    Remaingamount, 
                    Paymentstatus 
                FROM Appointments"; // Select only the required fields

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt; // Bind data to DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void payment_Load(object sender, EventArgs e)
        {
            LoadDataIntoGrid();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
    }
