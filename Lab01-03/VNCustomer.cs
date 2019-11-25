using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    class VNCustomer : Person
    {
        public int ObjCustomer { get; set; }
        public float Norm { get; set; }
        public VNCustomer()
        {

        }
        public VNCustomer(string id, string name, DateTime time, int num, double price, int objCustomer, float norm) : base(id, name, time, num, price)
        {
            ObjCustomer = objCustomer;
            Norm = norm;
        }
        public override double Money()
        {
            if (this.Number <= this.Norm)
            {
                return this.Number * this.Price;
            }
            else
            {
                return this.Number * this.Price * this.Norm + (this.Number - this.Norm) * this.Price * 2.5;
            }
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Object Customer {1. Living, 2. Business, 3. Manufacturing}: ");
            ObjCustomer = int.Parse(Console.ReadLine());
            Console.Write("Norm: ");
            Norm = float.Parse(Console.ReadLine());
        }
        public override void Show()
        {
            base.Show();
            if (ObjCustomer == 1)
            {
                Console.WriteLine("Object Customer: {0}", "Living");
            }
            else if (ObjCustomer == 2)
            {
                Console.WriteLine("Object Customer: {0}", "Business");
            }
            else if (ObjCustomer == 3)
            {
                Console.WriteLine("Object Customer: {0}", "Manufacturing");
            }
            Console.WriteLine("Norm: {0}", Norm);
            Console.WriteLine("KW Number Exceed Norm: {0}", Number - Norm);
            Console.WriteLine("Into Money: {0}", Money());
        }
    }
}
