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
    public partial class AdminView : KryptonForm
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
        public AdminView()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panelNav.Height = btnDashboard.Height;
            panelNav.Top = btnDashboard.Top;
            panelNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lbltitle.Text = "Dashboard";
            this.panelFormLoader.Controls.Clear();
            AdminDashboard dashboard = new AdminDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboard.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void AdminView_Load(object sender, EventArgs e)
        {
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnDashboard.Height;
            panelNav.Top = btnDashboard.Top;
            panelNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lbltitle.Text = "Dashboard";
            this.panelFormLoader.Controls.Clear();
            AdminDashboard dashboard = new AdminDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboard.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnCustomers.Height;
            panelNav.Top = btnCustomers.Top;
            btnCustomers.BackColor = Color.FromArgb(46, 51, 73);
            // Redirecting to another page from one page 

            lbltitle.Text = "Customer Details";
            this.panelFormLoader.Controls.Clear();
            AddCustomers customer = new AddCustomers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            customer.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(customer);
            customer.Show();

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnProduct.Height;
            panelNav.Top = btnProduct.Top;
            btnProduct.BackColor = Color.FromArgb(46, 51, 73);


            lbltitle.Text = "Product Details";
            this.panelFormLoader.Controls.Clear();
            AddProducts product = new AddProducts() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            product.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(product);
            product.Show();
        }

        private void btnOperations_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnOperations.Height;
            panelNav.Top = btnOperations.Top;
            btnOperations.BackColor = Color.FromArgb(46, 51, 73);


            lbltitle.Text = "Operation Details";
            this.panelFormLoader.Controls.Clear();
            Operation job = new Operation() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            job.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(job);
            job.Show();
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnTransport.Height;
            panelNav.Top = btnTransport.Top;
            btnTransport.BackColor = Color.FromArgb(46, 51, 73);


            lbltitle.Text = "Transport Management";
            this.panelFormLoader.Controls.Clear();
            TransportDetails transport = new TransportDetails() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            transport.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(transport);
            transport.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnUser.Height;
            panelNav.Top = btnUser.Top;
            btnUser.BackColor = Color.FromArgb(46, 51, 73);


            lbltitle.Text = "User Management";
            this.panelFormLoader.Controls.Clear();
            AddUsers adduser = new AddUsers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            adduser.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(adduser);
            adduser.Show();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCustomers_Leave(object sender, EventArgs e)
        {
            btnCustomers.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnProduct_Leave(object sender, EventArgs e)
        {
            btnProduct.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnOperations_Leave(object sender, EventArgs e)
        {
            btnOperations.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnTransport_Leave(object sender, EventArgs e)
        {
            btnTransport.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnUser_Leave(object sender, EventArgs e)
        {
            btnUser.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnNewOrders.Height;
            panelNav.Top = btnNewOrders.Top;
            btnNewOrders.BackColor = Color.FromArgb(46, 51, 73);

            lbltitle.Text = "New Orders";
            this.panelFormLoader.Controls.Clear();
            NewOrders odd = new NewOrders() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            odd.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(odd);
            odd.Show();

        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnNewOrders.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //Adminview Window Close
        }

        private void panelFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbltitle_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnPayments.Height;
            panelNav.Top = btnPayments.Top;
            btnPayments.BackColor = Color.FromArgb(46, 51, 73);
            // Redirecting to another page from one page 

            lbltitle.Text = "Payment Details";
            this.panelFormLoader.Controls.Clear();
            AddPayments payment = new AddPayments() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            payment.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(payment);
            payment.Show();
        }

        private void btnPayments_Leave(object sender, EventArgs e)
        {
            btnPayments.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
