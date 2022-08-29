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
    public partial class NewOrders : Form
    {
        public NewOrders()
        {
            InitializeComponent();
        }

        private void NewOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_E_shift_Management_SystemDataSet4.NewOrder' table. You can move, or remove it, as needed.
            this.newOrderTableAdapter.Fill(this._E_shift_Management_SystemDataSet4.NewOrder);

        }
    }
}
