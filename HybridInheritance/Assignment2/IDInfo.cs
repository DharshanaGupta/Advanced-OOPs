using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class IDInfo:PersonalInfo
    {
        public string VoterID{get;set;}
        public string Aadhar{get;set;}
        public string PanID{get;set;}

        public IDInfo(string name,string gender,DateTime dob,long phone,string voterID,string aadhar,string panID):base(name,gender,dob,phone)
        {
            VoterID=voterID;
            Aadhar=aadhar;
            PanID=panID;

        }
    }
}