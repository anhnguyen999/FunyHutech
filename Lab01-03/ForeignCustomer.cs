using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    public class ForeignCustomer : Person
    {
        public string Nationality { get; set; }

        public ForeignCustomer()
        {

        }

        public ForeignCustomer(string id, string fullName, string date, int quantity, float cost, string nationality)
        : base(id, fullName, date, quantity, cost)
        {
            Nationality = nationality;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nationality= ");
            this.Nationality = (Console.ReadLine());
        }

        public override double IntoMoney()
        {
            return Quantity * Cost;
        }
    }
}
