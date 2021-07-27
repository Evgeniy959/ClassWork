using System;

namespace СreatingСlassGetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            //PrintPerson(person);

            person.Name = "Андрей";
            person.GetAge() = 35;
            PrintPerson(person);

            /*Person person = new Person
            {
                _nam = "Андрей",
                age = 35
            };
            PrintPerson(person);*/

            var person2 = new Person(person);
            PrintPerson(person2);

            static void PrintPerson(Person person)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{person.GetName()}, {person.GetAge()}");
                Console.ResetColor();
            }
        }
    }
}
