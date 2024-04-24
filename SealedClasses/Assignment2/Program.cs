using System;
namespace Assignment2;
class Program 
{
    public static void Main(string[] args)
    {
        PatientInfo patient=new PatientInfo("xxx","yyyy",46,"chennai","surgery");
        patient.DisplayInfo();
        DoctorInfo doctor=new DoctorInfo("yyyy","sdfg");
        doctor.DisplayInfo();
    }
}
