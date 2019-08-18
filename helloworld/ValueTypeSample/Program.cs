using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeSample
{

    public class TypeConversion
    {
        public void Converter()
        {
            double percentageMark = 150.68;
            int percentage = Convert.ToInt32(percentageMark);

            string test = "100dsfg";

            int testConvert = 0;
            var result = int.TryParse(test, out testConvert);
        }
    }
    public class Students
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }


    public class VvsRDifferences
    {
        public void testMethod()
        {
            int number = 100;
            int number2 = number;


            number2 = number2 + 10;


            Students students = new Students()
            {
                Address = "Address",
                Age = "25",
                Contact = "7894653213",
                Department = "Civil",
                Email = "gamnil.gmail.com",
                Name = "ReferenceType",
                Gender = "Male"
            };

            Students students2 = students;
            students2.Name = "Second Object";
        }
    }



    public struct Book
    {
        public string Name { get; set; }
        public string Language { get; set; }
        public string Authour { get; set; }
        public string PublisherName { get; set; }
        public string Pages { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
    }
    public enum Gender
    {
        Male,
        Female,
        Trans
    }
    class Program
    {
        public void AddBookToLibrary(string Name, string Language, string Authour, string PublisherName, string Pages, string Title, string Year)
        {
            // Logic that add book to library
        }
        public void AddBookToLibrary_V2(Book book)
        {
            // Logic that add book to library
        }
        public void AddBookToLibrary_V3(List<Book> book)
        {
            // Logic that add book to library
        }

        public void GetDiscount(int Age, Gender Gender)
        {
            if (Gender == Gender.Male)
            {
                //Apply 10% discount
            }
            if (Gender == Gender.Female)
            {
                //Apply 30% discount
            }
            if (Gender == Gender.Trans)
            {
                //Apply 70% discount
            }
        }
        public static void Main(string[] args)
        {

            VvsRDifferences _VvsRDifferences = new VvsRDifferences();
            _VvsRDifferences.testMethod();


            int test1 = 0;
            double test2 = 0;
            float test3 = 0;
            long test4 = 0;
            char test5 = 'a';
            string test6 = "Test Stringfgnasdg";

            Program _Program = new Program();
            _Program.AddBookToLibrary("", "", "", "", "", "", "");

            Book _Book = new Book()
            {
                Authour = "",
                Language = "",
                Name = "",
                Pages = "",
                PublisherName = "",
                Title = "",
                Year = "",
            };
            _Program.AddBookToLibrary_V2(_Book);



            _Program.GetDiscount(50, 0);
        }
    }
}

