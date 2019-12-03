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
        string mgsError ;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPhepTinh_Click(object sender, EventArgs e)
        {
            double soA ;
            double soB ;
            if(!validateInputNumber(out soA, out soB))
            {
                MessageBox.Show(mgsError, "Thong bao",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            //Chuyen sender thanh button
            Button btnPhepTinh = (Button)sender;
            //xac dinh nut dang duoc bam là nút nào dựa vào tên
            string phepTinh = btnPhepTinh.Name;
            //Sử dụng cấu trúc lựa chọn để xác định kết quả
            double ketQua = 0;
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

        private void TxtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtNumber = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.') || ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)))
            {
                e.Handled = true;
                errorCheckNumber.SetError(txtNumber, "Không được nhập chữ hoặc khoảng trắng");
            }
            else
            {
                errorCheckNumber.SetError(txtNumber, null);
            }
        }
        private bool validateInputNumber(out double soA, out double soB)
        {
             mgsError = "";
            if(!double.TryParse(txtSoA.Text,out soA))
            {
                mgsError = "So A khong hop le";
            }
            if(!double.TryParse(txtSoB.Text,out soB))
            {
                mgsError += "\nSo B khong hop le";
            }
            if(mgsError == "")
                return true;
            return false;
        }
    }
}
