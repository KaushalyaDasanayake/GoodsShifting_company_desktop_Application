using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_shift_Management_System
{
    class Feedback
    {
        public int uniqueID { get; set; }
        public string date { get; set; }
        public string description { get; set; }

        //Feedback data saved database
        public void SubmitFeedback(Feedback feed)
        {
            string sql = "insert into Feedback (uniqueID,date,description) values" + "('" + feed.uniqueID + "','" + feed.date + "','" + feed.description + "')";
            DBconnection.ExecuteQuery(sql);
        }

    }
}
