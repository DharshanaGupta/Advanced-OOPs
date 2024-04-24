
using System;
using System.Runtime.Intrinsics.Arm;
namespace Assignment2;
class Program 
{
    public static void Main(string[] args)
    {
        StudentMethods.StudentInfo s1=new StudentMethods.StudentInfo();
        s1.Display("1001","dharshana","Female",new DateTime(2002,10,12),"123456789",80,80,80);
        s1.Calculate(80,80,80);
    }
    
    
}