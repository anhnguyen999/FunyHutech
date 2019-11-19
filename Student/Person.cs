using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Person
    {//
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
        }
}
