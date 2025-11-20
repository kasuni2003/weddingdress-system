using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Generateinvoice : Form

    {

        private PrintDocument printDocument;

        private int customerId;
        private string customerName;
        private int dressId;
        private decimal rentalFee;
        private decimal lateFine;
        private decimal totalAmount;
        public Generateinvoice()
        {
            InitializeComponent();

            printDocument = new PrintDocument();
            // Attach the PrintPage event
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Get the graphics object
            Graphics graphics = e.Graphics;

            // Define the font and brush for printing
            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 10);
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);
            Brush brush = Brushes.Black;

            // Define margins and starting position
            float leftMargin = 40;
            float topMargin = 40;
            float lineHeight = bodyFont.GetHeight(graphics) + 2; // Line height based on font size

            float x = leftMargin;
            float y = topMargin;

            // Title/Header
            graphics.DrawString("==== INVOICE ====", headerFont, brush, x, y);
            y += lineHeight * 2; // Add extra space after the title

            // Customer information
            graphics.DrawString($"Customer ID: {customerId}", bodyFont, brush, x, y);
            y += lineHeight;
            graphics.DrawString($"Customer Name: {customerName}", bodyFont, brush, x, y);
            y += lineHeight;
            graphics.DrawString($"Dress ID: {dressId}", bodyFont, brush, x, y);
            y += lineHeight;

            // Rental Fee, Late Fine, and Total Amount
            graphics.DrawString("---- Charges ----", boldFont, brush, x, y);
            y += lineHeight;
            graphics.DrawString($"Rental Fee: {rentalFee:C}", bodyFont, brush, x, y);
            y += lineHeight;
            graphics.DrawString($"Late Fine: {lateFine:C}", bodyFont, brush, x, y);
            y += lineHeight;
            graphics.DrawString($"Total Amount: {totalAmount:C}", bodyFont, brush, x, y);
            y += lineHeight;

            // Date of invoice
            graphics.DrawString($"Date: {DateTime.Now}", bodyFont, brush, x, y);
            y += lineHeight * 2; // Extra space after the date

            // Footer (Optional)
            string footerText = "Thank you for your business!";
            graphics.DrawString(footerText, bodyFont, brush, x, y);

            // Indicate that the print job is done
            e.HasMorePages = false;
        }



        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate Customer ID Input
                if (!int.TryParse(txtCustomerID.Text, out int customerId))
                {
                    MessageBox.Show("Please enter a valid Customer ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connection = DataBaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
            SELECT A.CustomerID, A.CustomerName, A.DressID, A.RentalFee, R.LateFine
            FROM Appointments A
            LEFT JOIN Returndress R ON A.DressID = R.DressID
            WHERE A.CustomerID = @CustomerID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Handling DBNull values correctly
                                string customerName = reader["CustomerName"] != DBNull.Value ? reader["CustomerName"].ToString() : "Unknown";
                                int dressId = reader["DressID"] != DBNull.Value ? Convert.ToInt32(reader["DressID"]) : 0;
                                decimal rentalFee = reader["RentalFee"] != DBNull.Value ? Convert.ToDecimal(reader["RentalFee"]) : 0;
                                decimal lateFine = reader["LateFine"] != DBNull.Value ? Convert.ToDecimal(reader["LateFine"]) : 0;

                                decimal totalAmount = rentalFee + lateFine;

                                // Display Invoice
                                invoiceTextBox.Text = "==== INVOICE ====\n";
                                invoiceTextBox.Text += $"Customer ID: {customerId}\n";
                                invoiceTextBox.Text += $"Customer Name: {customerName}\n";
                                invoiceTextBox.Text += $"Dress ID: {dressId}\n";
                                invoiceTextBox.Text += $"Rental Fee: {rentalFee:C}\n";
                                invoiceTextBox.Text += $"Late Fine: {lateFine:C}\n";
                                invoiceTextBox.Text += $"Total Amount: {totalAmount:C}\n";
                                invoiceTextBox.Text += $"Date: {DateTime.Now}\n";

                                // Save Invoice to Database
                                SaveInvoiceToDatabase(customerId, customerName, dressId, rentalFee, lateFine, totalAmount);
                            }
                            else
                            {
                                MessageBox.Show("No records found for this Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void SaveInvoiceToDatabase(int customerId, string customerName, int dressId, decimal rentalFee, decimal lateFine, decimal totalAmount)
                {
                    // Implement the logic to save the invoice to the database
                    MessageBox.Show("Invoice saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                private void btnPrintInvoice_Click(object sender, EventArgs e)
                {
                    try
                    {
                        // Show the PrintDialog to select the printer
                        PrintDialog printDialog = new PrintDialog();
                        printDialog.Document = printDocument;

                        // If the user clicks OK to print, proceed with printing
                        if (printDialog.ShowDialog() == DialogResult.OK)
                        {
                            printDocument.Print();  // Start the print process
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error while printing: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

        private void backinvoice_Click(object sender, EventArgs e)
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





