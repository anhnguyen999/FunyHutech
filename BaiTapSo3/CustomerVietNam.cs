using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapSo3
{
    class CustomerVietNam : Person
    {
        //Tao thuoc tinh
        public string Living;
        public string Business;
        public string Production;
        public int Power;
        public float Bill;
        public int Rate;

        //Tao constructor khong tham so
        public CustomerVietNam() { }

        //Tao constructor co tham so
        public CustomerVietNam(string id, string fullName, DateTime day, string living, string business,
            string production, int power, float bill, int rate) : base(id, fullName, day)
        {
         Living = living;
         Business = business;
         Production = production;
         Power = power ;
         Bill = bill;
         Rate = rate;
    }

        //ham nhap mot
        public override void Input()
        {
            base.Input();//goi thuoc tinh cua lop Person
            Console.WriteLine("Living :=");
            //nhap them thuoc tinh xu ly cho lop Student
            this.Living = Console.ReadLine();
            Console.WriteLine("Business :=");
            this.Business = Console.ReadLine();
            Console.WriteLine("Production :=");
            this.Production = Console.ReadLine();
            Console.WriteLine("Power (KW/H) :=");
            this.Power = int.Parse(Console.ReadLine());
            Console.WriteLine("Bill (VND) :=");
            this.Bill = float.Parse(Console.ReadLine());
            Console.WriteLine("Rate :=");
            this.Rate = int.Parse(Console.ReadLine());
        }

        //ham xuat mot Student
        public override void OutPut()
        {
            base.OutPut();//goi ham xuat cua lop Person
            Console.WriteLine("Living := {3}\n Business := {4}\n Productiom := {5}\n Power := {6}\nBill := {7}\nRates := {8}\n",
                 this.Living, this.Business, this.Production, this.Power, this.Bill, this.Rate);
        }
    }
}