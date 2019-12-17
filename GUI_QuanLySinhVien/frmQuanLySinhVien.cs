using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLySinhVien
{
    public partial class frmQuanLySinhVien : Form
    {
        public frmQuanLySinhVien()
        {
            InitializeComponent();
            ControlConfig();
        }

        private void ControlConfig()
        {
            throw new NotImplementedException();
        }

        public void FrmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            LoadChuyenNganh();
        }
    }
}
