using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    public class CustomerVN : Person
    {
        public string Objectt { get; set; }
        public float Norm { get; set; }

        public CustomerVN()
        {

        }
        public CustomerVN(string id, string fullName, string date, int quantity, float cost,string objectt,float norm)
        :base(id,fullName,date,quantity,cost)
        {
            Objectt = objectt;
            Norm = norm;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("object= ");
            this.Objectt = (Console.ReadLine());
            //tuong tu nhap cho cac thuoc tinh khac
            Console.Write("Norm= ");
            this.Norm = float.Parse(Console.ReadLine());

        }
        public override double IntoMoney()
        {
            if (Quantity <= Norm)
            {
                return Quantity * Cost;
            }
            else return Quantity * Cost * Norm + (Quantity - Norm) * Cost * 2.5;
        }
        
    }
}
