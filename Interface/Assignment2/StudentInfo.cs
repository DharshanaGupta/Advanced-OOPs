using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class StudentInfo:IDisplayInfo
    {

        private static int s_studentID=1000;

        public string StudentID{get;}
        public string Name{get;set;}
        public string FatherName{get;set;}
        public long Phone{get;set;}
        public StudentInfo(string name,string fathername,long phone)
        {
            s_studentID++;
            StudentID="SID"+s_studentID;
            Name=name;
            FatherName=fathername;
            Phone=phone;

        }
        public void Display()
        {
            Console.WriteLine($"StudentID: {StudentID} \nName: {Name} \nFatherName: {FatherName} \nPhone: {Phone}");
            
        }
    }
}