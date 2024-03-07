using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> student = new List<Student>();
            //student.Add(new {})


            Student student1 = new Student("Kate", "female", "17785218", 28);
            Student student2 = new Student("Heyder", "male", "18870001", 24);
            Student student3 = new Student("Gerald", "male", "15975387", 29);
            Student student4 = new Student("Polina", "female", "95135784", 22);
            Student student5 = new Student("Diana", "female", "82443417", 32);
            Student student6 = new Student("Muller", "male", "48623980", 31);

            student.Add(student1);
            student.Add(student2);
            student.Add(student3);
            student.Add(student4);
            student.Add(student5);
            student.Add(student6);

            bool exit = true;

            while (exit)
            {
                Console.WriteLine("1- Add New Student");
                Console.WriteLine("2- Look All Student List");
                Console.WriteLine("3- Remove");
                Console.WriteLine("4- Edit");
                Console.WriteLine("5- Exit");

                Console.WriteLine("Select Option");
                char operation = Convert.ToChar(Console.ReadLine());
                switch (operation)
                {
                    case '1':
                        Console.WriteLine("How many students will be added?");
                        int count = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < count; i++)
                        {
                            Console.Write("Add student name: ");
                            string fullName = Console.ReadLine();

                            Console.Write("Add gender: ");
                            string studentGender = Console.ReadLine();

                            Console.Write("Add age: ");
                            int Age = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Add college number: ");
                            string groupNumber = Console.ReadLine();

                            Student st=new Student(fullName, studentGender,groupNumber, Age);

                            student.Add(st);
                            Console.WriteLine((i + 1) + ".student added");
                            }
                        break;

                    case '2':

                        foreach( var item in student )
                        {
                            Console.WriteLine(" name: " + item.fullName + " gender: " + item.studentGender + " age: " + item.Age + " number: " + item.groupNo);
                        
                        }
                        break;

                    case '3':
                        bool bo = false;
                        Console.WriteLine("Please, edit");
                        string rmvnumber =Console.ReadLine();
                        foreach ( var item in student )

                        {
                            if (item.groupNo == rmvnumber)
                                {
                                student.Remove(item);
                                Console.WriteLine("Deleted");
                                bo = true;
                                break;
                            }
                        }
                        break;

                    case '4':

                        bool boolFound = false;
                        Console.WriteLine("Please, edit");
                        string editName = Console.ReadLine();

                        foreach (var item in student)
                        {
                            if (item.fullName == editName)
                            {
                                Console.WriteLine("Please, enter new name");
                                string newName = Console.ReadLine();
                                item.fullName = newName;
                                Console.WriteLine("new name: " + item.fullName);

                                Console.WriteLine("Please, add new gender");
                                string newGender = Console.ReadLine();
                                item.studentGender = newGender;
                                Console.WriteLine("new gender: "+ item.studentGender);

                                Console.WriteLine("Please new age");
                                int newAge = Convert.ToInt32(Console.ReadLine());
                                item.Age = newAge;
                                Console.WriteLine("new age: " + item.Age);

                                Console.WriteLine("Please, add new number");
                                string newNumber = Console.ReadLine();
                                item.groupNo = newNumber;
                                Console.WriteLine("new nuber: " + item.groupNo);



                                boolFound = true;
                                break;
                            }
                        }

                        if (!boolFound)
                        {
                            Console.WriteLine("not found");
                        }
                        break;
                    case '5':
                    exit = false;
                    Console.WriteLine("excit");
                    break;
                }
            }
        }
    }
}
