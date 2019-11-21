using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student : Person
    {
        private int StudentID { get; set; }

        private float Mark { get; set; }

        public Student()
        {

        }

        public Student(int studentID, string fullName, float mark, string faculty)
        :base(fullName, faculty)
        {
            StudentID = studentID;
        
            Mark = mark;
            Console.WriteLine("- Student(int,int,int)");
         
        }

        public Student(string fullName, string faculty) : base(fullName, faculty)
        {
           
        }

        internal void Input()
        {

            Console.Write("ID = ");
            this.StudentID = int.Parse(Console.ReadLine());

            Console.Write("Fullname = ");
            this.FullName = Console.ReadLine();

            Console.Write("Mark = ");
            this.Mark = float.Parse(Console.ReadLine());

            Console.Write("Faculty = ");
            this.Faculty = Console.ReadLine();
        }

        public void Show()
        {
            Console.WriteLine("ID: {0}\nName: {1}\nMark: {2}\nFaculty: {3}", this.StudentID, this.FullName, this.Mark, this.Faculty);
        }
       
    }
}
