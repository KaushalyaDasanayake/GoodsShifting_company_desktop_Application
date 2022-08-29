using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace E_shift_Management_System
{
    public partial class Ordering : Form
    {
        public Ordering()
        {
            InitializeComponent();
        }

        private bool DataValid()
        {
            if (txtUniqueID.Text == "")
            {
                MessageBox.Show("Enter Customer ID");
                return false;
            }
            if (txtProducts.Text == "")
            {
                MessageBox.Show("Enter Products");
                return false;
            }
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Enter Order quantity");
                return false;
            }
            if (txtFrom.Text == "")
            {
                MessageBox.Show("Enter current Location");
                return false;
            }
            if (txtTo.Text == "")
            {
                MessageBox.Show("Enter Requested Location");
                return false;
            }
            if (dtpDue.Text == "")
            {
                MessageBox.Show("Enter Due Date");
                return false;
            }

            return true;
        }

        public void ClearFields()
        {
            txtUniqueID.Text = "";
            txtProducts.Text = "";
            txtQuantity.Text = "";
            txtWeight.Text = "";
            txtFrom.Text = "";
            txtTo.Text = "";
            txtDiscription.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (DataValid())
            {
                NewOrder order = new NewOrder();
                order.UniqueID = Int32.Parse(txtUniqueID.Text);
                order.productName = txtProducts.Text;
                order.quantity = Int32.Parse(txtQuantity.Text);
                order.weight = txtWeight.Text;
                order.fromWhere = txtFrom.Text;
                order.toWhere = txtTo.Text;
                //dateTimePicker1.Value.ToString("yyyy-MM-dd");
                order.dueDate = dtpDue.Value.ToString("yyyy-MM-dd");
                order.discription = txtDiscription.Text;
                order.SubmitOrder(order);  //Save the newOrder record
                //Update the gridview
                MessageBox.Show("Order has been successfully saved.");
                ClearFields();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CustomerView cus = new CustomerView();
            cus.Show();
            this.Hide();
        }
    }
}
