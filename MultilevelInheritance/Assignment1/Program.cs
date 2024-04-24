using System;
namespace Assignment1;
class Program 
{
    public static void Main(string[] args)
    {
        PersonalInfo person1=new PersonalInfo("Dharshana","Ramesh",1234567890,"sdfg@mail.com",new DateTime(2002,11,04),"Female");
        StudentInfo student1=new StudentInfo(person1.Name,person1.FatherName,person1.PhoneNumber,person1.Mail,person1.DOB,person1.Gender,"B.Tech","IT",4);
        HSCDetails studentfirst=new HSCDetails(person1.Name,person1.FatherName,person1.PhoneNumber,person1.Mail,person1.DOB,person1.Gender,student1.Standard,student1.Branch,student1.AcademicYear,80,80,80,240,80);
        studentfirst.GetStudentInfo();
        studentfirst.ShowStudentInfo();
        studentfirst.GetMarks();
        studentfirst.Calculate();
        Console.WriteLine("Do you want to show the HSC marksheet yes/no");
        string wantToSee=Console.ReadLine();
        if(wantToSee=="yes")
        {
            studentfirst.ShowMarkSheet();
        }

        HSCDetails studentsecond=new HSCDetails(person1.Name,person1.FatherName,person1.PhoneNumber,person1.Mail,person1.DOB,person1.Gender,student1.Standard,student1.Branch,student1.AcademicYear,80,80,80,240,80);
        studentfirst.GetStudentInfo();
        studentfirst.ShowStudentInfo();
        studentfirst.GetMarks();
        studentfirst.Calculate();
        Console.WriteLine("Do you want to show the HSC marksheet yes/no");
        string seeMarkSheet=Console.ReadLine();
        if(seeMarkSheet=="yes")
        {
            studentfirst.ShowMarkSheet();
        }
    }
}