using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public class ItemDetails
    {
        /// <summary>
        /// private field for item id
        /// </summary>
        private static int s_itemID=100;
        /// <summary>
        /// public for to access the item id
        /// </summary>
        /// <value></value>
        public string ItemID{get;}
        /// <summary>
        /// property for holding order id
        /// </summary>
        /// <value></value>
        public string OrderID{get;set;}
        /// <summary>
        /// property for holding food id
        /// </summary>
        /// <value></value>
        public string FoodID{get;set;}
        /// <summary>
        /// property for holding count purchased
        /// </summary>
        /// <value></value>
        public int PurchaseCount{get;set;}
        /// <summary>
        /// property for holding price of the order
        /// </summary>
        /// <value></value>
        public double PriceOfOrder{get;set;}

        /// <summary>
        /// constructor for getting details of order
        /// </summary>
        /// <param name="orderID"></param>
        /// <param name="foodID"></param>
        /// <param name="purchaseCount"></param>
        /// <param name="priceOfOrder"></param>
        public ItemDetails(string orderID,string foodID,int purchaseCount,double priceOfOrder)
        {
            s_itemID++;
            ItemID="ITID"+s_itemID;
            OrderID=orderID;
            FoodID=foodID;
            PurchaseCount=purchaseCount;
            PriceOfOrder=priceOfOrder;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public ItemDetails(string item)
        {
            string[] value=item.Split(",");
            ItemID=value[0];
            s_itemID=int.Parse(value[0].Remove(0,4));
            OrderID=value[1];
            FoodID=value[2];
            PurchaseCount=int.Parse(value[3]);
            PriceOfOrder=double.Parse(value[4]);

        }
    }
}