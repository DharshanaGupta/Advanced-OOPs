using System;
using System.Security.Cryptography.X509Certificates;
namespace Assignment1;
class Program 
{
    public static void Main(string[] args)
    {
        int[] sem1={80,75,68,70,88,74};
        int[] sem2={80,75,68,70,88,74};
        int[] sem3={80,75,68,70,88,74};
        int[] sem4={80,75,68,70,88,74};
        PersonalInfo person1=new PersonalInfo("Dharshana","ramesh",1234567,new DateTime(2002,11,04),"female");
        PersonalInfo person2=new PersonalInfo("Dharshana","ramesh",1234567,new DateTime(2002,11,04),"female");
        Marksheet marksheet1=new Marksheet(person1.Name,person1.FatherName,person1.Phone,person1.DOB,person1.Gender,sem1,sem2,sem3,sem4,89,DateTime.Now);
        Marksheet marksheet2=new Marksheet(person2.Name,person2.FatherName,person2.Phone,person2.DOB,person2.Gender,sem1,sem2,sem3,sem4,85,DateTime.Now);
        marksheet1.CalculateUG();
        marksheet1.ShowUGMarksheet();
        marksheet2.CalculateUG();
        marksheet2.ShowUGMarksheet();
        
        
    }
    
            
            
}
