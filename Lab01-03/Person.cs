using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    public abstract class Person
    {
        public string ID { get; set; }
        public string FullName { get; set; }
        public string Date { get; set; }
        public int Quantity { get; set; }
        public float Cost { get; set; }

        public Person()
        {

        }
        public Person(string id, string fullName, string date, int quantity, float cost)
        {
            ID = id;
            FullName = fullName;
            Date = date;
            Quantity = quantity;
            Cost = cost;
        }

        public virtual void Input()
        {
            Console.Write("ID= ");
            this.ID = (Console.ReadLine());
            Console.Write("FullName= ");
            this.FullName = (Console.ReadLine());
            Console.Write("Date(mm/dd/yyyy)= ");
            this.Date =(Console.ReadLine());
            Console.Write("Quantity= ");
            this.Quantity= int.Parse(Console.ReadLine());
            Console.Write("Cost= ");
            this.Cost = float.Parse(Console.ReadLine());
        }
        public abstract double IntoMoney();
    }
}
