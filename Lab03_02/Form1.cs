using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_02
{
    public partial class Form1 : Form
    {
        public List<int> listSize = new List<int>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
        public Form1()
        {
            InitializeComponent();
  
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                cbFont.Items.Add(font.Name);
            }
            foreach (int i in listSize)
            {
                cbSize.Items.Add(i);
            }
            cbFont.Text = ("Times New Roman");
            cbSize.Text = ("12");
            richText.Font = new Font(cbFont.Text, float.Parse(cbSize.Text));
        }

        private void cbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontdlg = new FontDialog();
            fontdlg.ShowColor = true;
            fontdlg.ShowApply = true;
            fontdlg.ShowEffects = true;
            fontdlg.ShowHelp = true;
            if (fontdlg.ShowDialog() != DialogResult.Cancel)
            {
                richText.ForeColor = fontdlg.Color;
                richText.Font = fontdlg.Font;
            }
        }
        //Save file
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn lưu văn bản vào máy?", "NOTIFICATION", MessageBoxButtons.YesNo);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.AddExtension = true;
            saveFile.RestoreDirectory = true;
            saveFile.DefaultExt = "TXT";
            saveFile.Filter = "RTF file| *.rtf | TXT file | *.txt| All files| *.*";
            //saveFile.InitialDirectory = @"D:/..."
            if (saveFile.CheckFileExists == false)
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    //richText.SaveFile(SaveFileDialog.FileName);
                    MessageBox.Show("Văn Bản Đã Được Lưu Thành Công!", "NOTIFICATION", MessageBoxButtons.OK);
                }
            }

            else if (saveFile.CheckPathExists == true)
            {
                MessageBox.Show("Văn Bản Đã Được Lưu Thành Công!", "NOTIFICATION",MessageBoxButtons.OK);
            }

            
        }
        //Open file
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "TXT file| *.txt |RTF file| *.rtf";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                richText.LoadFile(openFile.FileName);
            }
        }
        //New file
       private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (cbFont.Text != "" && cbSize.Text != "")
            {
                richText.Font = new Font(cbFont.Text, float.Parse(cbSize.Text));
            }
        }
        //Save file
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //richText.SaveFile();
            MessageBox.Show("Bạn có muốn lưu văn bản vào máy?", "NOTIFICATION", MessageBoxButtons.YesNo);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.AddExtension = true;
            saveFile.RestoreDirectory = true;
            saveFile.DefaultExt = "TXT";
            saveFile.Filter = "RTF file| *.rtf | TXT file | *.txt| All files| *.*";
            //saveFile.InitialDirectory = @"D:/..."
            if (saveFile.CheckFileExists == false)
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    //richText.SaveFile(SaveFileDialog);
                    MessageBox.Show("Văn Bản Đã Được Lưu Thành Công!", "NOTIFICATION", MessageBoxButtons.OK);
                }
            }

            else if (saveFile.CheckPathExists == true)
            {
                MessageBox.Show("Văn Bản Đã Được Lưu Thành Công!", "NOTIFICATION", MessageBoxButtons.OK);
            }
        }
        //Save file in menu
        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if(cbFont.Text != "" && cbSize.Text != "")
            {
                richText.Font = new Font(cbFont.Text, float.Parse(cbSize.Text));
            }
        }
        //boi den chu
        private void btnBold_Click(object sender, EventArgs e)
        {
                Font newFont = new Font(richText.SelectionFont.FontFamily.Name, richText.SelectionFont.Size, FontStyle.Bold);
        }
        //Chu nghieng
        private void btnOblique_Click(object sender, EventArgs e)
        {
                Font newFont = new Font(richText.SelectionFont.FontFamily.Name, richText.SelectionFont.Size, FontStyle.Italic);
        }
        //Chu gach chan
        private void btnBold_Oblique_Click(object sender, EventArgs e)
        {
                Font newFont = new Font(richText.SelectionFont.FontFamily.Name, richText.SelectionFont.Size, FontStyle.Underline);
        }

        private void btnBold_Click_1(object sender, EventArgs e)
        {

        }
    }
}
