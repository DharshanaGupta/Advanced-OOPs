using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public enum Gender{Select,Male,Female,Transgender};
    public class PersonalDetails
    {
        //properties
        /// <summary>
        /// property for holding Name
        /// </summary>
        /// <value></value>
        public string Name{get;set;}
        /// <summary>
        /// property for holding Father name
        /// </summary>
        /// <value></value>
        
        public string FatherName{get;set;}
        /// <summary>
        /// property for holding gender
        /// </summary>
        /// <value></value>
        public Gender Gender{get;set;}
        /// <summary>
        /// property for holding mobile number
        /// </summary>
        /// <value></value>
        public string Mobile{get;set;}
        /// <summary>
        /// property for holding date if birth
        /// </summary>
        /// <value></value>
        public DateTime DOB{get;set;}
        /// <summary>
        /// property for holding mail id
        /// </summary>
        /// <value></value>
        public string MailID{get;set;}
        /// <summary>
        /// property for holding Location of the user
        /// </summary>
        /// <value></value>
        public string Location{get;set;}

        //constructor
        /// <summary>
        /// constructor for getting details from user
        /// </summary>
        /// <param name="name"></param>
        /// <param name="fatherName"></param>
        /// <param name="gender"></param>
        /// <param name="mobile"></param>
        /// <param name="dob"></param>
        /// <param name="mailID"></param>
        /// <param name="location"></param>
        public PersonalDetails(string name,string fatherName,Gender gender,string mobile,DateTime dob,string mailID,string location)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=mobile;
            DOB=dob;
            MailID=mailID;
            Location=location;
        }
        /// <summary>
        /// constructor for file handling
        /// </summary>
        public PersonalDetails()
        {
            
        }

    }
}