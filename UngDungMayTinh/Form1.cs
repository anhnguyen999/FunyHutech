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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPhepTinh_Click(object sender, EventArgs e)
        {
            //Chuyển sender thành nút button
            Button btnPhepTinh = (Button)sender;
            // Xác định nút đang được bấm là nút nào dựa vào tên
            string phepTinh = btnPhepTinh.Name;
            //Sử dụng cấu trúc lựa chọn để xác định KQ
            double KQ = 0;
            double soA = double.Parse(txtSoA.Text);
            double soB = double.Parse(txtSoB.Text);
            switch (phepTinh)
            {
                case "btnPhepCong":
                    KQ = soA + soB;
                    break;

                case
                    "btnPhepTru":
                    KQ = soA - soB;
                    break;

                case
                    "btnPhepNhan":
                    KQ = soA * soB;
                    break;

                case
                    "btnPhepChia":
                    KQ = soA / soB;
                    break;

                default:
                    break;
            }
            txtKetQua.Text = KQ.ToString();
        }

        private void txtSoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }
    }
}
