using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    class Program
    {
        static List<KhachHangVN> KhachHangVNList;
        static List<KhachHangNuocNgoai> KhachHangNuocNgoaiList;
        static void Main(string[] args)
        {
            KhachHangVNList = new List<KhachHangVN>();
            KhachHangNuocNgoaiList = new List<KhachHangNuocNgoai>();
            int choose;
            do
            {
                
                Console.WriteLine("1. Nhập danh sách khách hàng");
                Console.WriteLine("2. Xuất danh sách khách hàng");
                Console.WriteLine("3. Xuất ra các hoá đơn trong tháng 09 năm 2019 ");
                Console.WriteLine("4. Tính tổng số KW tiêu thụ vượt định mức của khách hàng Việt Nam");
                Console.WriteLine("5.  Nhập vào một mã khách hàng để tìm kiếm");
                Console.WriteLine("0. Thoat                                          ");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("chon: ");
                choose = int.Parse(Console.ReadLine());
                // use switch... case...
                switch (choose)
                {
                    case 1:
                        int choose1;
                        do
                        {
                            Console.WriteLine("==1. Nhập danh sách khách hàng VN");
                            Console.WriteLine("==2. Nhập danh sách khách hàng nuoc ngoai");
                            Console.WriteLine("==0. Thoat");
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("choose: ");
                            choose1 = int.Parse(Console.ReadLine());
                            switch (choose1)
                            {
                                case 1:

                                    KhachHangVN khachHangVN = new KhachHangVN();
                                    khachHangVN.Input();
                                    //dua doi tuong vao mang
                                    KhachHangVNList.Add(khachHangVN);
                                    break;
                                case 2:

                                    KhachHangNuocNgoai khachHangNuocNgoai;
                                    khachHangNuocNgoai = new KhachHangNuocNgoai();
                                    khachHangNuocNgoai.Input();
                                    //dua doi tuong vao mang
                                    KhachHangNuocNgoaiList.Add(khachHangNuocNgoai);
                                    break;
                                case 0:
                                    break;
                            }
                        } while (choose1 != 0);
                        break;
                    case 2:
                        int choose2;
                        do
                        {
                            Console.WriteLine("1. Xuất khách hàng việt nam");
                            Console.WriteLine("2. Xuất khách hàng nước ngoài");
                            Console.WriteLine("3. Xuất cả 2");
                            Console.WriteLine("0. Thoát");
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("choose: ");
                            choose2 = int.Parse(Console.ReadLine());
                            switch (choose2)
                            {
                                case 1:
                                    Console.WriteLine("Khách hàng VN");
                                    OutputKhachHangVNList(KhachHangVNList);
                                    break;
                                case 2:
                                    Console.WriteLine("Khách hàng nước ngoài");
                                    OutputFCustomerList(KhachHangNuocNgoaiList);
                                    break;
                                case 3:
                                    Console.WriteLine("Khách hàng");
                                    Console.WriteLine("----------------------");
                                    OutputKhachHangVNList(KhachHangVNList);
                                    Console.WriteLine("----------------------");
                                    OutputFCustomerList(KhachHangNuocNgoaiList);
                                    break;
                                case 0:
                                    break;
                            }
                        } while (choose2 != 0);
                        break;
                    case 3:
                        Console.WriteLine("Các hoá đơn trong tháng 09 năm 2019 ");
                        OutputSep(KhachHangVNList, KhachHangNuocNgoaiList);
                        break;
                    case 4:
                        if (KExceeded() == 0)
                        {
                            Console.WriteLine("Không có hóa đơn");
                        }
                        else
                        {
                            Console.WriteLine("Các hóa đơn: {0}", KExceeded());
                        }
                        break;
                    case 5:
                        int choose3;
                        do
                        {
                            Console.WriteLine("1. Tìm khách hàng vn theo mã");
                            Console.WriteLine("2. Tìm khách hàng nước ngoài theo mã");
                            Console.WriteLine("0. Thoát");
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("choose: ");
                            choose3 = int.Parse(Console.ReadLine());
                            switch (choose3)
                            {
                                case 1:
                                    Console.WriteLine("Nhập mã cần tìm: ");
                                    string id = Console.ReadLine();
                                    if (SearchID(id) == null)
                                    {
                                        Console.WriteLine("Mã sai...");
                                    }
                                    else
                                    {
                                        List<KhachHangVN> KhachHangVNResult = SearchID(id);
                                        Console.WriteLine("Hóa đơn khách hàng: {0}", id);
                                        OutputKhachHangVNList(KhachHangVNResult);
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Nhập mã cần tìm:  ");
                                    string id1 = Console.ReadLine();
                                    if (SearchID(id1) == null)
                                    {
                                        Console.WriteLine("Mã sai...");
                                    }
                                    else
                                    {
                                        List<KhachHangNuocNgoai> KhachHangNuocNgoaiResult = SearchIDf(id1);
                                        Console.WriteLine("Hóa đơn khách hàng: {0}", id1);
                                        OutputFCustomerList(KhachHangNuocNgoaiResult);
                                    }
                                    break;
                                case 0:
                                    break;
                            }
                        } while (choose3 != 0);
                        break;
                }
            } while (choose != 0);
            Console.ReadKey();
        }
        private static void OutputKhachHangVNList(List<KhachHangVN> KhachHangVNList)
        {
            // lap tung phan tu cua danh sach va in thong tin
            foreach (KhachHangVN item in KhachHangVNList)

            {
                Console.WriteLine("--------");
                Console.WriteLine("Mã: {0}\n  Họ tên: {1}\n  Hóa đơn:{2}\n  Số lượng: {3}\n  Đợn giá: {4}\n  Đối tượng: {5}\n  Định mức: {6}\n  Thành tiền: {7}", item.MaKH, item.HoTen, item.HoaDon, item.SoLuong, item.DoiTuongKh, item.DinhMuc, item.ThanhTien());
                Console.WriteLine("--------");
            }
        }

        private static void OutputFCustomerList(List<KhachHangNuocNgoai> fCustomerList)
        {
            // lap tung phan tu cua danh sach va in thong tin
            foreach (KhachHangNuocNgoai item in fCustomerList)

            {
                Console.WriteLine("--------");
                Console.WriteLine("Mã: {0}\n  Họ tên: {1}\n  Hóa đơn:{2}\n  Số lượng: {3}\n  Đợn giá: {4}\n  Quốc tịch: {5}\n Thành tiền: {6}", item.MaKH, item.HoTen, item.HoaDon, item.SoLuong, item.QuocTich, item.ThanhTien());
                Console.WriteLine("--------");
            }
        }
        /// <param name="KhachHangVNList"></param>
        /// <param name="fCustomerList"></param>
        private static void OutputSep(List<KhachHangVN> KhachHangVNList, List<KhachHangNuocNgoai> fCustomerList)
        {
            DateTime x, y;
            // lap tung phan tu cua danh sach va in thong tin
            foreach (KhachHangVN item in KhachHangVNList)
            {
                x = DateTime.Parse(item.HoaDon);
                if (x.Month == 9 && x.Year == 2019)
                {
                    Console.WriteLine("--------");
                    Console.WriteLine("Mã: {0}\n  Họ tên: {1}\n  Hóa đơn:{2}\n  Số lượng: {3}\n  Đơn giá: {4}\n  Đối tượng: {5}\n  Định mức: {6}\n  Thành tiền: {7}", item.MaKH, item.HoTen, item.HoaDon, item.SoLuong, item.DonGia, item.DoiTuongKh, item.DinhMuc, item.ThanhTien());
                    Console.WriteLine("--------");
                }
            }
            foreach (KhachHangNuocNgoai item in fCustomerList)
            {
                y = DateTime.Parse(item.HoaDon);
                if (y.Month == 9 && y.Year == 2019)
                {
                    Console.WriteLine("--------");
                    Console.WriteLine("Mã: {0}\n  Họ tên: {1}\n  Hóa đơn:{2}\n  Số lượng: {3}\n  Đợn giá: {4}\n  Quốc tịch: {5}\n Thành tiền: {6}", item.MaKH, item.HoTen, item.HoaDon, item.SoLuong, item.QuocTich, item.ThanhTien());
                    Console.WriteLine("--------");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
        /// <summary>
        /// function exoprt the KW exceeded the norm
        /// </summary>
        /// <returns></returns>
        private static float KExceeded()
        {
            float s = 0;  // gan bien tinh tong
            foreach (KhachHangVN item in KhachHangVNList)
            {
                if (item.DinhMuc < item.SoLuong)
                {
                    float x = item.SoLuong - item.DinhMuc;
                    s = s + x;
                }
            }
            return s;
        }
        /// <summary>
        /// find id and export the bill
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private static List<KhachHangVN> SearchID(string id)
        {
            return KhachHangVNList.Where(s => s.MaKH.ToLower() == id.ToLower()).ToList();
        }

        private static List<KhachHangNuocNgoai> SearchIDf(string id)
        {
            return KhachHangNuocNgoaiList.Where(s => s.MaKH.ToLower() == id.ToLower()).ToList();
        }
    }
}
