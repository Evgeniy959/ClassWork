using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUsingAutoProperties
{
    public class Student
    {
        public Person Person { get; set; }
        public string Faculty { get; set; }

        public Student () { }

        public Student(Person person, string faculty)
        {
            Person = person;
            Faculty = faculty;            
        }
        /*public Student(Person person)
        {
            student = person.Name;
            Age = person.Age;
        }*/

    }

    
}
