﻿using System;
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

        internal void Input()
        {
            Console.Write("ID = ");
            this.StudentID = int.Parse(Console.ReadLine());
            Console.Write("FullName = ");
            this.FullName = Console.ReadLine();
            Console.Write("Mark = ");
            this.Mark = int.Parse(Console.ReadLine());
            Console.Write("Faculty = ");
            this.Faculty = Console.ReadLine();
        }
    }
}
