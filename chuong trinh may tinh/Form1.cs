using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuong_trinh_may_tinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPhepTinh_Click(object sender, EventArgs e)
        {
            //chuyen sender thanh button
            Button btnPhepTInh = (Button)sender;
            //xac dinh nut dang duoc bam la nut nao dua vao ten
            string phepTinh = btnPhepTInh.Name;
            //su dung cau truc lua chon de xac dinh ket qua
            double ketQua = 0;
            double soA = double.Parse(txtsoA.Text);
            double soB = double.Parse(txtsoB.Text);
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

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtNumber = (TextBox)sender;
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;
                errorCheckNumber.SetError(txtNumber, "khong duoc nhap chu vao khoang trong");
            }
            else
            {
                errorCheckNumber.SetError(txtNumber, null);
            }
        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

