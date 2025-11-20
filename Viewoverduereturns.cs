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
    public partial class Viewoverduereturns : Form
    {
        public Viewoverduereturns()
        {
            InitializeComponent();
            this.Shown += new EventHandler(Viewoverduereturns_Shown);
        }

        private void Viewoverduereturns_Shown(object sender, EventArgs e)
        {
            LoadOverdueAppointments(); // Load data AFTER the form is shown
        }

        private void LoadOverdueAppointments()
        {

            try
            {
                using (SqlConnection connection = DataBaseHelper.GetConnection())
                {
                    connection.Open();
                    string query = @"SELECT AppointmentId, DressId, CustomerName, CustomerId, ReturnDate, Paymentstatus 
                             FROM Appointments 
                             WHERE ReturnDate < @currentDate";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@currentDate", DateTime.Now);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Ensure UI update happens only if form handle exists
                        if (this.IsHandleCreated)
                        {
                            dataGridViewOverdue.Invoke((MethodInvoker)delegate
                            {
                                dataGridViewOverdue.DataSource = dt;
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void back_Click(object sender, EventArgs e)
        {
            Adminpage form = new Adminpage();
            form.Show();
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOverdueAppointments(); 
        }

        private void dataGridViewOverdue_VisibleChanged(object sender, EventArgs e)
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

    

