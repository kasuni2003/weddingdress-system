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
    public partial class Adminpage : Form
    {
        public Adminpage()
        {
            InitializeComponent();
        }

        private void Manege_closet_Click(object sender, EventArgs e)
        {
            Manegecloset closetForm = new Manegecloset();
            closetForm.Show();
            this.Hide(); // Hide the current form (optional)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 closetForm = new Form1();
            closetForm.Show();
            this.Hide(); // Hide the current form (optional)
        }

        //manage appointment button------------------------------------------
        private void button4_Click(object sender, EventArgs e)
        {
            Manegeappointments closetForm = new Manegeappointments();
            closetForm.Show();
            this.Hide();
        }

        private void recivedapp_Click(object sender, EventArgs e)
        {
            Recieveddress closetForm = new Recieveddress();
            closetForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Viewfeedbackcs closetForm = new Viewfeedbackcs();
            closetForm.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();  // Close the form if "Yes" is clicked
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Viewoverduereturns Form = new Viewoverduereturns();
            Form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Displaydress Form = new Displaydress();
            Form.Show();
            this.Hide();
        }
    }
}
