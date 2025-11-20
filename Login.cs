using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace Project1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 welcomeForm = new Form1();
            welcomeForm.Show();
            this.Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string email = loginEmail.Text.Trim();
            string password = loginPassword.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Check for hardcoded admin credentials first
                if (email == "admin@example.com" && password == "admin123")
                {
                    // Hardcoded admin login successful
                    MessageBox.Show("Admin login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Adminpage adminDashboard = new Adminpage();
                    adminDashboard.Show();
                    this.Close();
                    return;
                }
                // Hash the entered password
                string hashedPassword = ComputeHash(password);

                // Use the DataBaseHelper to get the connection
                using (SqlConnection connection = DataBaseHelper.GetConnection())
                {
                    connection.Open();

                    // Check if the email exists and if the password matches
                    string query = "SELECT UserId, FirstName, LastName, Role, Password FROM Users WHERE Email = @Email";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();

                        // Compare the hashed password with the one stored in the database
                        string storedPassword = reader["Password"].ToString();
                        if (storedPassword == hashedPassword)
                        {
                            string role = reader["Role"].ToString();
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Redirect user based on their role
                            if (role == "Admin")
                            {
                                Adminpage adminDashboard = new Adminpage();
                                adminDashboard.Show();
                            }
                            
                            
                            else
                            {
                                customerdashboard userDashboard = new customerdashboard();
                                userDashboard.Show();
                            }

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email not found.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to hash passwords (consider using bcrypt in a real-world scenario)
        private string ComputeHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    

         
        }
    }

