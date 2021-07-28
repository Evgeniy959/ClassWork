using System;

namespace ClassUsingAutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            //PrintPerson(person);

            person.Name = "Андрей";
            person.Age = 35;
            PrintPerson(person);

            /*Person person = new Person
            {
                Name = "Андрей",
                Age = 35
            };
            PrintPerson(person);*/

            var person2 = new Person(person);
            PrintPerson(person2);

            /*Student student = new Student();
            student.Person = person;
            student.Faculty = "SoftDev";*/

            var student = new Student
            {
                Person = person,
                Faculty = "SoftDev"
            };
            PrintStudent(student);

            static void PrintPerson(Person person)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{person.Name}, {person.Age}");
                Console.ResetColor();
            }

            static void PrintStudent(Student student)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{student.Person}, {student.Faculty}");
                Console.ResetColor();
            }
        }
    }
}

