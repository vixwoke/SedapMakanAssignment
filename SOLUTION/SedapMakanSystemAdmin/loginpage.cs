﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SedapMakanSystemAdmin
{
    public partial class loginpage: Form
    {
        public loginpage()
        {
            InitializeComponent();

        }
        SqlConnection connection = new SqlConnection(@"Data Source=VIXWOKE\SQLEXPRESS;Initial Catalog=ioop_assignment;Integrated Security=True");


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

                try
                {
                    String query = "SELECT * FROM [user].userLoginInfo WHERE userUsername = '" + username + "' AND userPassword = '" + password + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                    DataTable dttbl = new DataTable();
                    sda.Fill(dttbl);
                    if (dttbl.Rows.Count > 0)
                    {
                        var admForm = new adminHome();
                        admForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Developer Error: " + ex.Message + "\nPlease contact Gilang ASAP.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void txtUsername_LostFocus(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                lblRequiredUsername.Visible = true;
            }
            else
            {
                string usernameUpperCasing = txtUsername.Text.ToUpper();
                txtUsername.Text = usernameUpperCasing;
                lblRequiredUsername.Visible = false;
            }
        }

        private void txtPassword_LostFocus(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                lblRequiredPassword.Visible = true;
            }
            else
            {
                lblRequiredPassword.Visible = false;
            }
        }

        private void loginpage_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                btnLogin.PerformClick();
            }
        }
    }
}
