using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_so_2
{
    class Teacher : Person
    {
        //Them thuoc tinh Adress, ID & FullName da ke thua tu lop Person 
        public string Adress;
        //Constructor khong tham so
        public Teacher() { }
        //Constructor co tham so
        public Teacher(int id, string fullName, string adress) : base(id, fullName)
        {
            Adress = adress;
        }

        //ham nhap mot Teacher
        public override void Input()
        {
            base.Input();//goi thuoc tinh cua lop Person
            //nhap them thuoc tinh xu ly cho lop Student
            Console.WriteLine("Adress :=");
            this.Adress = Console.ReadLine();

        }

        //ham xuat mot Teacher

        public override void OutPut()
        {
            base.OutPut();//goi ham xuat cua lop Person
            Console.WriteLine("Adress := {2} \n", this.Adress);
        }
    }
}
