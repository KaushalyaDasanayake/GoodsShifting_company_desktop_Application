﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace E_shift_Management_System
{
    public partial class Login : Form
    {
        //DBconnection db = new DBconnection();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=E-shift_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from tbl_Login where Username='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //if (dt.Rows[0][0].ToString() == "1")
            //{
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                this.Hide();
                new CustomerView().Show();
            //}
            //else
             //   MessageBox.Show("Invalid username or password");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblLogInAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminLogin().Show();
        }

        private void picpassCheck_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                picpassHide.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void picpassHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                picpassCheck.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }
    }
           
}

