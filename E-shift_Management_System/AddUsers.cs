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
    public partial class AddUsers : Form
    {
        public AddUsers()
        {
            InitializeComponent();
            LoadAddUser(); //load AddUser Form
        }

        public void LoadAddUser()
        {
           
        }

        private void picAddUserModule_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void AddUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_E_shift_Management_SystemDataSet3.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this._E_shift_Management_SystemDataSet3.User);

        }
    }
}
