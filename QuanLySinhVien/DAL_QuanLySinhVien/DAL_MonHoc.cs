using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLySinhVien
{
    public class DAL_MonHoc
    {
        QuanLySinhVienEntities dbContext = new QuanLySinhVienEntities();
        public List<MonHoc> GetAll()
        {
            return dbContext.MonHocs.ToList();
        }

        public List<MonHoc> GetByMaChuyenNganh(int maChuyenNganh)
        {
            var listMonHoc = dbContext.MonHocs.Where(mh => mh.MaChuyenNganh == maChuyenNganh).ToList();
            return listMonHoc;
        }
    }
}
