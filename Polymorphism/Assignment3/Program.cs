using System;
namespace Assignment3;
class Program 
{
    public static void Main(string[] args)
    {
        EEEDepartment dep1=new EEEDepartment();
        dep1.SetBookInfo("xxx","Circuit","zzzz",2010);
        dep1.DisplayInfo();

        CSEDepartment dep2=new CSEDepartment();
        dep2.SetBookInfo("yyyy","Software Testing","fffff",1998);
        dep2.DisplayInfo();
    }
}