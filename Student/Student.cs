using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Student : Person
    {
        //Tao thuoc tinh
        public int ID;
        public float Mark;

        //Tao constructor khong tham so
        public Student() { }

        //Tao constructor co tham so
        public Student(int id, string fullName, float mark, string faculty) : base(faculty, fullName)
        {
            ID = id;
            Mark = mark;
         
        }

        //ham nhap mot Student
        public override void Input()
        {
            base.Input();//goi thuoc tinh cua lop Person
            Console.WriteLine("ID :=");
            //nhap them thuoc tinh xu ly cho lop Student
            this.Mark = float.Parse(Console.ReadLine());
            Console.WriteLine("Mark :=");
            this.Faculty = Console.ReadLine();
        }

        // ham xuat mot Student
        public override void OutPut()
        {
            base.OutPut();//goi ham xuat cua lop Person
            Console.WriteLine("ID := {2} \n Mark := {3}\n",
                 this.ID, this.Mark);
        }
    }
}
