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
    public partial class Operation : Form
    {
        public Operation()
        {
            InitializeComponent();
            DatabindtoGridView();
        }


        //pass data to datagridview 
        private void DatabindtoGridView()
        {

            string sql = "select jobID ,uniqueID ,orderDate ,shipdate ,startLocation ,requestedLocation from Operations";
            dgvOperation.DataSource = DBconnection.getdata(sql).Tables[0];
            dgvOperation.Columns[0].HeaderText = "Job ID";
            dgvOperation.Columns[1].HeaderText = "Unique ID";
            dgvOperation.Columns[2].HeaderText = " Requested Date";
            dgvOperation.Columns[3].HeaderText = "Order Date";
            //dateTimePicker1.Value.ToString("yyyy-MM-dd");
            dgvOperation.Columns[3].DefaultCellStyle.Format = "  yyyy-MM-dd";
            dgvOperation.Columns[4].HeaderText = "Ship Date";
            dgvOperation.Columns[4].DefaultCellStyle.Format = "  yyyy-MM-dd";
        }

        private void TextBosFilter()
        {
            string sql = "select * from Operations where jobID ='" + txtSearch + "'";
        }
        private void Operation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_E_shift_Management_SystemDataSet1.Operations' table. You can move, or remove it, as needed.
            this.operationsTableAdapter.Fill(this._E_shift_Management_SystemDataSet1.Operations);

        }


        private void dgvOperation_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvOperation.SelectedRows)
            {
                txtId.Text = row.Cells["jobID"].Value.ToString();
                txtCusID.Text = row.Cells["uniqueID"].Value.ToString();
                dtpOrderdate.Text = row.Cells["orderDate"].Value.ToString();
                dtpShipdate.Text = row.Cells["shipdate"].Value.ToString();
                txtStartlocation.Text = row.Cells["startLocation"].Value.ToString();
                txtEnd.Text = row.Cells["requestedLocation"].Value.ToString();
            }
        }

        //Add new Job
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearFields();//Data clear in textfields
        }

        //Clear Method
        private void ClearFields()
        {
            txtId.Text = "";
            txtCusID.Text = "";
            txtStartlocation.Text = "";
            txtEnd.Text = "";
            txtSearch.Text = "";
        }

        private bool DataValid()
        {
            if (txtStartlocation.Text == "")
            {
                MessageBox.Show("Enter Start Location");
                return false;
            }
            if (txtEnd.Text == "")
            {
                MessageBox.Show("Enter End Location");
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DataValid())
            {
                //Create object from sql data class
                Operations op = new Operations();
                op.jobID = Int32.Parse(txtId.Text);
                op.uniqueID = Int32.Parse(txtCusID.Text);
                //dateTimePicker1.Value.ToString("yyyy-MM-dd");
                op.orderDate = dtpOrderdate.Value.ToString("yyyy-MM-dd");
                op.shipdate = dtpShipdate.Value.ToString("yyyy-MM-dd");
                op.startLocation = txtStartlocation.Text;
                op.requestedLocation = txtEnd.Text;
                op.SaveOperation(op);  //Save the Operation record
                //Update the gridview
                MessageBox.Show("Customer has been successfully saved.");
                DatabindtoGridView();
                ClearFields();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = dgvOperation.SelectedRows[0].Index;
            // MessageBox.Show(index.ToString());

            if (DataValid())

            {
                //Create object from sql data class
                Operations op = new Operations();
                op.jobID = Convert.ToInt32(txtId.Text);
                op.uniqueID = Convert.ToInt32(txtCusID.Text);
                op.orderDate = dtpOrderdate.Value.ToString("yyyy-MM-dd");
                op.shipdate = dtpShipdate.Value.ToString("yyyy-MM-dd");
                op.startLocation = txtStartlocation.Text;
                op.requestedLocation = txtEnd.Text;
                op.UpdateOperation(op);
                DatabindtoGridView();

                dgvOperation.Rows[index].Selected = true;
                dgvOperation.FirstDisplayedScrollingRowIndex = dgvOperation.SelectedRows[0].Index;
                dgvOperation.CurrentCell = dgvOperation[0, index];

                ClearFields();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this record ??",
                                  "Confirm Delete!!",
                                  MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                //Create object from sql data class
                Operations op = new Operations();
                op.uniqueID = Convert.ToInt32(txtId.Text);
                op.DeleteOperation(op);
                DatabindtoGridView();

            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //OperationReport frm = new OperationReport(Convert.ToDecimal(txtReport.Text));
            //frm.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cs = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString))
                {
                    if (cs.State == ConnectionState.Closed)
                        cs.Open();
                    using (DataTable dt = new DataTable("Operations"))
                    {
                        using (SqlCommand cmd = new SqlCommand("select * from Operations where jobID =@jobID or uniqueID like @uniqueID", cs))
                        {
                            cmd.Parameters.AddWithValue("jobID", txtSearch.Text);
                            cmd.Parameters.AddWithValue("uniqueID", txtSearch.Text);
                            SqlDataAdapter ad = new SqlDataAdapter(cmd);
                            ad.Fill(dt);
                            dgvOperation.DataSource = dt;
                            lblTotal.Text = $"Total records: {dgvOperation.RowCount}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//Enter
                btnSearch.PerformClick();
        }
    
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
            ClearFields();
            DatabindtoGridView();
        }

        private void lblOrderDetails_Click(object sender, EventArgs e)
        {
            Order orderform = new Order();
            orderform.Show();
            this.Hide();
        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            OperationReport report = new OperationReport();
            report.Show();
            this.Hide();
        }
    }
}
