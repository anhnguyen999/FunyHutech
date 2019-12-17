using DAL_QuanLySinhVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLySinhVien
{
    public class BUS_ChuyenNganh
    {
        QuanLySinhVienEntities dbContext = new QuanLySinhVienEntities();
        public BUS_ChuyenNganh()
        {

        }

        public List<ChuyenNganh> GetChuyenNganh()
        {
            return dbContext.ChuyenNganhs.ToList();
        }
    }
}
