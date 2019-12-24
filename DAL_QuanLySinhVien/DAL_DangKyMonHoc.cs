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
        QuanLySinhVienEntities dbContext = new QuanLySinhVienEntities();
        //public List<DTO_DangKyMonHoc> GetAll()
        //{
        //    var listDangKyMonHoc = (from dkmh in dbContext.ThongTinDangKies
        //                            select new DTO_DangKyMonHoc { MaSV = dkmh.MaSV, TenChuyenNganh = dkmh.});
        //}
    }
}
