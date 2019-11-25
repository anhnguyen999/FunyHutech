using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    abstract class Person
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public int Number { get; set; }
        public double Price { get; set; }
        public Person()
        {

        }
        public Person(string id, string name, DateTime time, int num, double price)
        {
            ID = id;
            Name = name;
            Time = time;
            Number = num;
            Price = price;
        }
        public abstract double Money();
        public virtual void Input()
        {
            Console.Write("ID: ");
            ID = Console.ReadLine();
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Time Check Bill: ");
            Time = DateTime.Parse(Console.ReadLine());
            Console.Write("Number (KW): ");
            Number = int.Parse(Console.ReadLine());
            Console.Write("Price: ");
            Price = double.Parse(Console.ReadLine());
        }

        public virtual void Show()
        {
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Time Check Bill: {0}", Time);
            Console.WriteLine("Number (KW): {0}", Number);
            Console.WriteLine("Price: {0}", Price);
        }
    }
}
