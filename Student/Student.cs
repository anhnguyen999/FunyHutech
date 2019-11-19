using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public float Mark { get; set; }
        public string Faculty { get; set; }

        public Student()
        {

        }

        public Student(int studentID, string fullName, float mark, string faculty)
        {
            StudentID = studentID;
            FullName = fullName;
            Mark = mark;
            Faculty = faculty;
        }

        //INPUT A STUDENT
        public void Input()
        {
            Console.Write("ID: ");
            StudentID = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            FullName = Console.ReadLine();
            Console.Write("Mark: ");
            Mark = float.Parse(Console.ReadLine());
            Console.Write("Faculty: ");
            Faculty = Console.ReadLine();
        }

        //SHOW A STUDENT
        public void Show()
        {
            Console.WriteLine("ID: {0}\nName: {1}\nMark: {2}\nFaculty: {3}", this.StudentID, this.FullName, this.Mark, this.Faculty);
        }
    }
}
