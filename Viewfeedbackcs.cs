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
    public partial class Viewfeedbackcs : Form
    {
        public Viewfeedbackcs()
        {
            InitializeComponent();
            LoadFeedbackData();
        }

        private void LoadFeedbackData()
        {
            try
            {
                using (SqlConnection connection = DataBaseHelper.GetConnection()) // Ensure you have a GetConnection() method
                {
                    connection.Open();

                    string query = "SELECT FeedbackID, CustomerName, OverallSatisfaction, DressFit, FabricQuality, " +
                                   "ColorMatch, FitSatisfaction, ServiceRating, RecommendToOthers, Comments FROM feedback";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable feedbackTable = new DataTable();
                        adapter.Fill(feedbackTable);

                        feedbackGridView.DataSource = feedbackTable; // Bind to DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading feedback data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    


private void feedbackGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backviewfeedback_Click(object sender, EventArgs e)
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
