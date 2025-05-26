using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SedapMakanSystemAdmin
{
    public partial class adminHome: Form
    {
        public adminHome()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            manage_user manageForm = new manage_user();
            manageForm.Show();    // Show the new form
            this.Hide();          // Hide the current form (Form1)
        }

        private void button3_Click(object sender, EventArgs e)
        {

           
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void adminHome_Load(object sender, EventArgs e)
        {
            cbboxShowReportFor.SelectedIndex = 0;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnMenuSlider_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult exitDialog =
                MessageBox.Show("Are you sure you want to logout?",
                "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(exitDialog == DialogResult.OK)
            {
                var loginForm = new loginpage();
                loginForm.Show();
                this.Close();
            }
            else
            {
            }
        }
    }
}
