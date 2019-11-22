using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_03
{
    abstract class  TTKhachHang
    {
        public int MaKH { get; set; }
        protected string HoTen { get; set; }
        public DateTime NgayHD { get; set; }
        protected int SoLuong { get;set; }
        protected float DonGia { get; set; }

        

        protected TTKhachHang()
        {

        }
        protected TTKhachHang(int maKH,string hoTen,DateTime ngayHD,int soLuong,float donGia)
        {
            MaKH = maKH;
            HoTen = hoTen;
            NgayHD = ngayHD;
            SoLuong = soLuong;
            DonGia = donGia;
        }
        protected virtual void Input()
        {
            Console.Write("   Ma Khach Hang : ");
            MaKH = int.Parse(Console.ReadLine());
            Console.Write("   Ho va Ten (Full Name): ");
            HoTen = Console.ReadLine();
            Console.Write("   Ngay Hoa Don: ");
            NgayHD = DateTime.Parse(Console.ReadLine());
            Console.Write("   So Luong: ");
            SoLuong = int.Parse(Console.ReadLine());
            Console.Write("   Don Gia: ");
            DonGia = float.Parse(Console.ReadLine());
        }
        protected virtual void Show()
        {
            Console.WriteLine("   MaKH : {0}\n   Ho Ten KH : {1}\n   Ngay Hoa Don: {2}\n   So Luong : {3} \n   Don Gia: {4}\n",this.MaKH,this.HoTen,this.NgayHD,this.SoLuong,this.DonGia);
        }
        public abstract float ThanhTien();
    }
}
