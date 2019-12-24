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
using DAL_QuanLySinhVien;

namespace GUI_QuanLySinhVien
{
    public partial class frmQuanLySinhVien : Form
    {
        //TRAN SY TAI
        //LE DUC ANH
        //NGUYEN DANG KHOI
        BUS_ChuyenNganh bus_ChuyenNganh = new BUS_ChuyenNganh();
        BUS_MonHoc bus_MonHoc = new BUS_MonHoc();
        BUS_DangKyMonHoc bus_DangkyMonHoc = new BUS_DangKyMonHoc();
        public frmQuanLySinhVien()
        {
            InitializeComponent();
            ControlConfig();
        }
        private void ControlConfig()
        {
            cbChuyenNganh.DisplayMember = "TenChuyenNganh";
            cbChuyenNganh.ValueMember = "MaChuyenNganh";

            lstMonHocChuaChon.DisplayMember = "TenMonHoc";
            lstMonHocDaChon.DisplayMember = "TenMonHoc";
        }

        private void FrmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            LoadChuyenNganh();
            LoadMonHocTheoChuyenNganh();
            LoadDangKyMonHoc();
        }

        private void LoadDangKyMonHoc()
        {
            var listDangKyMonHoc = bus_DangkyMonHoc.GetAll();
            DataGridViewRow row = (DataGridViewRow)dgvDangKyMonHoc.Rows[0].Clone();
            foreach (ThongTinDangKy item in listDangKyMonHoc)
            {
                row.Cells[0].Value = item.MaSV;
                dgvDangKyMonHoc.Rows.Add(row);
            }
        }

        private void LoadMonHocTheoChuyenNganh()
        {
            lstMonHocChuaChon.Items.Clear();
            lstMonHocChuaChon.DisplayMember = "TenMonHoc";
            int maChuyenNganh = (cbChuyenNganh.SelectedItem as ChuyenNganh).MaChuyenNganh;
            var listMonHoc = bus_MonHoc.GetByMaChuyenNganh(maChuyenNganh);
            foreach (var item in listMonHoc)
            {
                if (lstMonHocDaChon.Items.Contains(item))
                    continue;
                lstMonHocChuaChon.Items.Add(item);
            }
        }

        private void LoadChuyenNganh()
        {
            cbChuyenNganh.DataSource = bus_ChuyenNganh.GetAll();
        }

        private void cbChuyenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMonHocTheoChuyenNganh();
        }

        private bool IsExistMonHocDaChon(MonHoc monHoc)
        {
            foreach (MonHoc item in lstMonHocDaChon.Items)
            {
                if (item.TenMonHoc == monHoc.TenMonHoc)
                    return true;
            }
            return false;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (lstMonHocChuaChon.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn 1 môn học");
            }
            MonHoc monHoc = lstMonHocChuaChon.SelectedItem as MonHoc;
            lstMonHocDaChon.Items.Add(monHoc);
            lstMonHocChuaChon.Items.Remove(monHoc);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (lstMonHocDaChon.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn 1 môn học");
                return;
            }
            MonHoc monHoc = lstMonHocDaChon.SelectedItem as MonHoc;
            lstMonHocChuaChon.Items.Add(monHoc);
            lstMonHocDaChon.Items.Remove(monHoc);
        }
    }
}
