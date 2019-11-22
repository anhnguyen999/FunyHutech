using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_03
{
    class KhachHangVN : TTKhachHang
    {
        public string DoiTuong { get; set; }
        public float DinhMuc { get; set; }

        public KhachHangVN() : base()
        {

        }
        public KhachHangVN(int maKH, string hoTen, DateTime ngayHD, int soLuong, float donGia, string doiTuong, float dinhMuc) : base(maKH, hoTen, ngayHD, soLuong, donGia)
        {
            MaKH = maKH;
            HoTen = hoTen;
            NgayHD = ngayHD;
            SoLuong = soLuong;
            DonGia = donGia;
            DoiTuong = doiTuong;
            DinhMuc = dinhMuc;
        }
        public virtual void Input()
        {

            base.Input();
            Console.Write("   Doi Tuong: ");
            this.DoiTuong = Console.ReadLine();

            Console.Write("   Dinh Muc: ");
            this.DinhMuc = float.Parse(Console.ReadLine());
        }

        public virtual void Show()
        {
            base.Show();
            Console.WriteLine("   Doi Tuong: {0}\n   Dinh Muc: {1}\n", this.DoiTuong, this.DinhMuc);
            Console.WriteLine("   Thanh tien : {0}", ThanhTien());
        }

        public override float ThanhTien()
        {
            float thanhtien;
            float Du;

            if (SoLuong <= DinhMuc)
            {
                thanhtien = SoLuong * DonGia;
            }
            else
            {
                Du = SoLuong - DinhMuc;
                thanhtien = (float)((SoLuong * DonGia * DinhMuc) + (Du * DonGia * 2.5));
            }
            return thanhtien;
        }
        public float TieuThu()
        {
            if(SoLuong > DinhMuc)
                return this.SoLuong - DinhMuc;
            return 0;
        }

    }
}

