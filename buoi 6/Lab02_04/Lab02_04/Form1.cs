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
    public partial class Form1 : Form
    { BUS_ChuyenNganh bus_ChuyenNganh = new BUS_ChuyenNganh();
        public Form1()
        {
            InitializeComponent();
            ControlConfig();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ControlConfig()
        {
            cbChuyenNganh.DisplayMember = "TenCN";
            cbChuyenNganh.ValueMember = "MACN";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadChuyenNganh();
        }
        private void LoadChuyenNganh()
         {
                cbChuyenNganh.DataSource = bus_ChuyenNganh.GetChuyenNganh();
         }
    }
}
