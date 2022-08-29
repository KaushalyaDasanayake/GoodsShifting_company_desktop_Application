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
    public partial class TransportUnit : Form
    {
        public TransportUnit()
        {
            InitializeComponent();
        }

        private void TransportUnit_Load(object sender, EventArgs e)
        {
            DatabindtoGridView();
            DatabindtoGridViewVehicle();
        }

        private void DatabindtoGridView()
        {
            string sql = "select a.driverName,a.Address,a.contactNo,a.email from Driver a";
            dgvDriver.DataSource = DBconnection.getdata(sql).Tables[0];
            dgvDriver.Columns[0].HeaderText = "Driver Name";
            dgvDriver.Columns[1].HeaderText = "Address";
            dgvDriver.Columns[1].Width = 120;
            dgvDriver.Columns[2].HeaderText = "Contact No";
            dgvDriver.Columns[3].HeaderText = "E-mail";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";

            txtVehicleNo.Text = "";
            txtColor.Text = "";
            cmbVehicleType.SelectedValue = "";
            txtCWeight.Text = "";
        }

        private bool DataValid()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter Driver Name");
                return false;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Enter Address");
                return false;
            }
            if (!Information.IsNumeric(txtContact.Text))
            {
                MessageBox.Show("Please enter a numeric value");
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Enter Email");
                return false;
            }
            return true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DataValid())
            {
                Driver d = new Driver();
                d.driverName = txtName.Text;
                d.Address = txtAddress.Text;
                d.contactNo = txtContact.Text;
                d.email = txtEmail.Text;

                d.SaveDriver(d);  //Save the Driver record
                DatabindtoGridView();  //Update the gridview
                ClearFields();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = dgvDriver.SelectedRows[0].Index;
            // MessageBox.Show(index.ToString());

            if (DataValid())

            {
                Driver d = new Driver();
                d.driverName = txtName.Text;
                d.Address = txtAddress.Text;
                d.contactNo = txtContact.Text;
                d.email = txtEmail.Text;
                d.UpdateDriver(d);
                DatabindtoGridView();

                //Move the datagridview
                dgvDriver.Rows[index].Selected = true;
                dgvDriver.FirstDisplayedScrollingRowIndex = dgvDriver.SelectedRows[0].Index;
                dgvDriver.CurrentCell = dgvDriver[0, index];

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
                Driver d = new Driver();
                d.driverName = txtName.Text;
                d.DeleteDriver(d);
                DatabindtoGridView();

            }
        }

        private void DatabindtoGridViewVehicle()
        {
            string sql = "select a.vehicleNo,a.vehicleType,a.color,a.carryingWeight from Vehicle a";
            dgvVehicle.DataSource = DBconnection.getdata(sql).Tables[0];
            dgvVehicle.Columns[0].HeaderText = "Vehicle No";
            dgvVehicle.Columns[1].HeaderText = "Vehicle Type";
            dgvVehicle.Columns[1].Width = 120;
            dgvVehicle.Columns[2].HeaderText = "Color";
            dgvVehicle.Columns[3].HeaderText = "Carrying Weight";
        }

        private void btnVeNew_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private bool DataValidVehicle()
        {
            if (txtVehicleNo.Text == "")
            {
                MessageBox.Show("Enter Vehicle No");
                return false;
            }
            return true;
        }

        private void btnVeSave_Click(object sender, EventArgs e)
        {
            if (DataValidVehicle())
            {
                Vehicle ve = new Vehicle();
                ve.vehicleNo = txtName.Text;
                ve.vehicleType = cmbVehicleType.SelectedValue.ToString();
                ve.color = txtColor.Text;
                ve.carryingWeight = txtCWeight.Text;
                ve.SaveVehicle(ve);  //Save the Vehicle record
                DatabindtoGridViewVehicle();  //Update the gridview
                ClearFields();

            }
        }

        private void btnVeUpdate_Click(object sender, EventArgs e)
        {
            int index = dgvVehicle.SelectedRows[0].Index;
            // MessageBox.Show(index.ToString());

            if (DataValidVehicle())

            {
                Vehicle ve = new Vehicle();
                ve.vehicleNo = txtName.Text;
                ve.vehicleType = cmbVehicleType.SelectedValue.ToString();
                ve.color = txtColor.Text;
                ve.carryingWeight = txtCWeight.Text;
                ve.UpdateVehicle(ve);
                DatabindtoGridViewVehicle();

                //Move the datagridview
                dgvVehicle.Rows[index].Selected = true;
                dgvVehicle.FirstDisplayedScrollingRowIndex = dgvVehicle.SelectedRows[0].Index;
                dgvVehicle.CurrentCell = dgvVehicle[0, index];

                ClearFields();
            }
        }

        private void btnVeDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this record ??",
                                               "Confirm Delete!!",
                                               MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Vehicle ve = new Vehicle();
                ve.vehicleNo = txtName.Text;
                ve.DeleteVehicle(ve);
                DatabindtoGridViewVehicle();

            }
        }

        private void dgvVehicle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDriver_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDriver.SelectedRows)
            {
                txtName.Text = row.Cells["driverName"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtContact.Text = row.Cells["contactNo"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
            }
        }

        private void dgvVehicle_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvVehicle.SelectedRows)
            {
                txtVehicleNo.Text = row.Cells["vehicleNo"].Value.ToString();
                cmbVehicleType.Text = row.Cells["vehicleType"].Value.ToString();
                txtColor.Text = row.Cells["color"].Value.ToString();
                txtCWeight.Text = row.Cells["carryingWeight"].Value.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminView admin = new AdminView();
            admin.Show();
            this.Hide();
        }
    }
}
