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

namespace GUI_QuanLySinhVien
{
    public partial class frmQuanLySinhVien : Form
    {
        //TRAN SY TAI
        //LE DUC ANH
        //NGUYEN DANG KHOI
        BUS_ChuyenNganh bus_ChuyenNganh = new BUS_ChuyenNganh();
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
