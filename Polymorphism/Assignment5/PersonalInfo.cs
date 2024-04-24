using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5
{
    public abstract class PersonalInfo
    {
        public string Name{get;set;}
        public string FatherName{get;set;}
        public long Mobile{get;set;}
        public string Gender{get;set;}

        public PersonalInfo(string name,string fatherName,long mobile,string gender)
        {
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
            Gender=gender;
        }

        public abstract void Display();

        
    }
}