using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Teacher:PersonalInfo
    {
        /*Properties: TeacherID, Department, Subject teaching, Qualification, YearOfExperience, DateOfJoining

        Methods:  ShowDetails*/

        private static int s_teacherID=1000;
        public string TeacherID{get;}
        public string Department{get;set;}
        public string Subject{get;set;}
        public string Qualification{get;set;}
        public int Experience{get;set;}
        public DateTime DateOfJoining{get;set;}

        public Teacher(string name,string fatherName,DateTime dob,long phone,string mail,string department,string subject,string qualification,
        int experience,DateTime dateOfJoining):base(name,fatherName,dob,phone,mail)
        {
            s_teacherID++;
            TeacherID="TID"+s_teacherID;
            Department=department;
            Subject=subject;
            Qualification=qualification;
            Experience=experience;
            DateOfJoining=dateOfJoining;

        }

        public void ShowDetails()
        {
            Console.WriteLine($"Name: {Name} \nFatherName: {FatherName} \nDOB: {DOB} \nPhone: {Phone} \nMail: {Mail}");
            Console.WriteLine($"TeacherID: {TeacherID} \nDepartment: {Department} \nSubject: {Subject} \nQualification: {Qualification} \nExperience: {Experience} \nDateOfJoining: {DateOfJoining}");
        }
    }
}