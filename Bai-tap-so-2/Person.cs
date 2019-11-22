using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_so_2
{
    class Person
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public Person()
        {
        }
        public Person(int id, string fullName)
        {
            ID = id;

            FullName = fullName;
        }

        //ham Nhap Person
        public virtual void Input()
        {
            Console.WriteLine("ID :=");
            this.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("FullName :=");
            this.FullName = Console.ReadLine();
        }
        //ham Xuat Person
        public virtual void OutPut()
        {
            Console.WriteLine("ID := {0} \n FullName := {1}\n",
                this.ID, this.FullName);
        }
    }
}
