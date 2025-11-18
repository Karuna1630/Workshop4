using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    internal class Student
    {
        //creating instance fields
        public int id;
        public int age;
        public string? name;

        // Static field
        public static int totalStudents = 0;

        // Constructor to increase static count each time object is created
        public Student()
        {
            totalStudents++;
        }
    }
}
