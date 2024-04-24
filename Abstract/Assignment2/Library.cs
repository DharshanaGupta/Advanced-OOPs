using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;

namespace Assignment2
{
    public abstract class Library
    {
        private static int s_serialNumber=1000;

        public string SerialNumber{get;}
        public abstract string AuthorName{get;set;}
        public abstract string BookName{get;set;}
        public abstract string PublisherName{get;set;}
        public abstract int Year{get;set;}

        public Library()
        {
            s_serialNumber++;
            SerialNumber="LIB"+s_serialNumber;
        }
        public abstract void SetBookInfo(string AuthorName,string BookName,string PublisherName,int Year);
        public abstract void DisplayInfo();
    }
}