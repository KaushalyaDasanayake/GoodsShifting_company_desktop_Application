using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_shift_Management_System
{
    class OrderDetails
    {
        public int detailID { get; set; }
        public int jobID { get; set; }
        public string productID { get; set; }
        public int quantity { get; set; }
        public decimal unitPrice { get; set; }
        public decimal discount { get; set; }
        public string packingtype { get; set; }
        public int loadID { get; set; }

        public void SaveOrder(OrderDetails order)
        {
            string sql = "insert into OrderDetails (detailID,jobID,productID,quantity,unitPrice,discount,packingtype,loadID) values" + "('" + order.detailID + "'," + order.jobID + ",'" + order.productID + "','" + order.quantity+ "','" + order.unitPrice + "'," + order.discount + ",'"+order.packingtype+"','"+order.loadID+"')";
            DBconnection.ExecuteQuery(sql);
        }
        public void UpdateOrder(OrderDetails order)
        {
            string sql = "update OrderDetails set jobID='" + order.jobID + "',productID=" + order.productID + ",quantity='" + order.quantity + "',unitPrice='" + order.unitPrice + "',discount='"+order.discount+ "',packingtype='"+order.packingtype+ "',loadID='"+order.loadID+ "' where detailID='" + detailID + "'";
            DBconnection.ExecuteQuery(sql);
        }

        public void DeleteOrder(OrderDetails order)
        {
            string sql = "delete from OrderDetails where detailID=" + order.detailID;
            DBconnection.ExecuteQuery(sql);
        }
    }

}
