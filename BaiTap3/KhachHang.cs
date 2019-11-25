using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
     abstract class  KhachHang
    {
        public string MaKH { get; set; }
        public string HoTen { get; set; }
        public string HoaDon { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public KhachHang() { }
        public KhachHang(string maKH, string hoTen, string hoaDon, int soLuong, float donGia  )
        {
            MaKH = maKH;
            HoTen = hoTen;
            HoaDon = hoaDon;
            SoLuong = soLuong;
            DonGia = donGia;
        }
        public virtual void Input()
        {
            Console.Write("ma = ");
            this.MaKH = (Console.ReadLine());
            Console.Write("Ho ten = ");
            this.HoTen = (Console.ReadLine());
            Console.Write("Date (mm/dd/yyyy) = ");
            this.HoaDon = (Console.ReadLine());
            Console.Write("So luong = ");
            this.SoLuong = int.Parse(Console.ReadLine());
            Console.Write("Don gia = ");
            this.DonGia = float.Parse(Console.ReadLine());
        }
        public abstract double ThanhTien();
    }
}
