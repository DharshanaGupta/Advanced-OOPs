using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeCardmanagement
{
    public class UserDetails:PersonalDetails,IBalance
    {
        private static int s_userID=1000;
        public double _balance;

        //public double Balance{get{return _balance;}}
        public string UserID{get;}
        public double Walletbalance{get;set;}
        public string WorkStationNumber{get;set;}

        public UserDetails(string name,string fatherName,Gender gender,string mobile,string mail,double walletBalance,string workStationNumber):base(name,fatherName,gender,mobile,mail)
        {
            s_userID++;
            UserID="SF"+s_userID;
            Walletbalance=walletBalance;
            WorkStationNumber=workStationNumber;
        }

        public double WalletRecharge(double amount)
        {
            Walletbalance=Walletbalance+amount;
            
            return Walletbalance;
            
        }
        
        public double DeductAmount(double total)
        {
            Walletbalance=Walletbalance-total;
            return Walletbalance;
        }
    }
}