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
using DTO_QuanLySinhVien;

namespace GUI_QuanLySinhVien
{
    public partial class frmQuanLyDangKy : Form
    {
        BUS_ChuyenNganh bus_chuyenNganh = new BUS_ChuyenNganh();
        BUS_MonHoc bus_MonHoc = new BUS_MonHoc();
        BUS_DangKyMonhoc bus_DangKyMonHoc = new BUS_DangKyMonhoc();

        public frmQuanLyDangKy()
        {
            InitializeComponent();
            ControlConfig();
        }

        private void ControlConfig()
        {
            cbxChuyenNganh.DisplayMember = "TenChuyenNganh";
            cbxChuyenNganh.ValueMember = "MaChuyenNganh";

            lstMonHocChuaChon.DisplayMember = "TenMonHoc";
            lstMonHocDaChon.DisplayMember = "TenMonHoc";
        }

        private void FrmQuanLyDangKy_Load(object sender, EventArgs e)
        {
            LoadChuyenNganh();
            LoadMonHocTheoChuyenNganh();
            LoadDangKyMonHoc();
        }

        private void LoadDangKyMonHoc()
        {
            var listDangKyMonHoc = bus_DangKyMonHoc.GetAll();

            DataGridViewRow row = (DataGridViewRow)dgvDangKyMonHoc.Rows[0].Clone();

            foreach (DTO_DangKyMonHoc item in listDangKyMonHoc)
            {
                row.Cells[0].Value = item.MaSinhVien;
                row.Cells[1].Value = item.HoTen;
                row.Cells[2].Value = item.TenChuyenNganh;
                row.Cells[3].Value = item.GioiTinh;
                dgvDangKyMonHoc.Rows.Add(row);
            }
        }

        private void LoadMonHocTheoChuyenNganh()
        {
            lstMonHocChuaChon.Items.Clear();

            int maChuyenNganh = (cbxChuyenNganh.SelectedItem as ChuyenNganh).MaChuyenNganh;

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
            cbxChuyenNganh.DataSource = bus_chuyenNganh.GetAll();
        }

        private void CbxChuyenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMonHocTheoChuyenNganh();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (lstMonHocChuaChon.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long chon mot mon hoc");
                return;
            }
            MonHoc monHoc = lstMonHocChuaChon.SelectedItem as MonHoc;

            lstMonHocChuaChon.Items.Remove(monHoc);
            lstMonHocDaChon.Items.Add(monHoc);

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

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (lstMonHocDaChon.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long chon mot mon hoc");
                return;
            }
            MonHoc monHoc = lstMonHocDaChon.SelectedItem as MonHoc;

            lstMonHocChuaChon.Items.Add(monHoc);
            lstMonHocDaChon.Items.Remove(monHoc);
        }
    }
}
