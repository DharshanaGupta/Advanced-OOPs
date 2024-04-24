using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class PermanentEmployee:SalaryInfo
    {
        /*Properties: EmployeeID, Employee Type, DA=0.2% of basic, HRA= 0.18% of basic, PF – 0.1 % basic, Total Salary

        Method: Calculate TotalSalary – Basic +DA+HRA-PF, ShowSalary*/

        private static int s_employeeID=1000;
        public string EmployeeID{get;set;}
        public string EmployeeType{get;set;}
        public double DA{get;set;}
        public double HRA{get;set;}
        public double PF{get;set;}
        public double TotalSalary{get;set;}

        public PermanentEmployee(double basicsalary,string employeeType):base(basicsalary)
        {
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            EmployeeType=employeeType;
        }

        public void CalculateSalary()
        {
            DA=(double)0.2/100*BasicSalary;
            HRA=(double)0.18/100*BasicSalary;
            PF=(double)0.1/100*BasicSalary;
            TotalSalary=BasicSalary+DA+HRA-PF;

        }
        public void ShowSalary()
        {
            Console.WriteLine($"EmployeeID: {EmployeeID} \nTotalsalary: {TotalSalary}");
        }
    }
}