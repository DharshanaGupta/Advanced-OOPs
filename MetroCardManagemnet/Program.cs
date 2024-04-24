using System;
using MetroCardManagemnet;
namespace MetroCardmanagement;
class Program 
{
    public static void Main(string[] args)
    {
        FileHandling.Create();
        //Operations.AddDefaultData();
        FileHandling.ReadFromCSV();
        Operations.MainMenu();
        FileHandling.WriteToCSV();
    }
}