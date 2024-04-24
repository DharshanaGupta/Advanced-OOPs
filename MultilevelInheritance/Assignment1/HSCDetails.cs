using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public class HSCDetails:StudentInfo
    {
        //HSCMarksheetNumber, Physics, Chemistry, Maths, Total, Percentage marks
        private static int hSCMarksheetNumber=2000;

        public string HSCMarksheetNumber{get;}
        public int Physics{get;set;}
        public int Chemistry{get;set;}
        public int Maths{get;set;}
        public int Total{get;set;}
        public double Percentage{get;set;}

        public HSCDetails(string name,string fatherName,long phoneNumber,string mail,DateTime dob,string gender,string standard,string branch,int academicYear,int physics,int chemistry,int maths,int total,double percent):base(name,fatherName,phoneNumber,mail,dob,gender,standard,branch,academicYear)
        {
            hSCMarksheetNumber++;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
            Total=total;
            Percentage=percent;
        }
        //method
        public void GetMarks()
        {
            Console.WriteLine("*****Getting Student Marks*****");
            Console.WriteLine("Physics mark: ");
            Physics=int.Parse(Console.ReadLine());
            Console.WriteLine("Chemistry mark: ");
            Chemistry=int.Parse(Console.ReadLine());
            Console.WriteLine("Maths: ");
            Maths=int.Parse(Console.ReadLine());
        }

        public void Calculate()
        {
            Total=Physics+Chemistry+Maths;
            Percentage=(double)Total/3;
            Percentage=Math.Round(Percentage,2);
        }

        public void ShowMarkSheet()
        {
            Console.WriteLine("**********MarkSheet*********");
            Console.WriteLine($"MarksheetNumber: {HSCMarksheetNumber} \nPhysics: {Physics} \nChemistry: {Chemistry} \nMaths: {Maths} \nTotal: {Total} \nPercentage: {Percentage}");
        }
    }
}