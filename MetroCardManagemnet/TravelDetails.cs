using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagemnet
{
    public class TravelDetails
    {
        /// <summary>
        /// It is private field for Travel ID
        /// </summary>
        private static int s_travelID=2000;
        /// <summary>
        /// Read Only property for TravelID
        /// </summary>
        public string TravelID{get;}
        /// <summary>
        /// public property for User's CardNumber 
        /// </summary>
        /// <value></value>
        public string CardNumber{get;set;}
        /// <summary>
        /// Property for getting start Location
        /// </summary>
        /// <value></value>
        public string FromLocation{get;set;}
        /// <summary>
        /// Property for getting Destination Location
        /// </summary>
        /// <value></value>
        public string ToLocation{get;set;}
        /// <summary>
        /// Represents the Date of the Travel
        /// </summary>
        /// <value></value>
        public DateTime Date{get;set;}
        /// <summary>
        /// It holds the cost of the Travel
        /// </summary>
        /// <value></value>
        public double TravelCost{get;set;}

        /// <summary>
        /// Parameterised Constructor for getting the Travel details
        /// </summary>
        /// <param name="cardNumber">It holds the user's card number</param>
        /// <param name="fromLocation">Starting Location</param>
        /// <param name="toLocation">Destination Location</param>
        /// <param name="date">It represents the date of Travel</param>
        /// <param name="travelCost">Cost of Travel</param>
        public TravelDetails(string cardNumber,string fromLocation,string toLocation,DateTime date,double travelCost)
        {
            s_travelID++;
            TravelID="TID"+s_travelID;
            CardNumber=cardNumber;
            FromLocation=fromLocation;
            ToLocation=toLocation;
            Date=date;
            TravelCost=travelCost;

        }

        /// <summary>
        ///Constructor for File Handling When Reading Travel related Datas from CSV files
        /// </summary>
        /// <param name="travel">Holds the Travel details</param>
        public TravelDetails(string travel)
        {
            string[] value=travel.Split(",");
            TravelID=value[0];
            s_travelID=int.Parse(value[0].Remove(0,3));
            CardNumber=value[1];
            FromLocation=value[2];
            ToLocation=value[3];
            Date=DateTime.ParseExact(value[4],"dd/MM/yyyy",null);
            TravelCost=double.Parse(value[5]);

        }
    }
}