using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private void btnCaluculator_Click(object sender, EventArgs e)
        {
            //Chuyển sender sang button
            Button btnCalculator = (Button)sender;
            //Xác định nút đang được bấm là nút nào dựa vào tên
            string calculator = btnCalculator.Name;
            //Sử dụng cấu trúc lựa chọn để xác định kết quả
            double result = 0;
            double number1 = double.Parse(txtNumber1.Text);
            double number2 = double.Parse(txtNumber2.Text);
            switch (calculator)
            {
                case "btnAdd_Click":
                    result = number1 + number2;
                    break;
                case "btnSub_Click":
                    result = number1 - number2;
                    break;
                case "btnMul_Click":
                    result = number1 * number2;
                    break;
                case "btnDiv_Click":
                    result = number1 / number2;
                    break;
                default:
                    break;
            }
            txtResult.Text = result.ToString();
        }
        //private void txtNumber1_
        /*private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            
        }*/
    }
}
