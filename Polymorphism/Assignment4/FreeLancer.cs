using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4
{
    public class FreeLancer:PersonalInfo
    {
        public string Role{get;set;}
        public double SalaryAmount{get;set;}
        public int NoOfWorkingDays{get;set;}

        public FreeLancer(string name,string fatherName,string gender,string qualification,string role,
        int noOfWorkingDays,double salaryAmount):base(name,fatherName,gender,qualification)
        {
            Role=role;
            NoOfWorkingDays=noOfWorkingDays;
            SalaryAmount=salaryAmount;
        }

        public virtual void Salary()
        {
            SalaryAmount=NoOfWorkingDays*500;
        }
        public virtual void Display()
        {
            Console.WriteLine($"Name: {Name} \nRole: {Role} \nNoOfWorkingDays: {NoOfWorkingDays} \nSalary: {SalaryAmount}");
        }
    }
}