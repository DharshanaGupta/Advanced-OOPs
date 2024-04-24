using System;
namespace Assignment2;
class Program 
{
    public static void Main(string[] args)
    {
        BookInfo book1=new BookInfo("ECE","BE",3,5,"C++","xxxx",120);
        BookInfo book2=new BookInfo("IT","B.Tech",6,4,"Software Engineering","yyyy",130);
        BookInfo book3=new BookInfo("MECH","BE",5,2,"Design(CADD)","zzzz",100);
        book1.DisplayInfo();
        book2.DisplayInfo();
        book3.DisplayInfo();
    }
}