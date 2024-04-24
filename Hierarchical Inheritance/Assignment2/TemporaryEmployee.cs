using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class TemporaryEmployee:SalaryInfo
    {
        private static int s_employeeID=1000;
        public string EmployeeID{get;set;}
        public string EmployeeType{get;set;}
        public double DA{get;set;}
        public double HRA{get;set;}
        
        public double TotalSalary{get;set;}

        public TemporaryEmployee(double basicsalary,string employeeType):base(basicsalary)
        {
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            EmployeeType=employeeType;
        }

        public void CalculateSalary()
        {
            DA=(double)0.15/100*BasicSalary;
            HRA=(double)0.13/100*BasicSalary;
            TotalSalary=BasicSalary+DA+HRA;

        }
        public void ShowSalary()
        {
            Console.WriteLine($"EmployeeID: {EmployeeID} \nTotalsalary: {TotalSalary}");
        }
    }
}