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
    public partial class Order_History : Form
    {
        public Order_History()
        {
            InitializeComponent();
            DatabindtoGridView();
        }

        private void DatabindtoGridView()
        {

            string sql = "select jobID ,uniqueID ,orderDate ,shipdate ,startLocation ,requestedLocation from Operations";
            dgvOrderHistory.DataSource = DBconnection.getdata(sql).Tables[0];
            dgvOrderHistory.Columns[0].HeaderText = "Job ID";
            dgvOrderHistory.Columns[1].HeaderText = "Unique ID";
            dgvOrderHistory.Columns[2].HeaderText = " Requested Date";
            dgvOrderHistory.Columns[3].HeaderText = "Order Date";
            dgvOrderHistory.Columns[3].DefaultCellStyle.Format = "  yyyy-MM-dd";
            dgvOrderHistory.Columns[4].HeaderText = "Ship Date";
            dgvOrderHistory.Columns[4].DefaultCellStyle.Format = "  yyyy-MM-dd";

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
                            dgvOrderHistory.DataSource = dt;
                            lblTotal.Text = $"Total records: {dgvOrderHistory.RowCount}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Clear Method
        private void ClearFields()
        {
            txtSearch.Text = "";
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
            ClearFields();
            DatabindtoGridView();
        }
    }
}
