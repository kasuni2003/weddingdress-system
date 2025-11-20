using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Form1 welcomeForm = new Form1();
            welcomeForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = firstname.Text.Trim();
            string lastName = lastname.Text.Trim();
            string userid = user_id.Text.Trim();
            string Email = email.Text.Trim();
            string Address = address.Text.Trim();
            string homeTown = hometown.Text.Trim();
            string contactNo = contactnumber.Text.Trim();
            string Password = password.Text.Trim();
            string confirmPassword = cpassword.Text.Trim();
            string role = "User"; // Default role is 'User'

            // Validate inputs
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Address) ||
                string.IsNullOrEmpty(homeTown) || string.IsNullOrEmpty(contactNo) ||
                string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Hash the password for security
                string hashedPassword = ComputeHash(Password);

                // Use the DataBaseHelper to get the connection
                using (SqlConnection connection = DataBaseHelper.GetConnection())
                {
                    connection.Open();

                    // Check if email already exists
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@Email", Email);

                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Email already registered. Use another email.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Insert new user
                    string insertQuery = @"
            INSERT INTO Users (UserId,FirstName, LastName, Email, Address, HomeTown, ContactNumber, Password, Role)
            VALUES (@UserId,@FirstName, @LastName, @Email, @Address, @HomeTown, @ContactNumber, @Password, @Role)";
                    SqlCommand command = new SqlCommand(insertQuery, connection);

                    // Add parameters
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@UserId", userid);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@HomeTown", homeTown);
                    command.Parameters.AddWithValue("@ContactNumber", contactNo);
                    command.Parameters.AddWithValue("@Password", hashedPassword);
                    command.Parameters.AddWithValue("@Role", role);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to clear fields
        private void ClearFields()
        {
            firstname.Clear();
            lastname.Clear();
            user_id.Clear();
            email.Clear();
           address.Clear();
            hometown.Clear();
            contactnumber.Clear();
            password.Clear();
            cpassword.Clear();
        }

        // Helper method to hash passwords
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

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void backregister_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
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
