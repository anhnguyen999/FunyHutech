using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Tao 1 tai khoan
        private Account GetAccount()
        {
            Account acc = new Account();
            acc.AccountNo = txtAccID.Text;
            acc.AccountName = txt_AccName.Text;
            acc.Address = txt_AccAdress.Text;
            acc.Balance = double.Parse(txt_AccMoney.Text);
            return acc;
        }

        //Tao mang danh sach tai khoan
        private List<Account> GetListAccount()
        {
            List<Account> list = new List<Account>();
            for (int i = 0; i < lstAccount.Items.Count; i++)
            {
                Account acc = new Account();
                acc.AccountNo = lstAccount.Items[i].SubItems[1].Text;
                acc.AccountName = lstAccount.Items[i].SubItems[2].Text;
                acc.Address = lstAccount.Items[i].SubItems[3].Text;
                acc.Balance = double.Parse(lstAccount.Items[i].SubItems[4].Text);
                list.Add(acc);
            }
            return list;
        }
        //Event Button Add/Update
        private void btnAdd_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAccID.Text == "" || txt_AccName.Text == "" || txt_AccAdress.Text == "" ||
                    txt_AccMoney.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                List<Account> listAccount = GetListAccount();
                Account findAccount = listAccount.FirstOrDefault(p => p.AccountNo == txtAccID.Text);
                if (findAccount == null) //neu khong tim thay tai khoan nay trong ds thi them moi
                {
                    findAccount = GetAccount();//lay gia tri tu forms
                    string[] item = new string[] {(listAccount.Count + 1).ToString(),
                    findAccount.AccountNo, findAccount.AccountName, findAccount.Address, findAccount.Balance.ToString()};
                    ListViewItem newRow = new ListViewItem(item);
                    lstAccount.Items.Add(newRow);
                    txt_Total.Text = findAccount.Balance.ToString();
                    MessageBox.Show("Thêm Dữ Liệu Thành Công!", "Notification");
                }
                else
                {
                    //ham cap nhat
                    lstAccount.Items[1].SubItems[2].Text = txt_AccName.Text;
                    lstAccount.Items[1].SubItems[3].Text = txt_AccAdress.Text;
                    lstAccount.Items[1].SubItems[4].Text = (double.Parse(txt_AccMoney.Text) + findAccount.Balance).ToString();
                    double sum = double.Parse(txt_AccMoney.Text);
                    txt_Total.Text = (sum + findAccount.Balance).ToString();
                    MessageBox.Show("Thêm Dữ Liệu Thành Công!", "Notification");
                }
                txtAccID.Text = "";
                txt_AccName.Text = "";
                txt_AccAdress.Text = "";
                txt_AccMoney.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstAccount.Items)
            {
                if (lstAccount.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("Bạn có muốn xóa tài khoản này?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        lstAccount.Items.Remove(lstAccount.SelectedItems[0]);
                        MessageBox.Show("Xóa Thành Công!", "Notification", MessageBoxButtons.OKCancel);

                    }
                }
                else if (item.SubItems[1].Text == txtAccID.Text)
                {
                    if (MessageBox.Show("Bạn có muốn xóa tài khoản này?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        lstAccount.Items.Remove(item);
                        //MessageBox.Show("Không tìm thấy tài khoản cần xóa!", "Notification");
                    }
                }
            }
            MessageBox.Show("Tác Vụ Xóa Hoàn Tất! " +
                "\nVui lòng kiểm tra lại dữ liệu.", "Notification",MessageBoxButtons.OK);
            txtAccID.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }

}
