using BUS_QLSV;
using DAL_QLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_02
{
   //
    public partial class frmQuanLySinhVien : Form
    {
        BUS_ChuyenNganh bus_chuyenNganh = new BUS_ChuyenNganh();
        BUS_MonHoc bus_MonHoc = new BUS_MonHoc();
        BUS_DangKyMonHoc bus_DangKyMonHoc = new BUS_DangKyMonHoc();
        public frmQuanLySinhVien()
        {
            InitializeComponent();
            ControlConfig();
        }

        private void ControlConfig()
        {
            cmbChuyenNganh.DisplayMember = "TenChuyenNganh";
            cmbChuyenNganh.ValueMember = "MaChuyenNgnah";

            lstMonHocChuaChon.DisplayMember = "TenMH";
            lstMonHocDaChon.DisplayMember = "TenMH";
        }

        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            LoadChuyenNganh();
            
            LoadMonHocTheoChuyenNganh();
            LoadDangKyMonHoc();
        }

        private void LoadDangKyMonHoc()
        {
            var listDangKyMonHoc = bus_DangKyMonHoc.GetAll();
            DataGridViewRow row = (DataGridViewRow)dgvDangKyMonHoc.Rows[0].Clone();
            foreach (DangKyMonHoc item in listDangKyMonHoc)
            {
                row.Cells[0].Value = item.MaSV;
                dgvDangKyMonHoc.Rows.Add(row);
            }
        }

        private void LoadMonHocTheoChuyenNganh()
        {
            lstMonHocChuaChon.Items.Clear();
            int maChuyenNganh = (cmbChuyenNganh.SelectedItem as ChuyenNganh).MaChuyenNganh;
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
            cmbChuyenNganh.DataSource = bus_chuyenNganh.GetAll();
        
        }

        private void cmbChuyenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMonHocTheoChuyenNganh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(lstMonHocChuaChon.SelectedIndex== -1)
            {
                MessageBox.Show("Vui long chon");
                return;
            }
            MonHoc monHoc = lstMonHocChuaChon.SelectedItem as MonHoc;
            // if (!IsExistMonHocDaChon(monHoc))
            //{
            lstMonHocChuaChon.Items.Remove(monHoc);
            lstMonHocDaChon.Items.Add(monHoc); 
            //}
           
        }

        private bool IsExistMonHocDaChon(MonHoc monHoc)
        {
            foreach( MonHoc item in lstMonHocDaChon.Items)
            {
                if (item.TenMH == monHoc.TenMH)
                    return true;
            }
            return false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstMonHocDaChon.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long chon");
                return;
            }
            MonHoc monHoc = lstMonHocDaChon.SelectedItem as MonHoc;
            // if (!IsExistMonHocDaChon(monHoc))
            //{
            lstMonHocChuaChon.Items.Add(monHoc);
            lstMonHocDaChon.Items.Remove(monHoc);
            //}
        }
    }
}
