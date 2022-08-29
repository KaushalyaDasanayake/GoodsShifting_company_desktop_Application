using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_shift_Management_System
{
    class Load
    {
        public int loadID { get; set; }
        public string vehicleNo { get; set; }
        public int driverID { get; set; }
        public int containerID { get; set; }
        public int jobID { get; set; }
        public string date { get; set; }
        public string description { get; set; }


        public void SaveLoad(Load load)
        {
            string sql = "insert into Load (loadID,vehicleNo,driverID,containerID,jobID,date,description) values" + "(" + load.loadID + ",'" + load.vehicleNo + "'," + load.driverID + "," + load.containerID + ","+load.jobID+",'"+load.date+"','"+load.description+"')";
            DBconnection.ExecuteQuery(sql);
        }
        public void UpdateLoad(Load load)
        {
            string sql = "update Load set vehicleNo='" + load.vehicleNo + "',driverID=" + load.driverID + ",containerID=" + load.containerID + ",jobID="+load.jobID+",date='" + load.date + "' where loadID=" + loadID + "";
            DBconnection.ExecuteQuery(sql);
        }

        public void DeleteLoad(Load load)
        {
            string sql = "delete from Load where loadID=" + load.loadID;
            DBconnection.ExecuteQuery(sql);
        }
    }
}
