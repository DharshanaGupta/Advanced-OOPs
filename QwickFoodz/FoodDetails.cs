using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public class FoodDetails
    {
        private static int s_foodID=2000;
        public string FoodID{get;}
        /// <summary>
        /// to gte name of the food property
        /// </summary>
        /// <value></value>
        public string FoodName{get;set;}
        /// <summary>
        /// to get price of the food
        /// </summary>
        /// <value></value>
        public double PricePerQuantity{get;set;}
        /// <summary>
        /// to know the available quantity
        /// </summary>
        /// <value></value>
        public int QuantityAvailable{get;set;}
        /// <summary>
        /// constructor to get details
        /// </summary>
        /// <param name="foodName"></param>
        /// <param name="pricePerQuantity"></param>
        /// <param name="quantityAvailable"></param>
        public FoodDetails(string foodName,double pricePerQuantity,int quantityAvailable)
        {
            s_foodID++;
            FoodID="FID"+s_foodID;
            FoodName=foodName;
            PricePerQuantity=pricePerQuantity;
            QuantityAvailable=quantityAvailable;
        }
        /// <summary>
        /// constructor for filr handling
        /// </summary>
        /// <param name="food"></param>
        public FoodDetails(string food)
        {
            string[] value=food.Split(",");
            
            FoodID=value[0];
            s_foodID=int.Parse(value[0].Remove(0,3));
            FoodName=value[1];
            PricePerQuantity=double.Parse(value[2]);
            QuantityAvailable=int.Parse(value[3]);
        }


    }
}