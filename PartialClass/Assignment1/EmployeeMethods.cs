using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public partial class EmployeeMethods
    {
        public partial class EmployeeInfo
        {
            //methods
            public  void Update(string employeeID,string name,string gender,DateTime dob,string mobile)
            {
                Console.WriteLine($"Employee ID: {employeeID} \nName: {name} \nGender: {gender} \nDOB: {dob} \nMobile: {mobile}");
            }
            public void Display(string employeeID,string name,string gender,DateTime dob,string mobile)
            {
                Console.WriteLine($"Employee ID: {employeeID} \nName: {name} \nGender: {gender} \nDOB: {dob} \nMobile: {mobile}");
            }
           
        }
    }
}