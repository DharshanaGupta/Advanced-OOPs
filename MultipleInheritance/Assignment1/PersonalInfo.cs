using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public class PersonalInfo:IShowData
    {
        /*Properties: Name, Gender,DOB, phone, mobile, Marital details – Married/single

        Method: ShowInfo*/

        public string Name{get;set;}
        public string Gender{get;set;}
        public DateTime DOB{get;set;}
        public long Phone{get;set;}
        public string MaritalDetail{get;set;}

        public PersonalInfo(string name,string gender,DateTime dob,long phone,string maritalDetail)
        {
            Name=name;
            Gender=gender;
            DOB=dob;
            Phone=phone;
            MaritalDetail=maritalDetail;

        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} \nGender: {Gender} \nDOB: {DOB} \nPhone: {Phone} \nMaritalDetail: {MaritalDetail}");
        }
    }
}