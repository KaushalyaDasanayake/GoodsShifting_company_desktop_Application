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
    public partial class AddCustomers : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=E-shift_Management_System;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter adpt;
        public AddCustomers()
        {
            InitializeComponent();
            LoadAddCustomer(); //load AddCustomer Form
        }
        
        //Load Data
        public void LoadAddCustomer()
        {
           dgvCustomer.Rows.Clear();
           cmd = new SqlCommand("SELECT * FROM tbl_Customer", con); //Select Customer table in database
           con.Open(); //Open Connection
           dr = cmd.ExecuteReader();
            while (dr.Read()) // View data in Customer DataGridView 
            {
                dgvCustomer.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();

        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCustomer.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CustomerModuleForm cusModule = new CustomerModuleForm();
                cusModule.txtId.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                cusModule.txtFname.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                cusModule.txtLname.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                cusModule.txtContact.Text = dgvCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
                cusModule.txtAddress.Text = dgvCustomer.Rows[e.RowIndex].Cells[5].Value.ToString();
                cusModule.txtPass.Text = dgvCustomer.Rows[e.RowIndex].Cells[6].Value.ToString();

                cusModule.btnSave.Enabled = false;
                cusModule.btnUpdate.Enabled = true;
                cusModule.txtId.Enabled = false;
                cusModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this customer?", "Delete record.", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes) ;
                {
                    con.Open();
                    cmd = new SqlCommand("Delete FROM tbl_Customer WHERE uniqueID LIKE '"+dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString()+"'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted.");
                }
            }
            LoadAddCustomer();
        }

        private void pictureBoxAddCustomers_Click(object sender, EventArgs e)
        {
            CustomerModuleForm cusform = new CustomerModuleForm();
            cusform.ShowDialog();
        }

        private void picAddCustomerModule_Click(object sender, EventArgs e)
        {
            CustomerModuleForm cusform = new CustomerModuleForm();
            cusform.Show();
            this.Hide();
        }
    }
}
