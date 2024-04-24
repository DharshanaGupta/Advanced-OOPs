using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class PersonalInfo
    {
        public string Name{get;set;}
        public string Gender{get;set;}
        public DateTime DOB{get;set;}
        public long PhoneNumber{get;set;}

        public PersonalInfo(string name,string gender,DateTime dob,long phone)
        {
            Name=name;
            Gender=gender;
            DOB=dob;
            PhoneNumber=phone;
        }

    }
}