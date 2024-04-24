using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class CSEdepartment:Library
    {
        private string authorName;
        private string bookName;
        private string publisherName;
        private int year;

        public override string AuthorName{get{return authorName;}set{authorName=value;}}
        public override string BookName{get{return bookName;}set{bookName=value;}}
        public override string PublisherName{get{return publisherName;}set{publisherName=value;}}
        public override int Year{get{return year;}set{year=value;}}

        public override void SetBookInfo(string authorName,string bookName,string publisherName,int year)
        {
            AuthorName=authorName;
            BookName=bookName;
            PublisherName=publisherName;
            Year=year;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("*********Book Info of CSE**********");
            Console.WriteLine($"SerialNumber: {SerialNumber} \nAuthorname: {AuthorName} \nBookName: {BookName} \nPublisherName: {PublisherName} \nYear: {year}");
        }
        
    }
}