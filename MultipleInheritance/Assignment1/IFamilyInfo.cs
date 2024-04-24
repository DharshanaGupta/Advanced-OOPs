using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public interface IFamilyInfo:IShowData
    {
        /* FatherName, MotherName, HouseAddress, No.Of.Siblings  

        Method: ShowInfo*/
        public string FatherName{get;set;}
        public string MotherName{get;set;}
        public string Address{get;set;}
        public int NoOfSiblings{get;set;}

        new void ShowInfo();
    }
}