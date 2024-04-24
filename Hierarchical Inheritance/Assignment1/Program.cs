using System;
using System.Threading.Tasks.Dataflow;
namespace Assignment1;
class Program 
{
    public static void Main(string[] args)
    {
        Teacher teacher=new Teacher("xxxx","sdfg",new DateTime(1980,05,11),123456789,"sdfghj@mail.com","CSE","Software Engineering","MBA",4,new DateTime(2000,08,04));
        teacher.ShowDetails();
        StudentInfo student=new StudentInfo("sdfg","dfghj",new DateTime(2020,05,11),1234567890,"dfg@mail.com","BTECH","IT",6);
        student.ShowDetails();
        PrincipalInfo principal=new PrincipalInfo("sdfg","wertyu",new DateTime(1978,07,21),1234567890,"wsyijh@mail.com","MBA,Phd",10,new DateTime(2010,05,11));
        principal.ShowDetails();
    }
}