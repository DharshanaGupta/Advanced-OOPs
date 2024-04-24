using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5
{
    public class EmployeeInfo:PersonalInfo
    {
        private static int s_employeeID=1000;
        public string EmployeeID{get;}
        public EmployeeInfo(string name,string fatherName,long mobile,string gender):base(name,fatherName,mobile,gender)
        {
            s_employeeID++;
            EmployeeID="SF"+s_employeeID;
        }
        public override void Display()
        {
            Console.WriteLine($"EmployeeID: {EmployeeID} \nName: {Name} \nFatherName: {FatherName} \nMobile: {Mobile} \nGender: {Gender}");
        }
    }
}