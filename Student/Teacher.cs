using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Teacher : Person
    {
        public double Salary { get; set; }
        public Teacher()
        {

        }
        public Teacher(double salary)
        {
            Salary = salary;
        }

        public void Input()
        {
            Console.Write("Salary = ");
            this.Salary = double.Parse(Console.ReadLine());
        }
    }
}
