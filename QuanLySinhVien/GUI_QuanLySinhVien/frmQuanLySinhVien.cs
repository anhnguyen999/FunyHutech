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
//// Điểm Danh 17/12/2019
/// Nguyễn Thái/ Hưng Vương 
/// Nguyễn Hoàng Phúc
/// Nguyễn Hoàng Tú
/// </summary>
namespace GUI_QuanLySinhVien
{
    public partial class frmQuanLySinhVien : Form
    {
        BUS_QuanLySinhVien bus_ChuyenNganh = new BUS_QuanLySinhVien();
        public frmQuanLySinhVien()
        {
            InitializeComponent();
            ControlConfig();
        }
        private void ControlConfig()
        {
            cbChuyenNganh.DisplayMember = "TenChuyenNganh";
            cbChuyenNganh.ValueMember = "MaChuyenNganh";
        }

        private void FrmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            LoadChuyenNganh();
        }
        private void LoadChuyenNganh()
        {
            cbChuyenNganh.DataSource = bus_ChuyenNganh.GetChuyenNganh();
        }

    }
}
