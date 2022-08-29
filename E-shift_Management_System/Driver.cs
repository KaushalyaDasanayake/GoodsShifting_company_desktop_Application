using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_shift_Management_System
{
    class Driver
    {
        public string driverName { get; set; }
        public string Address { get; set; }
        public string contactNo { get; set; }
        public string email { get; set; }


        public void SaveDriver(Driver driver)
        {
            string sql = "insert into Driver (driverName,Address,contactNo,email) values" + "('" + driver.driverName + "','" + driver.Address + "','" + driver.contactNo + "','" + driver.email + "')";
            DBconnection.ExecuteQuery(sql);
        }
        public void UpdateDriver(Driver driver)
        {
            string sql = "update Driver set Address='" + driver.Address + "',contactNo='" + driver.contactNo + "',email='" + driver.email + "' where =driverName'" + driverName + "'";
            DBconnection.ExecuteQuery(sql);
        }

        public void DeleteDriver(Driver driver)
        {
            string sql = "delete from Driver where driverName=" + driver.driverName;
            DBconnection.ExecuteQuery(sql);
        }
    }
}
