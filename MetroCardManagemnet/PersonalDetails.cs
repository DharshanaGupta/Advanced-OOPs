using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagemnet
{
    public class PersonalDetails
    {
        /*Properties:UserName
       	Phone Number
        */
        public string UserName{get;set;}
        public string Phone{get;set;}

        public PersonalDetails(string username,string phone)
        {
            UserName=username;
            Phone=phone;
            
        }
        public PersonalDetails()
        {
            
        }
    }
   
}