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
    public partial class customerdashboard : Form
    {
        public customerdashboard()
        {
            InitializeComponent();
        }

        private void Browse_btn_Click(object sender, EventArgs e)
        {
            Browsepage browsepage = new Browsepage();
            browsepage.Show();
            this.Close();
        }

        private void about_btn_Click(object sender, EventArgs e)
        {

        }

        private void feedback_btn_Click(object sender, EventArgs e)
        {
            feedback feedbackform = new feedback();
            feedbackform.Show();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
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
