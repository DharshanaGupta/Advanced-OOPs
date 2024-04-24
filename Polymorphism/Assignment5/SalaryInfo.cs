using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5
{
    public class SalaryInfo:EmployeeInfo
    {
        
        public int NoOfDaysWorked{get;set;}
        public double Salary{get;set;}

        public SalaryInfo(string name,string fatherName,long mobile,string gender,int noOfDaysWorked,double salary):base(name,fatherName,mobile,gender)
        {
            NoOfDaysWorked=noOfDaysWorked;
            Salary=salary;
        }

        // public void CalculateSalary()
        // {
        //     Salary=NoOfDaysWorked*500;
        // }

        public override void Display()
        {
            Console.WriteLine($"EmployeeID: {EmployeeID} \nName: {Name} \nFatherName: {FatherName} \nMobile: {Mobile} \nGender: {Gender} \nNoOfDaysWorked: {NoOfDaysWorked} \nSalary: {NoOfDaysWorked*500}");
        }
    }
}