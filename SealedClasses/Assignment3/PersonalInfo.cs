using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3
{
    public class PersonalInfo
    {
        /*Properties: Name, FatherName, Mobile, Mail, Gender

        Method: virtual Update, DisplayInfo*/

        public string Name{get;set;}
        public string FatherName{get;set;}
        public long Mobile{get;set;}
        public string Gender{get;set;}
        public PersonalInfo(string name,string fatherName,int mobile,string gender)
        {
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
            Gender=gender;
        }

        public virtual void Update(string name,string fatherName,int mobile,string gender)
        {
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
            Gender=gender;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name} \nFatherName: {FatherName} \nMobile: {Mobile} \nGender: {Gender}");
        }

    }
}