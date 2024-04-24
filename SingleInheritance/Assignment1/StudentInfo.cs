using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public class StudentInfo:PersonalInfo
    {
        //field 
        private static int s_registerNumber=1000;
        //property
        public string RegisterNumber{get;}
        public string Standard{get;set;}
        public string Branch{get;set;}
        public int AcademicYear{get;set;}

        //constructor
        public StudentInfo(string name,string fatherName,long phoneNumber,string mail,DateTime dob,string gender,
        string standard,string branch,int academicYear):base(name,fatherName,phoneNumber,mail,dob,gender)
        {
            s_registerNumber++;
            RegisterNumber="RID"+s_registerNumber;
            Standard=standard;
            Branch=branch;
            AcademicYear=academicYear;
        }

      //method
        public void ShowStudentInfo()
        {
            Console.WriteLine($"Name: {Name} \nFatherName: {FatherName} \nPhoneNumber: {PhoneNumber} \nMail {Mail} \nDOB: {DOB} \nGender: {Gender} \nRegisterNumber: {RegisterNumber}\nStandard: {Standard} \nBranch: {Branch} \nAcademicYear: {AcademicYear}");
        }
    }
}