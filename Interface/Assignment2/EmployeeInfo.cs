using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class EmployeeInfo:IDisplayInfo
    {
        private static int s_employeeID=2000;

        public string EmployeeID{get;}
        public string Name{get;set;}
        public string FatherName{get;set;}

        public EmployeeInfo(string name,string fathername)
        {
            s_employeeID++;
            EmployeeID="SF"+s_employeeID;
            Name=name;
            FatherName=fathername;
        }
        public void Display()
        {
            Console.WriteLine($"EmployeeID: {EmployeeID} \nName: {Name} \nFatherName: {FatherName}");
        }
    }
}