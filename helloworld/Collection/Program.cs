using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Collection
{
    public class Preference
    {
        public string DateFromat { get; set; }
        public string TimeFormat { get; set; }
        public string TimeZone { get; set; }
        public string Language { get; set; }
    }
    public class UserInformation
    {
        public string UserID { get; set; }
        public string Email { get; set; }
        public Preference preference { get; set; }
    }
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
    public class Program
    {
        public static void DictionarySample()
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Add(1, "dsfsadgg");

            var sfsdfsa = hashtable[1];

            Dictionary<string, object> appConfiguration = new Dictionary<string, object>();
            string[] TimeFormats = new string[] { "12", "24" };
            UserInformation _UserInformation = new UserInformation()
            {
                UserID = "ABC123",
                Email = "Test@test.com",
                preference = new Preference()
                {
                    DateFromat = "dd/MM/yyy",
                    Language = "English",
                    TimeFormat = "12",
                    TimeZone = "UTC +05:30"
                }

            };
            appConfiguration.Add("UserPreference_ABC123", _UserInformation);
            appConfiguration.Add("UserPreference_ABC124", _UserInformation);

            appConfiguration.Add("Default_TimeFormats", TimeFormats);





            var result = appConfiguration["UserPreference_ABC123"];
            var temp = appConfiguration["Default_TimeFormats"];





            Dictionary<string, Student> dict = new Dictionary<string, Student>();

            dict.Add("Key", new Student() { FirstName = "Test" });
        }
        public static void StudentSample()
        {
            var result = JsonConvert.DeserializeObject<List<Student>>(System.IO.File.ReadAllText(@"D:\ReadAllFiles\studentData.json"));

            var orderByFirstName = result.OrderBy(student => student.FirstName).Select(student => student.FirstName);
        }
        public static void ListSample()
        {
            List<string> stringList = new List<string>();
            List<string> stringList2 = new List<string>();

            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                var result = random.Next().ToString();
                stringList.Add(result);
            }
            for (int i = 0; i < 100; i++)
            {
                var result2 = random.Next().ToString();
                stringList2.Add(result2);
            }

            var ascShort = stringList2.OrderBy(e => e);
            var descShort = stringList2.OrderByDescending(e => e);
            var unionAll = stringList.Union(stringList2);
            var intresect = stringList.Intersect(stringList2);
            var leftExpect = stringList.Except(stringList2);


        }
        static void Main(string[] args)
        {
            Program.DictionarySample();
        }
    }
}
