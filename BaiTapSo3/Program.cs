using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapSo3
{
    class Program
    {

        static List<CustomerGlobal> customerList;
        static void Main(string[] args)
        {

            //lay so luong sinh vien do nguoi dung nhap
            //ctrl + k + c: comment
            //ctrl + k + u: uncomment
            //ctrl + k + d: lam dep code, format code

            int numOfCustomer;
            do
            {
                Console.Write("Enter Number of Customer: ");
            } while (!int.TryParse(Console.ReadLine(), out numOfCustomer));

            InputCustomerList(numOfCustomer);
            Console.WriteLine("Danh sach khach hang: ");
            OutputCustomerList();
            //dung man hinh de xem ket qua
            //Console.WriteLine("Danh sach sinh vien CNTT: ");
            //OutputCustomerList();
            ////Nhap khoa can xuat DS sv
            Console.WriteLine("Nhap ID Khach Hang can xuat:");
            string ID = Console.ReadLine();
            SearchID(ID);
            List<CustomerGlobal> CustomerSearchResult = SearchID(ID);
            Console.WriteLine("Danh sach sinh vien thuoc khoa {0}", ID);
            OutputCustomerVNList(CustomerSearchResult);
            //Tam ngung man hinh de xem ket qua
            Console.ReadKey();

        }

        //ham tim kiem khach hang va xuat hoa don khach hang da tim kiem
        private static List<CustomerGlobal> SearchID(String ID)
        {
            return customerList.Where(s => s.ID.ToLower() == ID.ToLower()).ToList();
        }
            
        //danh sach khach hang viet nam
        //Xuat ra khach hang su dung vuot dinh muc nho ham if
        //Bien Nationality dung de truy xuat quoc tich khach hang VN
        private static void OutputCustomerVNList(List<CustomerGlobal> listCustomer)
        {
            //danh sach SV IT hjjjj
            foreach (CustomerGlobal item in customerList)
            {
                if (string.Compare(item.Nationality, "VN", true) == 0)
                {
                    Console.WriteLine("--------");
                    int SuDung = Power;
                    int PhanVuotDinhMuc;
                    int DinhMuc = 50;
                    if ( SuDung > DinhMuc)
                    {
                         PhanVuotDinhMuc = DinhMuc;
                        // số lượng * đơn giá * định mức + số lượng KW vượt định mức * Đơn giá * 2.5. 
                        PhanVuotDinhMuc = SuDung - DinhMuc;
                    }
                    else
                    {
                        PhanVuotDinhMuc = 0;//Nếu dùng không quá định mức thì phần vượt định mức = 0
                        PhanDinhMuc = LuongDienSuDung;
                    }
                    Console.WriteLine("\n Xuat Hoa Don Vuot Dinh Muc: {0}", Power * Bill * Rate);
                    Console.WriteLine("--------");
                }
            }
        }
        private static void OutputCustomerList()
        {
            // lap tung phan tu cua danh sach va in thong tin
            foreach (CustomerGlobal item in customerList)

            {
                Console.WriteLine("--------");
                Console.WriteLine("\nID: {0}\nFullName: {1}\nDay: {2}\nNationality: {3} \nPower: {4}\nBill: {5}", item.ID, item.FullName, item.Day, item.Nationality, item.Power, item.Bill);
                Console.WriteLine("--------");

            }
        }
        //Xuat hoa don khach hang thang 9/2019
        //private static void OutputCustomerMonthList()
        //{
        //     lap tung phan tu cua danh sach va in thong tin
        //    foreach (CustomerGlobal item in customerList)

        //        if ()
        //        {
        //            Console.WriteLine("--------");
        //            Console.WriteLine("\nID: {0}\nFullName: {1}\nDay: {2}\nNationality: {3} \nPower: {4}\nBill: {5}", item.ID, item.FullName, item.Day, item.Nationality, item.Power, item.Bill);
        //            Console.WriteLine("--------");
        //        }
        //    }
        //}

        //Ham 
        private static void InputCustomerList(int numOfCustomer)
        {
            //tao mang danh sach sinh vien
            customerList = new List<CustomerGlobal>();
            CustomerGlobal customer;
            for (int i = 0; i < numOfCustomer; i++)
            {
                customer = new CustomerGlobal();
                customer.Input();
                //dua doi tuong vao mang

                customerList.Add(customer);
            }
        }

    }
}

