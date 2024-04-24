using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public class StudentInfo:PersonalInfo
    {
        /*Properties: StudentID, Degree, Department, semester

        Methods: ShowDetails*/
        private static int s_studentID=2000;
        public string StudentID{get;}
        public string Degree{get;set;}
        public string Department{get;set;}
        public int Semester{get;set;}

        public StudentInfo(string name,string fatherName,DateTime dob,long phone,string mail,
        string degree,string department,int semester):base(name,fatherName,dob,phone,mail)
        {
            s_studentID++;
            StudentID="SID"+s_studentID;
            Degree=degree;
            Department=department;
            Semester=semester;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Name: {Name} \nFatherName: {FatherName} \nDOB: {DOB} \nPhone: {Phone} \nMail: {Mail}");
            Console.WriteLine($"StudentID: {StudentID} \nDegree: {Degree} \nDepartment: {Department} \nSemester: {Semester}");
        }
    }
}