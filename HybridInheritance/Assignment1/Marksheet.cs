using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Marksheet:TheoryMarks,ICalaculate
    {
        //MarksheetNumber, DateOfIssue, Total, Percentage

        public double _projectmark;
        private static int s_markSheetNumber=2000;
        

        public double ProjectMark{get{return _projectmark;}set{_projectmark=value;}}
        
        public string MarksheetNumber{get;}
        public DateTime DateOfIssue{get;set;}
        public double Total{get;set;}
        public double Percentage{get;set;}

        public Marksheet(string name,string fatherName,long phone,DateTime dob,string gender,int[] sem1, int[] sem2,int[] sem3,int[] sem4,double projectMark,DateTime dateOfIsuuse/*,double total,double percentage*/):base(name,fatherName,phone,dob,gender,sem1,sem2,sem3,sem4)
        {
            s_markSheetNumber++;
            MarksheetNumber="MID"+s_markSheetNumber;
            DateOfIssue=dateOfIsuuse;
            ProjectMark=projectMark;
        }
        public void CalculateUG()
        {
            for(int i=0;i<6;i++)
            {
                Total+=Sem1[i]+Sem2[i]+Sem3[i]+Sem4[i];
            }
            Percentage=(double)(Total+ProjectMark)/25;
        }

        public void ShowUGMarksheet()
        {
            Console.WriteLine("************UGMarksheet***********");
            Console.WriteLine($"Name: {Name} \nFatherName: {FatherName} \nPhone: {Phone} \nDOB: {DOB} \nGender: {Gender}");
            Console.WriteLine($"MarksheetNumber: {MarksheetNumber} \nProjectMark: {ProjectMark} \nTotal: {Total} \nPercentage: {Percentage}");
        }
    }
}