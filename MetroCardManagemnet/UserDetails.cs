using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagemnet
{
    public class UserDetails:PersonalDetails,IBalance
    {
        /// <summary>
        /// It is private field for CardNumber
        /// </summary>
        private static int s_cardNumber=1000;

        /// <summary>
        /// It is Read only Property for CardNumber in <see cref="UserDetails"/>
        /// </summary>
        /// <value></value>
        public string CardNumber{get;}
        /// <summary>
        /// It tells the Balance amount that user has
        /// </summary> 
        
        public double Balance{get;set;}

        /// <summary>
        /// Parameterised Constructor for Getting Details from User.
        /// </summary>
        /// <param name="username">For UserName</param>
        /// <param name="phone">User's Phone Number</param>
        /// <param name="balance">User's Balance</param>
        /// <returns></returns>
        public UserDetails(string username,string phone,double balance):base(username,phone)
        {
            s_cardNumber++;
            CardNumber="CMRL"+s_cardNumber;
            Balance=balance;

        }

        //constructor for File handling
        /// <summary>
        /// Constructor for File Handling When Reading User Datas from CSV files
        /// </summary>
        /// <param name="user">It holds the User Details</param>
        public UserDetails(string user)
        {
            string[] value=user.Split(",");
            //s_cardNumber++;
            
            CardNumber=value[0];
            s_cardNumber=int.Parse(value[0].Remove(0,4));
            UserName=value[1];
            Phone=value[2];
            Balance=double.Parse(value[3]);

        }

        /// <summary>
        /// Method for Adding Amount to the current Balance
        /// </summary>
        /// <param name="amount">It holds the amount to be Recharged</param>
        /// <returns>It returns back the Balance</returns>
        public double WalletRecharge(double amount)
        {
            Balance+=amount;
            return Balance;
        }

        /// <summary>
        /// Method for Deducting amount from Balance
        /// </summary>
        /// <param name="amount">It holds the amount need to be deducted from the Balance</param>
        /// <returns>It returns back the Balance</returns>
        public double DeductBalance(double amount)
        {
            Balance=Balance-amount;
            return Balance;
        }
    }
    
}