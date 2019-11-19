using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student : person
    {
        public int StudentID { get; set; }
        
        public float Mark { get; set; }
        
        public Student()
        {

        }

        public Student(int studentID, string fullName, float mark, string faculty)
            :base(fullName,faculty)
        {
            StudentID = studentID;
           
            Mark = mark;
      
        }
        internal void Input()
        {
            
            Console.Write("ID = ");
            this.StudentID = int.Parse(Console.ReadLine());

            Console.Write("Fullname = ");
            this.FullName = Console.ReadLine();

            Console.Write("Mark = ");
            this.Mark = int.Parse(Console.ReadLine());

            Console.Write("Faculty = ");
            this.Faculty = Console.ReadLine();
        }
    }
}