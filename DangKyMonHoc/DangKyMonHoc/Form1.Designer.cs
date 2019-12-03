namespace DangKyMonHoc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lB_Dich = new System.Windows.Forms.ListBox();
            this.lB_ChonMonHoc = new System.Windows.Forms.ListBox();
            this.cbChuyen_Nganh = new System.Windows.Forms.ComboBox();
            this.checkBox_Nu = new System.Windows.Forms.CheckBox();
            this.checkBox_Nam = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chuyên Ngành";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới Tính";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chọn Các Môn Học Tham Gia";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(348, 13);
            this.txtMSSV.Multiline = true;
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(177, 22);
            this.txtMSSV.TabIndex = 1;
            this.txtMSSV.TextChanged += new System.EventHandler(this.label1_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(348, 42);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(264, 22);
            this.txtTen.TabIndex = 1;
            this.txtTen.TextChanged += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChon);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lB_Dich);
            this.groupBox1.Controls.Add(this.lB_ChonMonHoc);
            this.groupBox1.Controls.Add(this.cbChuyen_Nganh);
            this.groupBox1.Controls.Add(this.checkBox_Nu);
            this.groupBox1.Controls.Add(this.checkBox_Nam);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 255);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnChon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChon.Location = new System.Drawing.Point(450, 211);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 37);
            this.btnChon.TabIndex = 7;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXoa.Location = new System.Drawing.Point(317, 211);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 37);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(413, 171);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(40, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.btnRemove.Move += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(413, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.lB_ChonMonHoc_SelectedIndexChanged);
            this.btnAdd.Move += new System.EventHandler(this.lB_Dich_SelectedIndexChanged);
            // 
            // lB_Dich
            // 
            this.lB_Dich.FormattingEnabled = true;
            this.lB_Dich.ItemHeight = 16;
            this.lB_Dich.Location = new System.Drawing.Point(459, 142);
            this.lB_Dich.Name = "lB_Dich";
            this.lB_Dich.Size = new System.Drawing.Size(183, 52);
            this.lB_Dich.TabIndex = 5;
            this.lB_Dich.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // lB_ChonMonHoc
            // 
            this.lB_ChonMonHoc.FormattingEnabled = true;
            this.lB_ChonMonHoc.ItemHeight = 16;
            this.lB_ChonMonHoc.Items.AddRange(new object[] {
            "Cơ Sở Dữ Liệu*",
            "Cơ Sở DL NC",
            "PTTK Hệ thống thông tin",
            "Che Giấu Thông Tin",
            "Mã Hóa Thông Tin",
            "Ẩn Thông tin trên DL Số",
            "Kiểm Thử Phần Mềm",
            "Lập Trình Java"});
            this.lB_ChonMonHoc.Location = new System.Drawing.Point(200, 142);
            this.lB_ChonMonHoc.Name = "lB_ChonMonHoc";
            this.lB_ChonMonHoc.Size = new System.Drawing.Size(207, 52);
            this.lB_ChonMonHoc.TabIndex = 4;
            //this.lB_ChonMonHoc.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cbChuyen_Nganh
            // 
            this.cbChuyen_Nganh.FormattingEnabled = true;
            this.cbChuyen_Nganh.Items.AddRange(new object[] {
            "An Toàn Thông Tin",
            "Hệ Thống Thông Tin*",
            "Công Nghệ Phần Mềm"});
            this.cbChuyen_Nganh.Location = new System.Drawing.Point(348, 70);
            this.cbChuyen_Nganh.Name = "cbChuyen_Nganh";
            this.cbChuyen_Nganh.Size = new System.Drawing.Size(264, 24);
            this.cbChuyen_Nganh.TabIndex = 3;
            //this.cbchuyen_nganh.selectedindexchanged += new system.eventhandler(this.lb_Dich_selectedindexchanged);
            // 
            // checkBox_Nu
            // 
            this.checkBox_Nu.AutoSize = true;
            this.checkBox_Nu.Location = new System.Drawing.Point(477, 100);
            this.checkBox_Nu.Name = "checkBox_Nu";
            this.checkBox_Nu.Size = new System.Drawing.Size(48, 21);
            this.checkBox_Nu.TabIndex = 2;
            this.checkBox_Nu.Text = "Nữ";
            this.checkBox_Nu.UseVisualStyleBackColor = true;
            // 
            // checkBox_Nam
            // 
            this.checkBox_Nam.AutoSize = true;
            this.checkBox_Nam.Location = new System.Drawing.Point(348, 97);
            this.checkBox_Nam.Name = "checkBox_Nam";
            this.checkBox_Nam.Size = new System.Drawing.Size(59, 21);
            this.checkBox_Nam.TabIndex = 2;
            this.checkBox_Nam.Text = "Nam";
            this.checkBox_Nam.UseVisualStyleBackColor = true;
            this.checkBox_Nam.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(69, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(672, 164);
            this.dataGridView1.TabIndex = 3;
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.MinimumWidth = 6;
            this.MSSV.Name = "MSSV";
            this.MSSV.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Chuyên Ngành";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giới Tính";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số Môn";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Nhập Liệu Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_Nu;
        private System.Windows.Forms.CheckBox checkBox_Nam;
        private System.Windows.Forms.ComboBox cbChuyen_Nganh;
        private System.Windows.Forms.ListBox lB_ChonMonHoc;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lB_Dich;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

