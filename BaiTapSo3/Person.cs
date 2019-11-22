using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapSo3
{
    abstract class Person
    {
        public string ID { get; set; }
        public string FullName { get; set; }
        public DateTime Day { get; set; }
        public Person()
        {
        }
        public Person(string id, string fullName, DateTime day)
        {
            ID = id;

            FullName = fullName;

            Day = day;
        }

        //ham Nhap Person
        public virtual void Input()
        {
            Console.WriteLine("ID :=");
            this.ID = Console.ReadLine();
            Console.WriteLine("FullName :=");
            this.FullName = Console.ReadLine();
            Console.WriteLine("DayTime :=");
            this.Day = DateTime.Parse(Console.ReadLine());
        }
        //ham Xuat Person
        public virtual void OutPut()
        {
            Console.WriteLine("ID := {0} \n FullName := {1}\n Day := {2}\n",
                this.ID, this.FullName, this.Day);
        }
    }
}
