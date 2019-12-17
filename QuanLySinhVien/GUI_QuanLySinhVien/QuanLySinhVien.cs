
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLySinhVien;
/// <summary>
/// Code View
/// </summary>

namespace GUI_QuanLySinhVien
{
        public partial class QuanLySinhVien : Form
        {
            BUS_ChuyenNganh bus_ChuyenNganh = new BUS_ChuyenNganh();
            public QuanLySinhVien()
            {
                InitializeComponent();
                ControlConfig();
            }
            private void ControlConfig()
            {
                cbChuyenNganh.DisplayMember = "TenChuyenNganh";
                cbChuyenNganh.ValueMember = "MaChuyenNganh";
            }

            private void QuanLySinhVien_Load(object sender, EventArgs e)
            {
                LoadChuyenNganh();
            }
            private void LoadChuyenNganh()
            {
                cbChuyenNganh.DataSource = bus_ChuyenNganh.GetChuyenNganh();
            }
    }
}
