using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public class RegisterPerson:PersonalInfo,IShowData,IFamilyInfo
    {
        private static int s_registerNumber=1000;
        private string fatherName;
        private string motherName;
        private string address;
        private int noOfSiblings;

        public string FatherName{get{return fatherName;}set{fatherName=value;}}
        public string MotherName{get{return motherName;}set{motherName=value;}}
        public string Address{get{return address;}set{address=value;}}
        public int NoOfSiblings{get{return noOfSiblings;}set{noOfSiblings=value;}}
        public string RegisterNumber{get;}
        public DateTime DateOfJoining{get;set;}

        public RegisterPerson(string name,string gender,DateTime dob,long phone,string maritalDetail,string fatherName,string motherName,string address,int noOfSiblings,
        DateTime dateOfJoining):base(name,gender,dob,phone,maritalDetail)
        {
            s_registerNumber++;
            RegisterNumber="RID"+s_registerNumber;
            DateOfJoining=dateOfJoining;
            FatherName=fatherName;
            MotherName=motherName;
            Address=address;
            NoOfSiblings=noOfSiblings;
        }

        public new void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} \nGender: {Gender} \nDOB: {DOB} \nPhone: {Phone} \nMaritalDetail: {MaritalDetail}");
            Console.WriteLine($"FatherName: {FatherName} \nMotherName: {MotherName} \nAddress: {Address} \nNoOfSiblings: {NoOfSiblings}");
            Console.WriteLine($"RegiterNumber: {RegisterNumber} \nDateOfJoining: {DateOfJoining}");
        }
    }
}