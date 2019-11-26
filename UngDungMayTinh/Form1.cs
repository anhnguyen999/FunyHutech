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
            // CHUYEN SENDER THANH BUTTON 
            Button btnPhepTinh = (Button)sender;
            // xac dinh nut dang duoc bam la nut nao dua vao ten 
            string phepTinh = btnPhepTinh.Name;
            //Sử dụng cấu trúc lựa chọn để xác định kết quả
            double ketQua = 0;
            double soA = double.Parse (txtSoA.Text);
            double soB = double.Parse(txtSoB.Text);
            switch (phepTinh)
            {
                case "btnPhepCong" :
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

        private void TxtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtNumber = (TextBox)sender;
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;
                errorCheckNumber.SetError(txtNumber, "Không được nhập chữ hoặc khoảng trống");
            }
            else
            {
                errorCheckNumber.SetError(txtNumber, null);
            }
        }
    }
}
