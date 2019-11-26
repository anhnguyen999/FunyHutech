using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungMayTinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPhepTinh_Click(object sender, EventArgs e)
        {
            //Chuyen sender thanh button
            Button btnPhepTinh = (Button)sender;
            //xac dinh nut dang duoc bam là nút nào dựa vào tên
            string phepTinh = btnPhepTinh.Name;
            //Sử dụng cấu trúc lựa chọn để xác định kết quả
            double ketQua = 0;
            double soA = double.Parse(txtSoA.Text);
            double soB = double.Parse(txtSoB.Text);
            switch (phepTinh)
            {
                case "btnPhepCong":
                    ketQua = soA + soB;
                    break;
                case "btnPhepTru":
                    ketQua = soA - soB;
                    break;
                case "btnPhepNhan":
                    ketQua = soA * soB;
                    break;
                case "btnPhepChia":
                    ketQua = soA / soB;
                    break;
                default:
                    break;
            }
            txtKetQua.Text = ketQua.ToString();
        }

        private void TxtSoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;
                //
            }
        }
    }
}
