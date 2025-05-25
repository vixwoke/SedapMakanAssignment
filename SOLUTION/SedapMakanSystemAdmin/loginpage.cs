using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SedapMakanSystemAdmin
{
    public partial class loginpage: Form
    {
        public loginpage()
        {
            InitializeComponent();
        }


        private void loginpage_Load(object sender, EventArgs e)
        {
            string version = "Unknown";
            try
            {
                string versionPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "version.txt");
                if (File.Exists(versionPath))
                {
                    version = File.ReadAllText(versionPath).Trim();
                }
            }
            catch (Exception)
            {
                version = "Error reading version";
            }

            lblVersionControl.Text = $"Version: {version}";
        }

        private void lblVersionControl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
