using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Play_Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    this.toolStripStatusLabel1.Text = string.Format("Hôm nay là ngày 
        //    { 0}
        //    -Bây giờ là { 1}
        //    ", DateTime.Now.ToString("dd / MM / yyyy"), 
        //    DateTime.Now.ToString("hh:mm:ss tt"));
        //}

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
