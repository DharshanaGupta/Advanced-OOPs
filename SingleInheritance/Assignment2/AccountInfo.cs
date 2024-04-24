
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class AccountInfo:PersonalInfo
    {
        //property
        public string AccountNumber{get;set;}
        public string BranchName{get;set;}
        public string IFSCCode{get;set;}
        public double Balance{get;set;}

        public AccountInfo(string name,string fatherName,long phoneNumber,string mail,DateTime dob,string gender,string accountNumber,string branchName,string ifscCode,double balance):base(name,fatherName,phoneNumber,mail,dob,gender)
        {
            AccountNumber=accountNumber;
            BranchName=branchName;
            IFSCCode=ifscCode;
            Balance=balance;
        }
        public void ShowAccountInfo()
        {
            Console.WriteLine($"Name: {Name} \nFatherName: {FatherName} \nPhoneNumber: {PhoneNumber} \nMail: {Mail} \nDOB: {DOB} \nGender: {Gender} \nAccountNumber: {AccountNumber} \nBranchName: {BranchName} \nIFSCCode: {IFSCCode} \nBalance: {Balance}");
        }
        public double Deposit()
        {
            Console.WriteLine("Enter amount to deposit:");
            double deposit=double.Parse(Console.ReadLine());
            Balance =deposit+Balance;
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Balance: "+Balance);
            return Balance;
        }

        public double Withdraw()
        {
            Console.WriteLine("Enter amount to withdraw");
            double withdraw=double.Parse(Console.ReadLine());
            Balance=Balance-withdraw;
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Balance: "+Balance);
            return Balance;
        }

        public void ShowBalance()
        {
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("your Balance is: "+Balance);
            
        }
    }
}