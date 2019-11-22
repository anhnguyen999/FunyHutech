using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_03
{
    class KhachHangNN : TTKhachHang 
    {
        public string QuocGia { get; set; }
        public KhachHangNN():base()
        {

        }
        public KhachHangNN(int maKH, string hoTen, DateTime ngayHD, int soLuong, float donGia, string quocTich) : base(maKH, hoTen, ngayHD, soLuong, donGia)
        {
            MaKH = maKH;
            HoTen = hoTen;
            NgayHD = ngayHD;
            SoLuong = soLuong;
            DonGia = donGia;
            QuocGia = quocTich;
        }
        public virtual void Input()
        {
            base.Input();
            Console.Write("   Quoc Tich: ");
            this.QuocGia = Console.ReadLine();
        }

        public virtual  void Show()
        {
            base.Show();
            Console.WriteLine("   Quoc Tich: {0}", this.QuocGia);
            Console.WriteLine("   Thanh tien : {0}", ThanhTien());
        }

        public override float ThanhTien()
        {
            return SoLuong * DonGia;

        }
    }
        
}
