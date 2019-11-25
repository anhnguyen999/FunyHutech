using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    class KhachHangNuocNgoai : KhachHang
    {
        public string QuocTich { get; set; }
        public KhachHangNuocNgoai() { }
        public KhachHangNuocNgoai(string maKH, string hoTen, string hoaDon, string quocTich, int soLuong, int donGia)
            :base(maKH, hoTen, hoaDon, soLuong, donGia)
        {
            QuocTich = quocTich;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Quoc tich = ");
            this.QuocTich = (Console.ReadLine());
        }
        public override double ThanhTien()
        {
            return SoLuong * DonGia;
        }
    }
}
