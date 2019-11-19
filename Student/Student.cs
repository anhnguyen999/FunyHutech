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

        public Student(int studentID,string fullName, float mark, string faculty):base(fullName, faculty)
        {
            StudentID = studentID;
            Mark = mark;
        }

        //INPUT A STUDENT
        public void Input()
        {
            Console.Write("ID: ");
            StudentID = int.Parse(Console.ReadLine());
            Console.Write("Mark: ");
            Mark = float.Parse(Console.ReadLine());
            InputPerson();
            Console.WriteLine();
        }

        //SHOW A STUDENT
        public void Show()
        {
            Console.WriteLine("ID: {0}", this.StudentID);
            Console.WriteLine("Mark: {0}", this.Mark);
            ShowPerson();
        }
    }
}
