using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public class PrincipalInfo:PersonalInfo
    {
        /*Properties: PrincipalID, Qualification, YearOfExperience, DateOfJoining

        Methods: ShowDetails*/

        private static int s_principalID=3000;
        public string PrincipalID{get;}
        public string Qualification{get;set;}
        public int Experience{get;set;}
        public DateTime DateOfJoining{get;set;}

        public PrincipalInfo(string name,string fatherName,DateTime dob,long phone,string mail,string qualification,
        int experience,DateTime dateOfJoining):base(name,fatherName,dob,phone,mail)
        {
            s_principalID++;
            PrincipalID="PID"+s_principalID;
            Qualification=qualification;
            Experience=experience;
            DateOfJoining=dateOfJoining;

        }

        public void ShowDetails()
        {
            Console.WriteLine($"Name: {Name} \nFatherName: {FatherName} \nDOB: {DOB} \nPhone: {Phone} \nMail: {Mail}");
            Console.WriteLine($"PrincipalID: {PrincipalID} \nQualification: {Qualification} \nExperience: {Experience} \nDateOfJoining: {DateOfJoining}");
        }
    }
}