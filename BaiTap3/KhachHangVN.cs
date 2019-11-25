using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    class KhachHangVN : KhachHang
    {
        public string DoiTuongKh { get; set; }
        public float DinhMuc { get; set; }
        public KhachHangVN() { }
        public KhachHangVN(string maKH, string hoTen, string hoaDon, int soLuong, float donGia, string doiTuongKh, float dinhMuc) 
            :base(maKH, hoTen, hoaDon, soLuong,donGia)
        {
            DoiTuongKh = doiTuongKh;
            DinhMuc = dinhMuc;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Doi tuong khach hang = ");
            this.DoiTuongKh = (Console.ReadLine());
            //tuong tu nhap cho cac thuoc tinh khac
            Console.Write("Dinh muc = ");
            this.DinhMuc = float.Parse(Console.ReadLine());
        }
        public override double ThanhTien()
        {
            if (SoLuong <= DinhMuc)
            {
                return SoLuong * DonGia;
            }
            else return SoLuong * DonGia * DinhMuc + (SoLuong - DinhMuc) * DonGia * 2.5;
        }

    }
}
