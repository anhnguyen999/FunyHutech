using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Teacher : Person
    {
        public string Adress { get; set; }
        public double Salary { get; set; }
        public Teacher() { }

        public Teacher(string adress, double salary)
        {
            Adress = adress;
            Salary = salary;

        }

        public override void Input()
        {
            base.Input();//goi thuoc tinh cua lop Person
            Console.WriteLine("Adress :=");
            //nhap them thuoc tinh xu ly cho lop Teacher
            this.Adress = Console.ReadLine();
            Console.WriteLine("Salary :=");
            this.Salary = double.Parse(Console.ReadLine());
        }
        //ham xuat mot Student
        public override void OutPut()
        {
             base.OutPut();//goi ham xuat cua lop Person
              Console.WriteLine("Adress := {2} \n Salary := {3}\n",
               this.Adress, this.Salary);
        } 
        
    }
}
