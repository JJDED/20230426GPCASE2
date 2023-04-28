using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230426GPCASE2.Codes;

internal class Utility
{
    public enum Criteria
    {
        Teacher = 0,
        Student = 1,
        Course = 2
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    public class Subjects
    {
        public string Subject { get; set; }
    }
}
