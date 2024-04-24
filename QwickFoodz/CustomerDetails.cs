using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public class CustomerDetails:PersonalDetails,IBalance
    {
        /// <summary>
        /// private field for balance
        /// </summary>
        private double _balance;
        /// <summary>
        /// read only customerID 
        /// </summary>
        private static int s_customerID=1000;
        /// <summary>
        /// balance of the user in read only mode
        /// </summary>
        /// <value></value>
        public double WalletBalance{get{return _balance;}}
        /// <summary>
        /// CustomerID property
        /// </summary>
        /// <value></value>
        public string CustomerID{get;}
        /// <summary>
        /// to recharge the balance
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public double WalletRecharge(double amount)
        {
            _balance+=amount;
            return _balance;
        }

        /// <summary>
        /// to reduce amount from user balance
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public double DeductBalance(double amount)
        {
            _balance-=amount;
            return _balance;
        }
        /// <summary>
        /// constructor for getting details
        /// </summary>
        /// <param name="name"></param>
        /// <param name="fatherName"></param>
        /// <param name="gender"></param>
        /// <param name="mobile"></param>
        /// <param name="dob"></param>
        /// <param name="mailID"></param>
        /// <param name="location"></param>
        /// <param name="walletBalance"></param>
        /// <returns></returns>
        public CustomerDetails(string name,string fatherName,Gender gender,string mobile,DateTime dob,string mailID,string location,double walletBalance):base(name,fatherName,gender,mobile,dob,mailID,location)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
            _balance=walletBalance;
        }
        /// <summary>
        /// constructor for file handi\ling
        /// </summary>
        /// <param name="customer"></param>
        public CustomerDetails(string customer)
        {
            string[] value=customer.Split(",");
            CustomerID=value[0];
            s_customerID=int.Parse(value[0].Remove(0,3));
            Name=value[1];
            FatherName=value[2];
            Gender=Enum.Parse<Gender>(value[3]);
            Mobile=value[4];
            DOB=DateTime.ParseExact(value[5],"dd/MM/yyyy",null);
            MailID=value[6];
            Location=value[7];
            _balance=double.Parse(value[8]);

        }

    }
}