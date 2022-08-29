using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Configuration;
using System.Data.SqlClient;

namespace E_shift_Management_System
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
            DatabindtoGridView();
            DataBindtoCombobox();
        }

        private void DatabindtoGridView()
        {

            string sql = "select a.detailID,a.jobID,b.productName,a.quantity,a.unitPrice,a.discount,a.packingtype,a.loadID from OrderDetails a," +
                "Product b where a.productID=b.productID order by a.detailID";
            dgvOrderDetails.DataSource = DBconnection.getdata(sql).Tables[0];
            dgvOrderDetails.Columns[0].HeaderText = "Details ID";
            dgvOrderDetails.Columns[0].Width = 50;
            dgvOrderDetails.Columns[1].Width = 50;
            dgvOrderDetails.Columns[2].HeaderText = "Product Name";
            dgvOrderDetails.Columns["unitPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvOrderDetails.Columns["discount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        //Databind in Product Combobox
        private void DataBindtoCombobox()
        {
            cmdProType.DisplayMember = "productName";
            cmdProType.ValueMember = "productID";
            string sql = "Select * from Product;";
            cmdProType.DataSource = DBconnection.getdata(sql).Tables[0]; //Execyte method
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cs = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString))
                {
                    if (cs.State == ConnectionState.Closed)
                        cs.Open();
                    using (DataTable dt = new DataTable("OrderDetails"))
                    {
                        using (SqlCommand cmd = new SqlCommand("select * from OrderDetails where detailID=@detailID or jobID like @jobID", cs))
                        {
                            cmd.Parameters.AddWithValue("detailID", txtSearch.Text);
                            cmd.Parameters.AddWithValue("jobID", txtSearch.Text);
                            SqlDataAdapter ad = new SqlDataAdapter(cmd);
                            ad.Fill(dt);
                            dgvOrderDetails.DataSource = dt;
                            lblTotal.Text = $"Total records: {dgvOrderDetails.RowCount}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
            ClearFields();
            DatabindtoGridView();
        }

        //Clear Method
        private void ClearFields()
        {
            txtID.Text = "";
            txtJobID.Text = "";
            txtPacktype.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtDiscount.Text = "";
            txtLoadID.Text = "";
            txtSearch.Text = "";
        }

        //Add new Order details and Clear textfiealds
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearFields();//Data clear in textfields
        }

        private void dgvOrderDetails_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvOrderDetails.SelectedRows)
            {
                txtID.Text = row.Cells["detailID"].Value.ToString();
                txtJobID.Text = row.Cells["jobID"].Value.ToString();
                cmdProType.Text = row.Cells["productName"].Value.ToString();
                txtQuantity.Text = row.Cells["quantity"].Value.ToString();
                txtPrice.Text = row.Cells["unitPrice"].Value.ToString();
                txtDiscount.Text = row.Cells["discount"].Value.ToString();
                txtPacktype.Text = row.Cells["packingtype"].Value.ToString();
                txtLoadID.Text = row.Cells["loadID"].Value.ToString();
            }
        }

        private bool DataValid()
        {
            //text field validate
            if (txtJobID.Text == "")
            {
                MessageBox.Show("Enter Job ID");
                return false;
            }
            if (txtLoadID.Text == "")
            {
                MessageBox.Show("Enter Load ID");
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DataValid())
            {
                OrderDetails order = new OrderDetails();
                order.detailID = Convert.ToInt32(txtID.Text);
                order.jobID = Convert.ToInt32(txtJobID.Text);
                order.productID = cmdProType.SelectedValue.ToString();
                order.quantity = Convert.ToInt32(txtQuantity.Text);
                order.unitPrice = Convert.ToDecimal(txtPrice.Text);
                order.discount = Convert.ToDecimal(txtDiscount.Text);
                order.loadID = Convert.ToInt32(txtLoadID.Text);
                order.SaveOrder(order);  //Save the Operation record
                //Update the gridview
                MessageBox.Show("Order has been successfully saved.");
                DatabindtoGridView();
                ClearFields();

            }
        }

        private void cmdProType_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this record ??",
                                   "Confirm Delete!!",
                                   MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                OrderDetails order = new OrderDetails();
                order.detailID = Convert.ToInt32(txtID.Text);
                order.DeleteOrder(order);
                DatabindtoGridView();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = dgvOrderDetails.SelectedRows[0].Index;
            // MessageBox.Show(index.ToString());

            if (DataValid())

            {
                OrderDetails order = new OrderDetails();
                order.detailID = Convert.ToInt32(txtID.Text);
                order.jobID = Convert.ToInt32(txtJobID.Text);
                order.productID = cmdProType.SelectedValue.ToString();
                order.quantity = Convert.ToInt32(txtQuantity.Text);
                order.unitPrice = Convert.ToDecimal(txtPrice.Text);
                order.discount = Convert.ToDecimal(txtDiscount.Text);
                order.loadID = Convert.ToInt32(txtLoadID.Text);
                order.UpdateOrder(order);
                DatabindtoGridView();

                dgvOrderDetails.Rows[index].Selected = true;
                dgvOrderDetails.FirstDisplayedScrollingRowIndex = dgvOrderDetails.SelectedRows[0].Index;
                dgvOrderDetails.CurrentCell = dgvOrderDetails[0, index];

                ClearFields();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

