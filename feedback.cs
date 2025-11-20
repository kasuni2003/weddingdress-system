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
    public partial class feedback : Form
    {
        public feedback()
        {
            InitializeComponent();
        }
        //submit button-------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            // Get data from form
            string customerName = name.Text;
            int overallSatisfaction = (int)trackBar1.Value;
            int dressFit = (int)trackBar2.Value;
            int fabricQuality = (int)trackBar3.Value;
            int colorMatch = (int)trackBar4.Value;
            int fitSatisfaction = (int)trackBar5.Value; 
            int serviceRating = (int)trackBar6.Value;
            bool recommendToOthers = radioButton1.Checked;
            string comments = suggestion.Text;

            using (SqlConnection connection = DataBaseHelper.GetConnection()) // Use centralized database helper
            {
                try
                {
                    connection.Open(); // Open the connection
                    string query = "INSERT INTO Feedback " +
                                   "(CustomerName, OverallSatisfaction, DressFit, FabricQuality, ColorMatch, FitSatisfaction, ServiceRating, RecommendToOthers, Comments) " +
                                   "VALUES (@CustomerName, @OverallSatisfaction, @DressFit, @FabricQuality, @ColorMatch, @FitSatisfaction, @ServiceRating, @RecommendToOthers, @Comments)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@CustomerName", customerName);
                        command.Parameters.AddWithValue("@OverallSatisfaction", overallSatisfaction);
                        command.Parameters.AddWithValue("@DressFit", dressFit);
                        command.Parameters.AddWithValue("@FabricQuality", fabricQuality);
                        command.Parameters.AddWithValue("@ColorMatch", colorMatch);
                        command.Parameters.AddWithValue("@FitSatisfaction", fitSatisfaction);
                        command.Parameters.AddWithValue("@ServiceRating", serviceRating);
                        command.Parameters.AddWithValue("@RecommendToOthers", recommendToOthers);
                        command.Parameters.AddWithValue("@Comments", comments);

                        // Execute the query
                        command.ExecuteNonQuery();

                        // Feedback message
                        MessageBox.Show("Feedback submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            customerdashboard form = new customerdashboard();
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

