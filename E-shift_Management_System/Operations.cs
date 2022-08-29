using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace E_shift_Management_System
{
    class Operations
    {
        //get value 
        public int jobID { get; set; }
        public int uniqueID { get; set; }
        public string orderDate { get; set; }
        public string shipdate { get; set; }
        public string startLocation { get; set; }
        public string requestedLocation { get; set; }

        //create object and create save operation / save query
        public void SaveOperation(Operations op)
        {
            string sql = "insert into Operations (jobID,uniqueID,orderDate,shipdate,startLocation,requestedLocation) values" + 
                "('"+op.jobID+"',"+op.uniqueID+",'"+op.orderDate+"','"+op.shipdate+"','"+op.startLocation+"','"+op.requestedLocation+"')";
            DBconnection.ExecuteQuery(sql); //execute data
        }

        //create object and create update operation / update query
        public void UpdateOperation(Operations op)
        {
            string sql = "update Operations set uniqueID='" + op.uniqueID + "',orderDate='" + op.orderDate + "',shipdate='" + op.shipdate + "'," +
                "startLocation='" + op.startLocation + "',requestedLocation='" + op.requestedLocation + "' where jobID='" + jobID + "'";
            DBconnection.ExecuteQuery(sql);//execute data
        }

        //create object and create delete operation / delete query
        public void DeleteOperation(Operations op)
        {
            string sql = "delete from Operations where uniqueID=" + op.uniqueID;
            DBconnection.ExecuteQuery(sql);//execute data 
        }
    }
}
