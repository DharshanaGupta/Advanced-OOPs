using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public partial class StudentMethods
    {
        public partial class StudentInfo
        {
            public void Calculate(int Physics,int Chemistry,int Maths)
            {
                int total=Physics+Chemistry+Maths;
                Console.WriteLine("Total: "+total);
                double percent=(double)total/3;
                Console.WriteLine("Percent: "+percent);

            }

            public void Display(string studentID,string name,string gender,DateTime dob,string mobile,int physics,int chemistry,int maths)
            {
                Console.WriteLine($"Employee ID: {studentID} \nName: {name} \nGender: {gender} \nDOB: {dob} \nMobile: {mobile} \nPhysics: {physics} \nChemistry: {chemistry} \nMaths: {maths}");
            }
           
        }
    }
}