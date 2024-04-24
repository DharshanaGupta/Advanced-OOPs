using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4
{
    public abstract class Dress
    {
        public abstract string DressType{get;set;}
        public abstract string DressName{get;set;}
        public abstract double Price{get;set;}
        public abstract double TotalPrice{get;set;}
        public abstract void GetDressInfo();
        public abstract void DisplayInfo();
    }
}