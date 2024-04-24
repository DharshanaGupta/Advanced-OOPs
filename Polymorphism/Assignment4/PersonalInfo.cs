using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4
{
    public class PersonalInfo
    {
        public string Name{get;set;}
        public string FatherName{get;set;}
        public string Gender{get;set;}
        public string Qualification{get;set;}

        public PersonalInfo(string name,string fatherName,string gender,string qualification)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Qualification=qualification;
        }
    }
}