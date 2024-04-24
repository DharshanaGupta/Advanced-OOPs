using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeCardmanagement
{
    public class FoodDetails
    {
        //field
        private static int s_foodID=1000;
        //property
        public string FoodID{get;}
        public string FoodName{get;set;}
        public double FoodPrice{get;set;}
        public int AvailableQuantity{get;set;}

        public FoodDetails(string foodName,double foodPrice,int availableQuantity)
        {
            s_foodID++;
            FoodID="FID"+s_foodID;
            FoodName=foodName;
            FoodPrice=foodPrice;
            AvailableQuantity=availableQuantity;
        }
    }
}