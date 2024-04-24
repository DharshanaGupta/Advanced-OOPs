using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class DepartmentDetails
    {
        //DepartmentName, Degree
        public string DepartmentName{get;set;}
        public string Degree{get;set;}

        public DepartmentDetails(string departmentName,string degree)
        {
            DepartmentName=departmentName;
            Degree=degree;
        }
    }
}