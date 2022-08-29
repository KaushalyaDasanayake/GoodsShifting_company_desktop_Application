using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Runtime.InteropServices;

namespace E_shift_Management_System
{
    public partial class CustomerView : KryptonForm
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int RightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );
        public CustomerView()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panelNav.Height = btnDashboard.Height;
            panelNav.Top = btnDashboard.Top;
            panelNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(207, 159, 255);

            lbltitle.Text = "Household Goods Mover";
            this.panelFormLoader.Controls.Clear();
            CustomerDashboard dashboard = new CustomerDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboard.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnDashboard.Height;
            panelNav.Top = btnDashboard.Top;
            panelNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(207, 159, 255);

            lbltitle.Text = "Household Goods Mover";
            this.panelFormLoader.Controls.Clear();
            CustomerDashboard dashboard = new CustomerDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboard.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void btnOrdering_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnOrdering.Height;
            panelNav.Top = btnOrdering.Top;
            btnOrdering.BackColor = Color.FromArgb(207, 159, 255);
            // Redirecting to another page from one page 

            lbltitle.Text = "Odering";
            this.panelFormLoader.Controls.Clear();
            Ordering order = new Ordering() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            order.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(order);
            order.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnHistory.Height;
            panelNav.Top = btnHistory.Top;
            btnHistory.BackColor = Color.FromArgb(207, 159, 255);
            // Redirecting to another page from one page 

            lbltitle.Text = "Order History";
            this.panelFormLoader.Controls.Clear();
            Order_History orderH = new Order_History() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            orderH.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(orderH);
            orderH.Show();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnFeedback.Height;
            panelNav.Top = btnFeedback.Top;
            btnFeedback.BackColor = Color.FromArgb(207, 159, 255);


            lbltitle.Text = "Feedback";
            this.panelFormLoader.Controls.Clear();
            Feedbacks feed = new Feedbacks() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            feed.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(feed);
            feed.Show();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(127, 0, 255);
        }

        private void btnOrdering_Leave(object sender, EventArgs e)
        {
            btnOrdering.BackColor = Color.FromArgb(127, 0, 255);
        }

        private void btnHistory_Leave(object sender, EventArgs e)
        {
            btnHistory.BackColor = Color.FromArgb(127, 0, 255);
        }

        private void btnFeedback_Leave(object sender, EventArgs e)
        {
            btnFeedback.BackColor = Color.FromArgb(127, 0, 255);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
