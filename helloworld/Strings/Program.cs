﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public interface ClassSwitchHelper
    {
        void Main();
    }

    public class StringClass : ClassSwitchHelper
    {
        public void Main()
        {
            //from string literal and string concatenation
            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };

            string fullname = fname + lname;
            Console.WriteLine("Full Name: {0}", fullname);

            //by using string constructor { 'H', 'e', 'l', 'l','o' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);

            //methods returning string { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);

            //formatting method to convert a value
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);
        }
    }

    public class CompareString : ClassSwitchHelper
    {
        public void Main()
        {
            string str1 = "This is test";
            string str2 = "This is text";

            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            }
            Console.ReadKey();
        }
    }

    public class Contains : ClassSwitchHelper
    {
        public void Main()
        {
            string str = "This is test";

            if (str.Contains("test"))
            {
                Console.WriteLine("The sequence 'test' was found.");
            }
            Console.ReadKey();
        }
    }

    public class Substring : ClassSwitchHelper
    {
        public void Main()
        {
            string str = "Last night I dreamt of San Pedro";
            Console.WriteLine(str);
            string substr = str.Substring(23);
            Console.WriteLine(substr);
        }
    }

    public class StringJoin : ClassSwitchHelper
    {
        public void Main()
        {
            string[] starray = new string[]{"Down the way nights are dark",
            "And the sun shines daily on the mountain top",
            "I took a trip on a sailing ship",
            "And when I reached Jamaica",
            "I made a stop"};

            string str = String.Join("\n", starray);
            Console.WriteLine(str);
        }
    }

    public class OtherStringOperation : ClassSwitchHelper
    {
        public void Main()
        {
            string stringsample = string.Empty;

            var chararray = stringsample.ToCharArray();

            var stringLower  = stringsample.ToLower();

            Console.WriteLine(stringLower);

            var stringUpper  = stringsample.ToLower();

            Console.WriteLine(stringUpper);

            var stringTrim = stringsample.Trim();

            Console.WriteLine(stringTrim);

            var stringTrimEnd = stringsample.TrimEnd();

            Console.WriteLine(stringTrimEnd);

            var stringTrimStart = stringsample.TrimStart();

            Console.WriteLine(stringTrimStart);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassSwitchHelper _ClassSwitchHelper = new StringClass();
            _ClassSwitchHelper.Main();
        }
    }
}
