using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeCardmanagement
{
    //enum
    public enum Gender{Select,Male,Female};
    public class PersonalDetails
    {
        //properties
        public string Name{get;set;}
        public string Fathername{get;set;}
        public Gender Gender{get;set;}
        public string Mobile{get;set;}
        public string Mail{get;set;}

        public PersonalDetails(string name,string fatherName,Gender gender,string mobile,string mail)
        {
            Name=name;
            Fathername=fatherName;
            Gender=gender;
            Mobile=mobile;
            Mail=mail;
        }

    }
}