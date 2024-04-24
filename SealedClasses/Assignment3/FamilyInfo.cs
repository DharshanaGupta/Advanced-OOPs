using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3
{
    public class FamilyInfo:PersonalInfo
    {
        /*Properties: FatherName, MotherName, NoOfSiblings, NativePlace

        Method: Sealed override Update, DisplayInfo*/

        public new string FatherName{get;set;}
        public string MotherName{get;set;}
        public int NoOfSiblings{get;set;}
        public string NativePlace{get;set;}

        public FamilyInfo(string name,string fatherName,int mobile,string gender,string father,string motherName,int noOfSiblings,string nativePlace):base(name,fatherName,mobile,gender)
        {
            FatherName=father;
            MotherName=motherName;
            NoOfSiblings=noOfSiblings;
            NativePlace=nativePlace;
        }
        public sealed override void Update(string fatherName,string motherName,int noOfSiblings,string nativePlace)
        {

            FatherName=fatherName;
            MotherName=motherName;
            NoOfSiblings=noOfSiblings;
            NativePlace=nativePlace;
            
        }
        public new void DisplayInfo()
        {
             Console.WriteLine($"Name: {Name} \nFatherName: {FatherName} \nMobile: {Mobile} \nGender: {Gender}");
            Console.WriteLine($"FatherName: {FatherName} \nMotherName: {MotherName} \nNoOfSiblings: {NoOfSiblings} \nNativePlace: {NativePlace}");
        }
    }
}