using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Syncfusion:FreeLancer
    {
        private static int s_employeeID=1000;
        public string EmployeeID{get;}
        public string WorkLocation{get;set;}

        public Syncfusion(string name,string fatherName,string gender,string qualification,string role,
        int noOfWorkingDays,double salaryAmount,string workLocation):base(name,fatherName,gender,qualification,role,noOfWorkingDays,salaryAmount)
        {
            s_employeeID++;
            EmployeeID="SF"+s_employeeID;
            WorkLocation=workLocation;
        }


        public override void Salary()
        {
            SalaryAmount=NoOfWorkingDays*500;
        }
        public override void Display()
        {
            Console.WriteLine($"EmployeeID: {EmployeeID} \nName: {Name} \nRole: {Role} \nWorkLocation: {WorkLocation} \nNoOfWorkingDays: {NoOfWorkingDays} \nSalary: {SalaryAmount}");
        }
    }
}