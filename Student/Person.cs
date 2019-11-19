using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Person
    {
        protected  string FullName { get; set; }
        protected string Faculty { get; set; }
        public Person()
        {

        }
        public Person(String fullName,String faculty)
        {
            FullName = fullName;
            Faculty = faculty;
        }
    }
}
