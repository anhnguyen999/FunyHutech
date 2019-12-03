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

    /// <summary>
    /// Nguyen Hoang Phuc
    /// Nguyen Hoang Tu
    /// Nguyen Thai Hung Vuong
    /// </summary>
    public partial class Form1 : Form
    {
        string mgsError;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void BtnPhepTinh_Click(object sender, EventArgs e)
        {
            double soA;
            double soB;
            
            if (!ValidateInputNumber(out soA, out soB))
            {
                MessageBox.Show(mgsError, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // CHUYEN SENDER THANH BUTTON 
            Button btnPhepTinh = (Button)sender;
            // xac dinh nut dang duoc bam la nut nao dua vao ten 
            string phepTinh = btnPhepTinh.Name;
            //Sử dụng cấu trúc lựa chọn để xác định kết quả
            double ketQua = 0;

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

        private bool ValidateInputNumber(out double soA, out double soB)
        {
            mgsError = "";
            if (double.TryParse(txtSoA.Text, out soA))
            {
                mgsError = "So A không hợp lệ!";
            }
            if (double.TryParse(txtSoB.Text, out soB))
            {
                mgsError += "\nSo B không hợp lệ!";
            }

            if (mgsError == "")
                return true;
            return false;
        }

        private void TxtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtNumber = (TextBox)sender;
            //if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.') || ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)))
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
