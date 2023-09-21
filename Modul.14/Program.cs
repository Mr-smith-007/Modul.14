using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTest
{
    class Program
    {

        static void Main(string[] args)
        {

            List<Student> students = new List<Student>
            {
             new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
             new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
              new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
              new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };

            var applications = from student in students
                               let yearOfBirth = DateTime.Now.Year - student.Age
                               where student.Age < 27
                               select new Application
                               {
                                   Name = student.Name,
                                   YearOfBirth = yearOfBirth,
                               };

            foreach (var app in applications)
            {
                Console.WriteLine(app.Name + " " + app.YearOfBirth);
            }
        }

    }
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Languages { get; set; }
    }

    public class Application
    {
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
    }
}