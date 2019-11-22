using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab01_03
{
    class Program
    {
        static int N = 0;
        static List<TTKhachHang> kHList;
        static void Main(string[] args)
        {
            do
            {
                Console.Write("=====> Nhap SL KH: ");

            } while (!int.TryParse(Console.ReadLine(), out N));

            InputList(N);
            ShowList(kHList);

            ShowListDate(kHList);

            Console.WriteLine("Tong So Tieu Thu KW : {0} KW", SumKW());
            ShowListSearch(kHList);
            Console.WriteLine("\n===== Nhan ENTER De Out CT =====");
            Console.ReadKey();
        }

        private static float SumKW()
        {
            float tong = 0;
            foreach(TTKhachHang ttKH in kHList)
            {
                if(ttKH is KhachHangVN)
                {
                   tong+= ((KhachHangVN)ttKH).TieuThu();
                }
            }
            return tong;
        }

        private static void ShowListSearch(List<TTKhachHang> kHList)
        {
            int searchMa;
            Console.WriteLine("=== Nhap Ma Can Tim: ");
            searchMa = int.Parse(Console.ReadLine());
            List<TTKhachHang> searchList = kHList.Where(p => p.MaKH == searchMa).ToList();
            if(searchList.Count > 0)
            {
                ShowList(searchList);
            }
        }

        private static void ShowListDate(List<TTKhachHang> kHList)
        {
           
            List<TTKhachHang> dkDate = kHList.Where(p => p.NgayHD.Year == 2019 && p .NgayHD.Month == 9) .ToList();
            if(dkDate.Count() > 0)
            {
                Console.WriteLine("=====> Hoa don thang 9 nam 2019 <=====");
                ShowList(dkDate);
            }
            else
            {
                Console.WriteLine("=====> Khong co hoa don  thang 9 nam 2019 <=====");
            }
        }

        private static void ShowList(List<TTKhachHang> kHList)
        {
            int j = 0;
            int k = 0;
            foreach (TTKhachHang ttKH in kHList)
            {
                if (ttKH is KhachHangVN)
                {
                    Console.WriteLine("=====> Danh Sach KH VN <=====");
                    Console.WriteLine("=- KH  {0}", j + 1);
                    ((KhachHangVN)ttKH).Show();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("=====> Danh Sach KH Nuoc Ngoai <=====");
                    Console.WriteLine("=- KH  {0}", k + 1);
                    ((KhachHangNN)ttKH).Show();
                    Console.WriteLine();
                }
            }
        }

        private static void InputList(int N)
        {
            int m;
            int j = 0;
            int k = 0;
            
            kHList = new List<TTKhachHang>();
            for (int i = 0; i < N; i++)
            {
                do
                {
                    Console.WriteLine("===== Khach Hang Thuoc QG nao?\n   ==- (1. KH VN && 2. KH NN): ");
                    m = int.Parse(Console.ReadLine());
                } while (m < 1 || m > 2);
                if (m == 1)
                {
                    Console.WriteLine("==- Nhap Vao KH : ", j + 1);
                    KhachHangVN vn = new KhachHangVN();
                    vn.Input();
                    
                    kHList.Add(vn);
                }
                else
                {
                    Console.WriteLine("==- Nhap Vao KH : ", k + 1);
                    KhachHangNN vn1 = new KhachHangNN();
                    vn1.Input();

                    kHList.Add(vn1);
                }

                //khachhangVN = new KhachHangVN();
                //Console.WriteLine("Khach Hang {0}: ", i + 1);
                //khachhangVN.InputVN();
                //KHList.Add(khachhangVN);;
            }
        }
    }
}
