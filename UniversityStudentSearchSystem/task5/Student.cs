using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Student
    {
        public static List<Student> students = new List<Student>();
        public static int Count;
        public Student(string name, string gender, string number, int age)
        {
            fullName = name;
            studentGender = gender;
            groupNo = number;
            Age = age;
            Count++;
            No = Count;
        }
        public string fullName { get; set; }
        public int Age {get; set;}
        public string studentGender { get; set;}
        public string groupNo { get; set;}
        public int No { get; set;}
    }
}
