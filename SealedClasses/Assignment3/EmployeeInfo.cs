using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3
{
    public class EmployeeInfo:FamilyInfo
    {
        private static int s_employeeID=4000;
        public string EmployeeID{get;}
        public DateTime DateOfJoining{get;set;}

        public override void Update(string fatherName,string motherName,int noOfSiblings,string nativePlace)//can't override because it is sealed
        {

        }

        public EmployeeInfo(string name,string fatherName,int mobile,string gender,string father,string motherName,int noOfSiblings,
        string nativePlace,DateTime dateOfJoining):base(name,fatherName,mobile,gender,father,motherName,noOfSiblings,nativePlace)
        {
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            DateOfJoining=dateOfJoining;
        }
    }
}