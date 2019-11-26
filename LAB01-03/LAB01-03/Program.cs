using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01_03
{
    class Program
    {
        int sum;
        public static List<Person> personList = new List<Person>();
        public static List<CustomerGlobal> customerListGB = new List<CustomerGlobal>();
        public static List<CustomerVietNam> customerListVN = new List<CustomerVietNam>();
        static void Main(string[] args)
        {

            //lay so luong sinh vien do nguoi dung nhap
            //ctrl + k + c: comment
            //ctrl + k + u: uncomment
            //ctrl + k + d: lam dep code, format code
            int sum;
            int numOfCustomer;
            do
            {
                Console.Write("Enter Number of Customer: ");
            } while (!int.TryParse(Console.ReadLine(), out numOfCustomer));

            Console.WriteLine("Nhap Danh sach khach hang: ");
            InputCustomerList(numOfCustomer);
            //xuat danh sach khach hang
            int chon;
            Console.WriteLine("Chon Danh sach khach hang ban muon xuat.");
            Console.WriteLine("\n1.Xuat DS Khach Hang VN");
            Console.WriteLine("\n2.Xuat DS Khach Hang VN");
            chon = int.Parse(Console.ReadLine());
            switch (chon)
            {
                case 1:
                    Console.WriteLine("Xuat Danh sach khach hang Viet Nam: ");
                    OutputCustomerVNList(customerListVN);
                    break;
                case 2:
                    Console.WriteLine("Xuat Danh sach khach hang Quoc Te: ");
                    OutputCustomerGBList(customerListGB);
                    break;
            }

            //Xuat danh sach khach hang thang 9/2019
            Console.WriteLine("Danh sach khach hang thang 9/2019: ");
            OutputCustomerMonth(customerListVN, customerListGB);
            //Xuat danh sach khach hang VN su dung vuot dinh muc
            OutputCustomerVNList();
            ////nhap ID khach hang can xuat
            ///Tra ve ID va xuat hoa don thanh tien cua khach hang 
            Console.WriteLine("TONG SO TIEN CUA KHACH HANG VUA NHAP");
            SearchIDShowID();
            //Tam ngung man hinh de xem ket qua
            Console.ReadKey();
        }
        //Ham nhap danh sach khach hang tuong ung
        private static void InputCustomerList(int numOfCustomer)
        {
            //tao mang danh sach sinh viEN
            for (int i = 0; i < numOfCustomer; i++)
            {
                int choose;
                do
                {
                    Console.WriteLine("Chon nhap CustomerVN {1}: ; Chon nhap CustomerGB {2}:");
                    choose = int.Parse(Console.ReadLine());
                } while (choose != 1 && choose != 2);

                //xuat danh sach khach hang VN neu chon chuc nang 1
                if (choose == 1)
                {
                    CustomerVietNam VN = new CustomerVietNam();
                    VN.Input();
                    personList.Add(VN);
                    //sum += VN.Power;
                    Console.WriteLine();
                }
                else if (choose == 2)
                {
                    CustomerGlobal GB = new CustomerGlobal();
                    GB.Input();
                    personList.Add(GB);
                    Console.WriteLine();
                }
            }
        }

        //Ham xuat danh sach khach hang tuong ung
        private static void OutputCustomerVNList(List<CustomerVietNam> customerListVN)
        {
            // lap tung phan tu cua danh sach va in thong tin
            foreach (CustomerVietNam item in customerListVN)

            {
                Console.WriteLine("--------");
                Console.WriteLine("ID: {0}\n  FullName: {1}\n  Date:{2} \n Power: {3}\n Bill: {4}\n Thanh Tien: {5}", item.ID, item.FullName, item.Day, item.Power, item.Bill, item.Money());
                Console.WriteLine("--------");
            }
        }

        private static void OutputCustomerGBList(List<CustomerGlobal> CustomerListGB)
        {
            // lap tung phan tu cua danh sach va in thong tin
            foreach (CustomerGlobal item in CustomerListGB)

            {
                Console.WriteLine("--------");
                Console.WriteLine("ID: {0}\n  FullName: {1}\n  Date:{2}\n Nationality: {3}\n Power: {4}\n Bill: {5}\n Thanh Tien: {6}", item.ID, item.FullName, item.Day, item.Nationality, item.Power, item.Bill, item.Money());
                Console.WriteLine("--------");
            }
        }
        //Ham Xuat DS khach hang theo thang 09/2019
        //private static void OutputCustomerMontList()
        //{
        //    List<Person> Show = personList.Where(p => p.Day.Month == 09 && p.Day.Year == 2019).ToList();
        //    if (Show.Count() > 0)
        //    {

        //        Console.WriteLine("--------");
        //        Console.WriteLine("ID: {0}\n  FullName: {1}\n  Date:{2}\n Nationality: {3}\n Power: {4}\n Bill: {5}\n Thanh Tien: {6}", item.ID, item.FullName, item.Day, item.Nationality, item.Power, item.Bill, item.Money());
        //        Console.WriteLine("--------");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Khong tim thay thong tin!");
        //    }
        //}
        private static void OutputCustomerMonth(List<CustomerVietNam> customerListVN, List<CustomerGlobal> customerListGB)
        {
            DateTime x, y;
            // lap tung phan tu cua danh sach va in thong tin
            foreach (CustomerVietNam item in customerListVN)
            {
                x = DateTime.Parse(item.Day);
                if (x.Month == 9 && x.Year == 2019)
                {
                    Console.WriteLine("--------");
                    Console.WriteLine("ID: {0}\n  FullName: {1}\n  Date:{2} \n Power: {3}\n Bill: {4}\n Thanh Tien: {5}", item.ID, item.FullName, item.Day, item.Power, item.Bill, item.Money());
                    Console.WriteLine("--------");
                }
            }
            foreach (CustomerGlobal item in customerListGB)
            {
                y = DateTime.Parse(item.Day);
                if (y.Month == 9 && y.Year == 2019)
                {
                    Console.WriteLine("--------");
                    Console.WriteLine("ID: {0}\n  FullName: {1}\n  Date:{2}\n Nationality: {3}\n Power: {4}\n Bill: {5}\n Thanh Tien: {6}", item.ID, item.FullName, item.Day, item.Nationality, item.Power, item.Bill, item.Money());
                    Console.WriteLine("--------");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
        //ham tim kiem khach hang va xuat hoa don khach hang da tim kiem
        //danh sach khach hang viet nam
        //bien nationality dung de truy xuat quoc tich khach hang vn
        private static void OutputCustomerVNList()
        {

            Console.WriteLine("Total KW Number Of VN Customer: {0}");
        }

        //Ham nhap 1 ID va tra ve gia tri tuong ung
        private static List<CustomerVietNam> SearchIDGB(string id)
        {
            return customerListVN.Where(s => s.ID.ToLower() == id.ToLower()).ToList();
        }

        private static List<CustomerGlobal> SearchIDGB(string id)
        {
            return CustomerListGB.Where(s => s.ID.ToLower() == id.ToLower()).ToList();
        }
    }
}





