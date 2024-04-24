using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagemnet
{
    public class TicketFairDetails
    {
        /// <summary>
        /// It represents the private field
        /// </summary>
        private static int s_ticketID=3000;
        /// <summary>
        /// it represents read only property for TicketID, from <see cref="TicketFairDetails"/>
        /// </summary>
        /// <value></value>
        public string TicketID{get;}
        /// <summary>
        /// it is a public property ,represents FromLocation in  <see cref="TicketFairDetails"/>
        /// </summary>
        /// <value></value>
        public string FromLocation{get;set;}
        /// <summary>
        /// it is a public property ,represents ToLocation in <see cref="TicketFairDetails"/>
        /// </summary>
        /// <value></value>
        public string ToLocation{get;set;}
        /// <summary>
        /// it is public property , represents price of the Ticket in <see cref="TicketFairDetails"/>
        /// </summary>
        /// <value></value>
        public double TicketPrice{get;set;}

        /// <summary>
        /// Parameterised constructor for getting details of Tickets
        /// </summary>
        /// <param name="fromLocation">It represents where the starting location is</param>
        /// <param name="toLocation">It represents where the Destination location is</param>
        /// <param name="ticketPrice">It says the Price of the ticket</param>
        public TicketFairDetails(string fromLocation,string toLocation,double ticketPrice)
        {
            s_ticketID++;
            TicketID="MR"+s_ticketID;
            FromLocation=fromLocation;
            ToLocation=toLocation;
            TicketPrice=ticketPrice;

        }

        /// <summary>
        /// It is File handling ,used when Ticket related Datas are Reading from CSV files
        /// </summary>
        /// <param name="ticketsFair1">It holds the Ticket Details</param>
        public TicketFairDetails(string ticketsFair1)
        {
            string[] value=ticketsFair1.Split(",");
            TicketID=value[0];
            s_ticketID=int.Parse(value[0].Remove(0,2));
            FromLocation=value[1];
            ToLocation=value[2];
            TicketPrice=double.Parse(value[3]);

        }
    }
}