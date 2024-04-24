using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public sealed class PatientInfo
    {
        //PatientID, Name, FatherName, BedNo, NativePlace, AdmittedFor
        private static int s_patientId=1000;
        public string PatientID{get;}
        public string Name{get;set;}
        public string FatherName{get;set;}
        public int BedNo{get;set;}
        public string NativePlace{get;set;}
        public string AdmittedFor{get;set;}

        public PatientInfo(string name,string fatherName,int bedNo,string nativePlace,string admittedFor)
        {
            s_patientId++;
            PatientID="PID"+s_patientId;
            Name=name;
            FatherName=fatherName;
            BedNo=bedNo;
            NativePlace=nativePlace;
            AdmittedFor=admittedFor;

        }

        public void DisplayInfo()
        {
            Console.WriteLine("**********PatientInfo**********");
            Console.WriteLine($"PatientID: {PatientID} \nName: {Name} \nFatherName: {FatherName} \nBedNo: {BedNo} \nNativePlace: {NativePlace} \nAdmittedfor: {AdmittedFor}");
        }

    }
}