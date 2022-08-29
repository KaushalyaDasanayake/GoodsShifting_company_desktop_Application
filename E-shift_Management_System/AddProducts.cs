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
    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
        }

        private void AddProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_E_shift_Management_SystemDataSet2.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this._E_shift_Management_SystemDataSet2.Product);

        }
    }
}
