using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public sealed class EmployeeInfo
    {
        /*Properties: UserID, Password, KeyInfo = 100

        Methods: UpdateInfo, DisplayInfo*/

        private static int s_userID=3000;
        public string UserID{get;set;}
        public string Password{get;set;}
        public int KeyInfo{get;set;}

        public EmployeeInfo()
        {
            s_userID++;
            UserID="UID"+s_userID;
        }
        public void UpdateInfo(string password,int keyInfo)
        {
            Password=password;
            KeyInfo=keyInfo;

        }

        public void DisplayInfo()
        {
            Console.WriteLine($"UserID: {UserID} \nPasswod: {Password} \nKeyInfo: {KeyInfo}");
        }
    }
}