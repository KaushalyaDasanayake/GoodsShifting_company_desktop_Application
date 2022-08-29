using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_shift_Management_System
{
    class Vehicle
    {
        public string vehicleNo { get; set; }
        public string vehicleType { get; set; }
        public string color { get; set; }
        public string carryingWeight { get; set; }


        public void SaveVehicle(Vehicle ve)
        {
            string sql = "insert into Vehicle (vehicleNo,vehicleType,color,carryingWeight) values" + "('" + ve.vehicleNo + "','" + ve.vehicleType + "','" + ve.color + "','" + ve.carryingWeight + "')";
            DBconnection.ExecuteQuery(sql);
        }
        public void UpdateVehicle(Vehicle ve)
        {
            string sql = "update Vehicle set vehicleType='" + ve.vehicleType + "',color='" + ve.color + "',carryingWeight='" + ve.carryingWeight + "' where =vehicleNo'" + vehicleNo + "'";
            DBconnection.ExecuteQuery(sql);
        }

        public void DeleteVehicle(Vehicle ve)
        {
            string sql = "delete from Vehicle where vehicleNo=" + ve.vehicleNo;
            DBconnection.ExecuteQuery(sql);
        }
    }
}
