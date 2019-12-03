using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// Nguyen Hoang Phuc
/// Nguyen Hoang Tu
/// Nguyen Thai Hung Vuong
/// </summary>
namespace DangKyMonHoc
{
    public partial class Form1 : Form
    {
        string mgsError;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            this.groupBox1.SuspendLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.txtMSSV.MaxLength = 10;
            if(txtMSSV.MaxLength < 10)
            {
                MessageBox.Show(mgsError,"Vui Lòng Nhập MSSV < 10",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lB_ChonMonHoc_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //=> show result if user don't choose
            {
                try
                {
                    lB_ChonMonHoc.Items.Add(lB_Dich.SelectedItem);
                    lB_Dich.Items.Remove(lB_ChonMonHoc.SelectedItem);
                }
                catch (ArgumentNullException nex)

                {
                    MessageBox.Show("Bạn chưa chọn môn học nào!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //Chon tat ca item
            //foreach (string item in lB_ChonMonHoc.Items)

            //    lB_Dich.Items.Add(l);

            //lB_ChonMonHoc.Items.Clear();


        }

        private void lB_Dich_SelectedIndexChanged(object sender, EventArgs e)
        {
            lB_Dich.Items.Remove(lB_ChonMonHoc.SelectedItem);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
