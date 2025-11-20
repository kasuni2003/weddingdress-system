using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open the Register Form
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide(); // Hide the current form (optional)
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            // Open the Login Form
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide(); // Hide the current form (optional)

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Browsepage BrowseForm = new Browsepage();
            BrowseForm.Show();
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
