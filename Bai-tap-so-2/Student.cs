using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_so_2
{
    class Student : Person
    {
        //Tao thuoc tinh
        public float Mark;
        public string Faculty;

        //Tao constructor khong tham so
        public Student(){ }

        //Tao constructor co tham so
        public Student(int id, string fullName, float mark, string faculty) : base(id, fullName)
        {
            Mark = mark;
            Faculty = faculty;
        }

        //ham nhap mot Student
        public override void Input()
        {
            base.Input();//goi thuoc tinh cua lop Person
            Console.WriteLine("Mark :=");
            //nhap them thuoc tinh xu ly cho lop Student
            this.Mark = float.Parse(Console.ReadLine());
            Console.WriteLine("Faculty :=");
            this.Faculty = Console.ReadLine();
        }

        //ham xuat mot Student
        public override void OutPut()
        {
            base.OutPut();//goi ham xuat cua lop Person
            Console.WriteLine("Mark := {2} \n Faculty := {3}\n", 
                 this.Mark, this.Faculty);
        }
    }
}
