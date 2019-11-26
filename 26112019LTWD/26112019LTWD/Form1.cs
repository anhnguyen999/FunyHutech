using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26112019LTWD
{
    public partial class Form1 : Form
    {
        public int SoA { get; private set; }
        public int SoB { get; private set; }

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPhepTinh(object sender, EventArgs e)
        {
            //Chuyển Sender thành button
            Button btnPhepTinh = (Button)sender;
            //Xác định nút đang bấm là nút nào dựa vào tên
            string PhepTinh = btnPhepTinh.Name;
            //Sử dụng cấu trúc lựa chọn để xác định kết quả
            double SoA = double.Parse(txtSoA.Text);
            double SoB = double.Parse(txtSoB.Text);
            double KetQua = 0;
            switch (PhepTinh)
            {
                case "btnPhepCong":
                    KetQua = SoA + SoB;
                    break;

                case "btnPhepTru":
                    KetQua = SoA - SoB;
                    break;

                case "btnPhepNhan":
                    KetQua = SoA * SoB;
                    break;

                case "btnPhepChia":
                    KetQua = SoA / SoB;
                    break;

                default:
                    break;
            }
            txtKetQua.Text = KetQua.ToString();

        }

        /*
        private void txtSoA_KeyPress(object sender, EventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }
        */

        private void txtSoB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
