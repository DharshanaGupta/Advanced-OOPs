using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public class PersonalInfo
    {
        private static int s_registerNumber=1000;
        //RegistationNumber, Name, FatherName, Phone, DOB, Gender
        public string RegistationNumber{get;}
        public string Name{get;set;}
        public string FatherName{get;set;}
        public long Phone{get;set;}
        public DateTime DOB{get;set;}
        public string Gender{get;set;}

        public PersonalInfo(string name,string fatherName,long phone,DateTime dob,string gender)
        {
            s_registerNumber++;
            RegistationNumber="SID"+s_registerNumber;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            DOB=dob;
            Gender=gender;

        }
    }
}