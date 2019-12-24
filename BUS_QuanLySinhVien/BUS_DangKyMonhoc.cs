using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLySinhVien;
using DTO_QuanLySinhVien;

namespace BUS_QuanLySinhVien
{
    public class BUS_DangKyMonhoc
    {
        DAL_DangKyMonHoc dal_DangKyMonHoc = new DAL_DangKyMonHoc();

        public BUS_DangKyMonhoc()
        {

        }

        public List<DTO_DangKyMonHoc> GetAll()
        {
            return dal_DangKyMonHoc.GetAll();
        }
    }
}
