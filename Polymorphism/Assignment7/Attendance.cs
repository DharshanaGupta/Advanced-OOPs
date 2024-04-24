using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment7
{
    public class Attendance
    {
        
        public int TotalWorkingDays{get;set;}
        public int NumberOfLeavesTaken{get;set;}
        public int NumberOfPermissions{get; set;}


        public Attendance(int totalWorkingDays,int numberOfLeavesTaken,int numberOfPermissions)
        {
            TotalWorkingDays=totalWorkingDays;
            NumberOfLeavesTaken=numberOfLeavesTaken;
            NumberOfPermissions=numberOfPermissions;
        }
        public void Display()
        {
            Console.WriteLine($"TotalWorkingDays: {TotalWorkingDays} \nNumberOfLeavesTaken: {NumberOfLeavesTaken} \nNumberOfPermissions: {NumberOfPermissions} \nSalary: {(TotalWorkingDays-NumberOfLeavesTaken-NumberOfPermissions)*500}");
        }
    
    }
}