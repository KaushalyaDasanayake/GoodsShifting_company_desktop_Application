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

namespace E_shift_Management_System
{
    public partial class TransportDetails : Form
    {
        public TransportDetails()
        {
            InitializeComponent();
        }

        private void TransportDetails_Load(object sender, EventArgs e)
        {
            DatabindtoGridView();
        }

        private void DatabindtoGridView()
        {
            string sql = "select a.loadID,a.vehicleNo,a.driverID,a.containerID,a.date,a.description from Load a";
            dgvLoad.DataSource = DBconnection.getdata(sql).Tables[0];
            dgvLoad.Columns[0].HeaderText = "Load ID";
            dgvLoad.Columns[1].HeaderText = "vehicle No";
            dgvLoad.Columns[2].HeaderText = "Driver ID";
            dgvLoad.Columns[3].HeaderText = "Container ID";
            dgvLoad.Columns[4].HeaderText = "Date";
            dgvLoad.Columns[4].DefaultCellStyle.Format = " yyyy-MM-dd";
            dgvLoad.Columns[5].HeaderText = "Description";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtLoadID.Text = "";
            txtDescription.Text = "";
        }

        private bool DataValid()
        {
            if (txtLoadID.Text == "")
            {
                MessageBox.Show("Enter LoadID");
                return false;
            }
            if (txtJobID.Text == "")
            {
                MessageBox.Show("Enter Job ID");
                return false;
            }
            if (txtVehicleNo.Text == "")
            {
                MessageBox.Show("Enter vehicle No");
                return false;
            }
            if (txtContainerID.Text == "")
            {
                MessageBox.Show("Enter Container ID");
                return false;
            }
            if (txtDescription.Text == "")
            {
                MessageBox.Show("Enter Description");
                return false;
            }
            return true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DataValid())
            {
                Load load = new Load();
                load.loadID = Convert.ToInt32(txtLoadID.Text);
                load.vehicleNo = txtVehicleNo.Text;
                load.driverID = Convert.ToInt32(txtDriverID.Text);
                load.containerID = Convert.ToInt32(txtContainerID.Text);
                load.jobID = Convert.ToInt32(txtJobID.Text);
                //dateTimePicker1.Value.ToString("yyyy-MM-dd");
                load.date = dtpDate.Value.ToString("yyyy-MM-dd");
                load.description = txtDescription.Text;
                load.SaveLoad(load);  //Save the employee record
                DatabindtoGridView();  //Update the gridview
                ClearFields();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = dgvLoad.SelectedRows[0].Index;
            // MessageBox.Show(index.ToString());

            if (DataValid())

            {
                Load load = new Load();
                load.loadID = Convert.ToInt32(txtLoadID.Text);
                load.vehicleNo = txtVehicleNo.Text;
                load.driverID = Convert.ToInt32(txtDriverID.Text);
                load.containerID = Convert.ToInt32(txtContainerID.Text);
                load.jobID = Convert.ToInt32(txtJobID.Text);
                //dateTimePicker1.Value.ToString("yyyy-MM-dd");
                load.date = dtpDate.Value.ToString("yyyy-MM-dd");
                load.description = txtDescription.Text;
                load.UpdateLoad(load);
                DatabindtoGridView();

                //Move the datagridview
                dgvLoad.Rows[index].Selected = true;
                dgvLoad.FirstDisplayedScrollingRowIndex = dgvLoad.SelectedRows[0].Index;
                dgvLoad.CurrentCell = dgvLoad[0, index];

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
                Load load = new Load();
                load.loadID = Convert.ToInt32(txtLoadID.Text);
                load.DeleteLoad(load);
                DatabindtoGridView();

            }
        }
    }
}
