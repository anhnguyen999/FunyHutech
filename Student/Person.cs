using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    abstract class Person
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
        public virtual void Input()
        {
            Console.Write("Name: ");
            FullName = Console.ReadLine();
            Console.Write("Faculty: ");
            Faculty = Console.ReadLine();
        }

        //SHOW PERSON FULLNAME + FACULTY
        public virtual void Show()
        {
            Console.WriteLine("Name: {0}", this.FullName);
            Console.WriteLine("Faculty: {0}", this.Faculty);
        }

    }
}
