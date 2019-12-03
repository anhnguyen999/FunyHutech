﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{

    //Nguyen Hoang Tu
    //Nguyen Hoang Phuc
    //Nguyen Thai Hung Vuong
    class Student : Person
    {
        public int StudentID { get; set; }

        public float Mark { get; set; }


        public Student()
        {

        }

        public Student(int studentID, string fullName, float mark, string faculty)
            : base(fullName, faculty)
        {
            StudentID = studentID;

            Mark = mark;

            Console.WriteLine("- Student(int,int,int)");
        }

        public override void Input()
        {
            base.Input();
            Console.Write("ID = ");
            this.StudentID = int.Parse(Console.ReadLine());
            //tuong tu nhap cho cac thuoc tinh khac
            Console.Write("Mark = ");
            this.Mark = float.Parse(Console.ReadLine());
        }
    }
}
