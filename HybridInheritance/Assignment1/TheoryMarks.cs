using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Threading.Tasks;

namespace Assignment1
{
    public class TheoryMarks:PersonalInfo
    {
        
        public  int[] Sem1{get;set;}
        public  int[] Sem2{get;set;}
        public int[] Sem3{get;set;}
        public int[] Sem4{get;set;}


        public TheoryMarks(string name,string fatherName,long phone,DateTime dob,string gender,int[] sem1,int[] sem2,int[] sem3,int[] sem4):base(name,fatherName,phone,dob,gender)
        {
            Sem1=sem1;

            Sem2=sem2;
            Sem3=sem3;
            Sem4=sem4;
        }

        
    }
}