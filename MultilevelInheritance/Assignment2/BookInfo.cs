using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class BookInfo:RackInfo
    {
        private static int s_bookID=1000;
        //BookID, BookName, AuthorName, Price
        public string BookID{get;}
        public string BookName{get;set;}
        public string AuthorName{get;set;}
        public double Price{get;set;}

        public BookInfo(string departmentName,string degree,int rackNumber,int columnNumber,string bookName,string authorName,double price):base(departmentName,degree,rackNumber,columnNumber)
        {
            s_bookID++;
            BookID="BID"+s_bookID;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("**********Displaying Book Information*********");
            Console.WriteLine($"BookID: {BookID} \nDepartmentName: {DepartmentName} \nDegree: {Degree} \nRackNumber: {RackNumber} \ncolumnNumber: {ColumnNumber} \nBookName: {BookName} \nAuthorName: {AuthorName} \nPrice: {Price}");
        }
    }
}