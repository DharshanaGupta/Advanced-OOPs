using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public enum OrderStatus{Default,Initiated,Ordered,Cancelled};
    public class OrderDetails
    {
        private static int s_orderID=3000;
        public string OrderID{get;}
        public string CustomerID{get;set;}
        public double TotalPrice{get;set;}
        public DateTime DateOfOrder{get;set;}
        public OrderStatus OrderStatus{get;set;}
        /// <summary>
        /// constructor for getting details
        /// </summary>
        /// <param name="customerID"></param>
        /// <param name="totalPrice"></param>
        /// <param name="dateOfOrder"></param>
        /// <param name="orderStatus"></param>
        public OrderDetails(string customerID,double totalPrice,DateTime dateOfOrder,OrderStatus orderStatus)
        {
            s_orderID++;
            OrderID="OID"+s_orderID;
            CustomerID=customerID;
            TotalPrice=totalPrice;
            DateOfOrder=dateOfOrder;
            OrderStatus=orderStatus;
        }
        /// <summary>
        /// constructor for file handling
        /// </summary>
        /// <param name="order"></param>
        public OrderDetails(string order)
        {
            string[] value=order.Split(",");
            OrderID=value[0];
            s_orderID=int.Parse(value[0].Remove(0,3));
            CustomerID=value[1];
            TotalPrice=double.Parse(value[2]);
            DateOfOrder=DateTime.ParseExact(value[3],"dd/MM/yyyy",null);
            OrderStatus=Enum.Parse<OrderStatus>(value[4]);
        }
    }
}