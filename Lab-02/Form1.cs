using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPhepTinh_Click(object sender, EventArgs e)
        {
            //Chuyen sender thanh button
            Button btnPhepTinh = (Button)sender;
            // xac dinh nut dang thuc hien
            string phepTinh = btnPhepTinh.Name;
            //Su dung cau truc lua chon de xac dinh ket qua
            double ketQua = 0;
            double soA = double.Parse(txtA.Text);
            double soB = double.Parse(txtB.Text);
            switch (phepTinh)
            {
                case "btnCong":
                    ketQua = soA + soB;
                    break;
                case "btnTru":
                    ketQua = soA - soB;
                    break;
                case "btnNhan":
                    ketQua = soA * soB;
                    break;
                case "btnChia":
                    ketQua = soA / soB;
                    break;
                default:
                    break;
            }
            txtKetQua.Text = ketQua.ToString();
        }
    }
}
