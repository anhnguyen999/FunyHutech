using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Person
    {
        public string FullName { get; set; }
        public string Faculty { get; set; }
        public Person()
        {

        }
        public Person(string fullName, string faculty)
        {
            FullName = fullName;
            Faculty = faculty;
        }

        //INPUT PERSON FULLNAME + FACULTY
        public void InputPerson()
        {
            Console.Write("Name: ");
            FullName = Console.ReadLine();
            Console.Write("Faculty: ");
            Faculty = Console.ReadLine();
        }

        //SHOW PERSON FULLNAME + FACULTY
        public void ShowPerson()
        {
            Console.WriteLine("Name: {0}", this.FullName);
            Console.WriteLine("Faculty: {0}", this.Faculty);
        }

    }
}