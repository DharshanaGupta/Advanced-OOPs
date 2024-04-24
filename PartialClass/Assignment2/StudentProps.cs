using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public partial class StudentProps
    {
        public partial class StudentInfo
        {
            //property
            //StudentID,Name,Gender,DOB, Mobile, Physics, Chemistry, Maths Marks

            public string StudentID{get;set;}
            public string Name{get;set;}
            public string Gender{get;set;}
            public string Mobile{get;set;}
            public int Physics{get;set;}
            public int Chemistry{get;set;}
            public int Maths{get;set;}
        }
    }
}