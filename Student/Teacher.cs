using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Teacher
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
            Console.Write("Salary: ");
            Salary = double.Parse(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine("Salary: {0}", this.Salary);
        }
    }
}
