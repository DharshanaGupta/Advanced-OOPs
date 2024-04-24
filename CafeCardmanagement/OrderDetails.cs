using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeCardmanagement
{
    //enum
    public enum OrderStatus{Select,Initiated,Ordered,Cancelled}
    public class OrderDetails
    {
        //field
        private static int s_orderID=1000;
        //property
        public string OrderID{get;}
        public string UserID{get;set;}
        public DateTime OrderDate{get;set;}
        public double TotalPrice{get;set;}
        public OrderStatus OrderStatus{get;set;}

        public OrderDetails(string userID,DateTime orderDate,double totalPrice,OrderStatus orderStatus)
        {
            s_orderID++;
            OrderID="OID"+s_orderID;
            UserID=userID;
            OrderDate=orderDate;
            TotalPrice=totalPrice;
            OrderStatus=orderStatus;
        }

    }
}