using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_shift_Management_System
{
    class NewOrder
    {
        public int ID { get; set; }
        public int UniqueID { get; set; }
        public string productName { get; set; }
        public int quantity { get; set; }
        public string weight { get; set; }
        public string fromWhere { get; set; }
        public string toWhere { get; set; }
        public string dueDate { get; set; }
        public string discription { get; set; }

        public void SubmitOrder(NewOrder order)
        {

            string sql = "insert into NewOrder (UniqueID,productName,quantity,weight,fromWhere,toWhere,dueDate,discription) values  "
            + "('" + order.UniqueID + "','" + order.productName + "','" + order.quantity + "','" +
            order.weight + "','"+order.fromWhere+"','"+order.toWhere+"','"+order.dueDate+"','"+order.discription+"')";
            DBconnection.ExecuteQuery(sql);
        }

    }
}
