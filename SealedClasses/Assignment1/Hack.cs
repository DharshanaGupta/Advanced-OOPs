using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Hack:EmployeeInfo//the EmployeeInfo class is sealed so it can't be inherited
    {
        /*Properties: StoreUserID, StorePassword

        Method: ShowKeyInfo, GetUserInfo, ShowUserInfo*/ 
        public string StoreUserID{get;set;}
        public string StorePassword{get;set;}
        public void ShowKeyInfo()
        {
            
        }
        public void GetUserInfo()
        {

        }
        public void ShowUserInfo()
        {

        }
    }
}