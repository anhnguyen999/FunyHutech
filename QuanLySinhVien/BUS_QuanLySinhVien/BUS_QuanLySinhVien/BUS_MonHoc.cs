﻿using DAL_QuanLySinhVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLySinhVien
{
    public class BUS_MonHoc
    {
        DAL_MonHoc dal_MonHoc = new DAL_MonHoc();
        public BUS_MonHoc()
        {

        }

        public List<MonHoc> GetAll()
        {
            return dal_MonHoc.GetAll();
        }

        public List<MonHoc> GetByMaChuyenNganh(int maChuyenNganh)
        {
            return dal_MonHoc.GetByMaChuyenNganh(maChuyenNganh);
        }
    }
}
