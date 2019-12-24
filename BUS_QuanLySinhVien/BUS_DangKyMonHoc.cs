using DAL_QuanLySinhVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLySinhVien
{
    public class BUS_DangKyMonHoc
    {
        DAL_DangKyMonHoc dal_DangKyMonHoc = new DAL_DangKyMonHoc();
        public BUS_DangKyMonHoc()
        {

        }

        public List<ThongTinDangKy> GetAll()
        {
            return dal_DangKyMonHoc.GetAll();
        }
    }
}
