using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class DoctorInfo:PatientInfo //PatientInfo has been sealed so it can't be inherited and used in another class
    {
        private static int s_doctorID=2000;
        public string DoctorID{get;}
        public string Name{get;set;}
        public string FatherName{get;set;}

        public DoctorInfo(string name,string fatherName)
        {
            s_doctorID++;
            DoctorID="DID"+s_doctorID;
            Name=name;
            FatherName=fatherName;

        }
        public void DisplayInfo()
        {
            Console.WriteLine("*******Doctor Info*******");
            Console.WriteLine($"DoctorID: {DoctorID} \nName: {Name} \nFatherName: {FatherName}");
        }
    }
}