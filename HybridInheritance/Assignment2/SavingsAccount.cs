using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Assignment2
{
    public class SavingsAccount:IDInfo,ICalculate,IBankInfo
    {
        //field
        private string bankName;
        private string iFSC;
        private string branch;
        public string BankName{get{return bankName;}set{bankName=value;}}
        public string IFSC{get{return iFSC;}set{iFSC=value;}}
        public string Branch{get{return branch;}set{branch=value;}}
        public string AccountNumber{get;set;}
        
        public string AccountType{get;set;}
        public double Balance{get;set;}

        public SavingsAccount(string name,string gender,DateTime dob,long phone,string voterID,string aadhar,string panID,
        string accountNumber,string accountType,double balance):base(name,gender,dob,phone,voterID,aadhar,panID)
        {
            AccountNumber=accountNumber;
            AccountType=accountType;
            Balance=balance;
        }

        public double Deposit()
        {
            Console.WriteLine("******Deposit*****");
            Console.WriteLine("Enter amount to deposit:");
            double deposit=double.Parse(Console.ReadLine());
            double balance =deposit+Balance;
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Balance: "+balance);
            return balance;
           
        }
        public double Withdraw()
        {
            Console.WriteLine("Enter amount to withdraw");
            double withdraw=double.Parse(Console.ReadLine());
            double balance=Balance-withdraw;
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Balance: "+balance);
            return balance;
           
        }
        public void BalanceCheck()
        {
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("your Balance is: "+Balance);
        }
        
    }
}