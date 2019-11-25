using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    class ForeignCustomer : Person
    {
        public string Nationality { get; set; }
        public ForeignCustomer()
        {

        }
        public ForeignCustomer(string id, string name, DateTime time, int num, double price, string nationality) : base(id, name, time, num, price)
        {
            Nationality = nationality;
        }
        public override double Money()
        {
            return this.Number * this.Price;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nationality: ");
            Nationality = Console.ReadLine();
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Nationalty: {0}", Nationality);
            Console.WriteLine("Into Money: {0}", Money());
        }
    }
}
