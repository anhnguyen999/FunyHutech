﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLSV;

namespace BUS_QLSV
{
    public class BUS_ChuyenNganh
    {
        
        DAL_ChuyenNganh dal_ChuyenNganh = new DAL_ChuyenNganh();
        public BUS_ChuyenNganh()
        {

        }
        public List<ChuyenNganh> GetAll()
        {
            return dal_ChuyenNganh.GetAll();

        }
    }
}
