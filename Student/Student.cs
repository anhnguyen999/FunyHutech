using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student:Person
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

        public void Input()
        {
            Console.Write("ID = ");
            StudentID = int.Parse(Console.ReadLine());
            
            Console.Write("Mark = ");
            Mark = float.Parse(Console.ReadLine());
            Console.Write("Name Student = ");
            FullName = Console.ReadLine();
            Console.Write("Faculty = ");
            Faculty = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine("ID = {0} \nName Student = {1} \nMark = {2} \nFaculty = {3} \n", this.StudentID, this.FullName, this.Mark, this.Faculty);
        }
    }
}
