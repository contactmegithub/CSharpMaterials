using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVCApplication.Models
{
    public class Student
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string gender { get; set; }
        public string age { get; set; }
        public string contact { get; set; }
    }
}