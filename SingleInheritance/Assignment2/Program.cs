using System;
namespace Assignment2;
class Program 
{
    public static void Main(string[] args)
    {
        AccountInfo customer1=new AccountInfo("Dharshana","Ramesh",123456987,"sdfg@mail.com",new DateTime(2002/09/11),"Female","1234567890","Chennai","HDFC1234",10000);
        AccountInfo customer2=new AccountInfo("xxxx","yyyy",123456789,"dfgh@mail.com",new DateTime(2001,04,12),"Male","12345678098","Chennai","HDFC1234",5000);
        AccountInfo customer3=new AccountInfo("yyyy","zzzz",1234567890,"asdf@mail.com",new DateTime(2001,05,14),"Female","1234567890","Chennai","HDFC1234",8500);
        customer1.ShowAccountInfo();
        Console.WriteLine("*****************");
        customer2.ShowAccountInfo();
        Console.WriteLine("*****************");
        customer3.ShowAccountInfo();

        

        customer1.Deposit();
        customer2.Deposit();
        customer3.Deposit();

        customer1.Withdraw();
        customer2.Withdraw();
        customer3.Withdraw();

        customer1.ShowBalance();
        customer2.ShowBalance();
        customer3.ShowBalance();

    }
}
    

