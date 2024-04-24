using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public class StudentInfo:PersonalInfo
    {
        //property
        private static int s_registerNumber=1000;
        //property
        public string RegisterNumber{get;}
        public string Standard{get;set;}
        public string Branch{get;set;}
        public int AcademicYear{get;set;}

        //constructor
        public StudentInfo(string name,string fatherName,long phoneNumber,string mail,DateTime dob,string gender,string standard,string branch,int academicYear):base(name,fatherName,phoneNumber,mail,dob,gender)
        {
            s_registerNumber++;
            RegisterNumber="RID"+s_registerNumber;
            Standard=standard;
            Branch=branch;
            AcademicYear=academicYear;
        }
        

        //method
        public void GetStudentInfo()
        {
            Console.Write("Name: ");
            Name=Console.ReadLine();
            Console.Write("FtaherName: ");
            FatherName=Console.ReadLine();
            Console.Write("PhoneNumber: ");
            PhoneNumber=long.Parse(Console.ReadLine());
            Console.Write("Mail: ");
            Mail=Console.ReadLine();
            Console.Write("DOB in dd/MM/yyyy : ");
            DOB=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            Console.Write("Gender: ");
            Gender=Console.ReadLine();
            Console.Write("Standard: ");
            Standard=Console.ReadLine();
            Console.Write("Branch: ");
            Branch=Console.ReadLine();
            Console.Write("AcademicYear: ");
            AcademicYear=int.Parse(Console.ReadLine());
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine("************************");
            Console.WriteLine("Showing Student details");
            Console.WriteLine("************************");
            Console.WriteLine($"StudentID: {RegisterNumber} \nName: {Name} \nFatherName: {FatherName} \nPhoneNumber: {PhoneNumber} \nMail: {Mail} \nDOB: {DOB} \nGender: {Gender} \nStandard: {Standard} \nBranch: {Branch} \nAcademicYear: {AcademicYear}");
        }
        
    }
}