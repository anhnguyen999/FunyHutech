using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    class Program
    {
        public static int num, sum;
        public static List<Person> personList = new List<Person>();
        public static List<VNCustomer> VNCustoList = new List<VNCustomer>();
        public static List<ForeignCustomer> ForeignCustoList = new List<ForeignCustomer>();
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Input Number = ");

            } while (!int.TryParse(Console.ReadLine(), out num));
            Console.WriteLine("=====INPUT LIST=====");
            InputList(num);
            Console.WriteLine("\n=====SHOW LIST=====");
            ShowList(personList);
            Console.WriteLine("=====THE BILL 9/2019=====");
            ShowBill();
            ShowTotalKW();
            //dừng màn hỉnh để xem kết quả
            Console.ReadKey();
        }
        //INPUT LIST VN CUSTOMER AND FOREIGN CUSTOMER
        public static void InputList(int num)
        {
            for (int i = 0; i < num; i++)
            {
                int choose;
                do
                {
                    Console.Write("Choose (VN Customer {1} ; Foreign Customer {2}): ");
                    choose = int.Parse(Console.ReadLine());
                } while (choose != 1 && choose != 2);

                if (choose == 1)
                {
                    VNCustomer vncustomer = new VNCustomer();
                    vncustomer.Input();
                    personList.Add(vncustomer);
                    sum += vncustomer.Number;
                    Console.WriteLine();
                }
                else if (choose == 2)
                {
                    ForeignCustomer foreigncustomer = new ForeignCustomer();
                    foreigncustomer.Input();
                    personList.Add(foreigncustomer);
                    Console.WriteLine();
                }
            }
        }
        //SHOW LIST VN CUSTOMER AND FOREIGN CUSTOMER
        public static void ShowList(List<Person> personList)
        {
            foreach (Person person in personList)
            {
                if (person is VNCustomer)
                {
                    Console.WriteLine("The List Of VN Customer");
                    ((VNCustomer)person).Show();
                    Console.WriteLine();
                }

                if (person is ForeignCustomer)
                {
                    Console.WriteLine("The List Of Foreign Customer");
                    ((ForeignCustomer)person).Show();
                    Console.WriteLine();
                }
            }
        }
        //SHOW BILL 9/2019 (2 CUSTOMER)
        public static void ShowBill()
        {
            for (int i = 0; i < personList.Count(); i++)
            {
                //string[] dateBill = personList[i].Time.ToString("/");
            }
        }
        //SHOW TOTAL KW NUMBER
        public static void ShowTotalKW()
        {
            Console.WriteLine("Total KW Number Of VN Customer: {0}", sum);
        }
    }
}
