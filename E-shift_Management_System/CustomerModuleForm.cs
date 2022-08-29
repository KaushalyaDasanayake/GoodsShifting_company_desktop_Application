using System;
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
    public partial class CustomerModuleForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=E-shift_Management_System;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public CustomerModuleForm()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Save Data
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You sure you want to save this Customer?","Saving Record",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO tbl_Customer(uniqueID,cusFirstName,cusLastName,contactNo,address,password)VALUES(@uniqueID,@cusFirstName,@cusLastName,@contactNo,@address,@password)", con);
                    cmd.Parameters.AddWithValue("@uniqueID", txtId.Text);
                    cmd.Parameters.AddWithValue("@cusFirstName", txtFname.Text);
                    cmd.Parameters.AddWithValue("@cusLastName", txtLname.Text);
                    cmd.Parameters.AddWithValue("@contactNo", txtContact.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@password", txtPass.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer has been successfully saved.");
                    Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //Clear Data
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Clear();  //click clear button and clear all textbox details
        }

        //The form is cleared here
        public void Clear()
        {
            txtId.Clear();
            txtFname.Clear();
            txtLname.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtPass.Clear();
        }

        //Update Data
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You sure you want to update this Customer?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE tbl_Customer SET cusFirstName=@cusFirstName,cusLastName=@cusLastName,contactNo=@contactNo,address=@address,password=@password WHERE uniqueID LIKE '"+txtId.Text+"'", con);
                    cmd.Parameters.AddWithValue("@cusFirstName", txtFname.Text);
                    cmd.Parameters.AddWithValue("@cusLastName", txtLname.Text);
                    cmd.Parameters.AddWithValue("@contactNo", txtContact.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@password", txtPass.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer has been successfully updated.");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
