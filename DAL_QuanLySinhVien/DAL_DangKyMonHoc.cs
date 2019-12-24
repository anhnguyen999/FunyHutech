using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLySinhVien;

namespace DAL_QuanLySinhVien
{
    public class DAL_DangKyMonHoc
    {
        QuanLySinhVienEntities1 dbContext = new QuanLySinhVienEntities1();

        public List<DTO_DangKyMonHoc> GetAll()
        {
            var listDangKyMonHoc = (from dkmh in dbContext.DangKyMonHocs select new DTO_DangKyMonHoc { MaSinhVien = dkmh.MaSinhVien, HoTen = dkmh.SinhVien.HoTen, TenChuyenNganh = dkmh.SinhVien.ChuyenNganh.TenChuyenNganh,
              GioiTinh = dkmh.SinhVien.GioiTinh  == true ? "Nam" : "Nu" }).ToList();

            return listDangKyMonHoc;
        }
    }
}
