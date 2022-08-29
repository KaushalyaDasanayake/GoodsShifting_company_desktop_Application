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
    public partial class Feedbacks : Form
    {
        public Feedbacks()
        {
            InitializeComponent();
        }

        //Data validate
        private bool DataValid()
        {
            if (txtUniqueID.Text == "")
            {
                MessageBox.Show("Enter Customer Unique ID");
                return false;
            }
            if (dtpDate.Text == "")
            {
                MessageBox.Show("Enter Date");
                return false;
            }
            if (txtDiscription.Text == "")
            {
                MessageBox.Show("Enter description");
                return false;
            }

            return true;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (DataValid())
            {
                Feedback feed = new Feedback();
                feed.uniqueID = Convert.ToInt32(txtUniqueID.Text);
                //dateTimePicker1.Value.ToString("yyyy-MM-dd");
                feed.date = dtpDate.Value.ToString("yyyy-MM-dd");
                feed.SubmitFeedback(feed);  //Save the feedback record
                ClearFields();

            }
        }

       private void ClearFields()
        {
            txtUniqueID.Text = "";
            txtDiscription.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
