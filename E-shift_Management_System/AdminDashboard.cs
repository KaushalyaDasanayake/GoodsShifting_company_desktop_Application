using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_shift_Management_System
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            AdminView admin = new AdminView();
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnTransportUnit_Click(object sender, EventArgs e)
        {
            TransportUnit trns = new TransportUnit();
            trns.Show();
        }
    }
}
