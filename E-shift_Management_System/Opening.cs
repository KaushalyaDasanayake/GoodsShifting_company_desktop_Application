using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace E_shift_Management_System
{
    public partial class Opening : Form
    {
        [DllImport("Gdi32.dll",EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );


        public Opening()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));  //Create curved Border
            ProgressBar.Value = 0; //Add Progressbar value
        }

        private void ProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void Opening_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ProgressBar.Value += 1;
            ProgressBar.Text = ProgressBar.Value.ToString() + "%";

            if (ProgressBar.Value == 100)
            {
                Timer.Enabled = false;
                Login se_form = new Login();
                se_form.Show();
                this.Hide();
            }
        }
    }
}
