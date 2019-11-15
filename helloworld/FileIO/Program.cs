using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    public class Program
    {
        static void Main(string[] args)
        {
            var output = File.ReadAllText(@"C:\Users\Mohammed Yasin\Downloads\PDFtoText.txt");



            File.WriteAllText("D:\\ReadAllFiles\\testFIO.txt", "fsgstjsfkj smyujnsthnbtsynsydimduynjr");
            int i = 0;
            while (i < 5)
            {
                i++;
                File.AppendAllText("D:\\ReadAllFiles\\testFIO.txt", @"Could not connect to the test server. A firewall could be blocking the connection or the server might be having some issues. Please try again later.

Alternatively, check out our free Speedtest for Desktop apps for more reliable testing.\r\n");
            }



            var result = File.ReadAllText("D:\\ReadAllFiles\\testFIO.txt");


            var files = Directory.GetFiles("D:\\ReadAllFiles\\");


            foreach (var item in files)
            {
                var tempText = File.ReadAllText(item);

                Console.WriteLine(tempText);
            }
            Console.ReadLine();

        }
    }

    public enum Gender
    {
        Male,
        Female,
        Trans,
        Other
    }

    public struct Book
    {
        public string BookName;
        public string Author;
        public string Language;
        public string PageCount;
        public string Subject;
    }

    public class LibraryManagment
    {
        public void NewBookEntry(string BookName, string Author, string Language, string PageCount, string Subject)
        {
            /// stufs to store the new book into the existing list
        }
        public void NewBookEntryV2(Book Book)
        {

        }
    }

    public class Consumer
    {
        public void NewBookEntry()
        {
            LibraryManagment _LibraryManagment = new LibraryManagment();

            string BookName = "Harry Potter";
            string Author = "JKR";
            string Language = "English";
            string PageCount = "200";
            string Subject = "Comic";


            Book book = new Book()
            {
                BookName = "Harry Potter",
                Author = "JKR",
                Language = "English",
                PageCount = "200",
                Subject = "Comic"
            };

            _LibraryManagment.NewBookEntry(BookName,Author, Language, PageCount, Subject);


            _LibraryManagment.NewBookEntryV2(book);

        }
    }











    public class Billing
    {
        public int ApplyDiscount(int TotalSale, Gender Gender)
        {
            if (Gender == Gender.Male)
            {
                TotalSale = TotalSale - 50;
            }
            else if (Gender == Gender.Female)
            {
                TotalSale = TotalSale - 100;
            }
            return TotalSale;
        }


    }

    //public class Consumer
    //{
    //    public void GetFinalBillAmount()
    //    {
    //        Billing _Billing = new Billing();

    //        _Billing.ApplyDiscount(100, Gender.Female);
    //    }
            
    //}
}
