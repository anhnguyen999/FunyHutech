namespace Lab02_02
{
    partial class frmQuanLySinhVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_Nu = new System.Windows.Forms.RadioButton();
            this.rd_Nam = new System.Windows.Forms.RadioButton();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoaTT = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_chonmonhoc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbChuyenNganh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.dgvDangKyMonHoc = new System.Windows.Forms.DataGridView();
            this.lstMonHocDaChon = new System.Windows.Forms.ListBox();
            this.lstMonHocChuaChon = new System.Windows.Forms.ListBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKyMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstMonHocChuaChon);
            this.groupBox1.Controls.Add(this.lstMonHocDaChon);
            this.groupBox1.Controls.Add(this.rd_Nu);
            this.groupBox1.Controls.Add(this.rd_Nam);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnXoaTT);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lbl_chonmonhoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbChuyenNganh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong Tin Sinh Vien";
            // 
            // rd_Nu
            // 
            this.rd_Nu.AutoSize = true;
            this.rd_Nu.Location = new System.Drawing.Point(325, 154);
            this.rd_Nu.Name = "rd_Nu";
            this.rd_Nu.Size = new System.Drawing.Size(43, 20);
            this.rd_Nu.TabIndex = 8;
            this.rd_Nu.TabStop = true;
            this.rd_Nu.Text = "Nu";
            this.rd_Nu.UseVisualStyleBackColor = true;
            // 
            // rd_Nam
            // 
            this.rd_Nam.AutoSize = true;
            this.rd_Nam.Location = new System.Drawing.Point(177, 154);
            this.rd_Nam.Name = "rd_Nam";
            this.rd_Nam.Size = new System.Drawing.Size(55, 20);
            this.rd_Nam.TabIndex = 7;
            this.rd_Nam.TabStop = true;
            this.rd_Nam.Text = "Nam";
            this.rd_Nam.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(131, 298);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(121, 34);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Luu Thong Tin";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoaTT
            // 
            this.btnXoaTT.Location = new System.Drawing.Point(310, 298);
            this.btnXoaTT.Name = "btnXoaTT";
            this.btnXoaTT.Size = new System.Drawing.Size(113, 34);
            this.btnXoaTT.TabIndex = 6;
            this.btnXoaTT.Text = "Xoa";
            this.btnXoaTT.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(260, 263);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(43, 29);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "<";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbl_chonmonhoc
            // 
            this.lbl_chonmonhoc.AutoSize = true;
            this.lbl_chonmonhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chonmonhoc.Location = new System.Drawing.Point(37, 196);
            this.lbl_chonmonhoc.Name = "lbl_chonmonhoc";
            this.lbl_chonmonhoc.Size = new System.Drawing.Size(140, 25);
            this.lbl_chonmonhoc.TabIndex = 1;
            this.lbl_chonmonhoc.Text = "Chon mon hoc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gioi Tinh";
            // 
            // cmbChuyenNganh
            // 
            this.cmbChuyenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChuyenNganh.FormattingEnabled = true;
            this.cmbChuyenNganh.Location = new System.Drawing.Point(177, 108);
            this.cmbChuyenNganh.Name = "cmbChuyenNganh";
            this.cmbChuyenNganh.Size = new System.Drawing.Size(320, 32);
            this.cmbChuyenNganh.TabIndex = 2;
            this.cmbChuyenNganh.SelectedIndexChanged += new System.EventHandler(this.cmbChuyenNganh_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chuyen Nganh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ho Ten";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ma Sinh Vien";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(177, 63);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(320, 29);
            this.txtHoTen.TabIndex = 0;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(177, 18);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(211, 29);
            this.txtMaSV.TabIndex = 0;
            // 
            // dgvDangKyMonHoc
            // 
            this.dgvDangKyMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDangKyMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvDangKyMonHoc.Location = new System.Drawing.Point(-3, 394);
            this.dgvDangKyMonHoc.Name = "dgvDangKyMonHoc";
            this.dgvDangKyMonHoc.Size = new System.Drawing.Size(565, 112);
            this.dgvDangKyMonHoc.TabIndex = 4;
            // 
            // lstMonHocDaChon
            // 
            this.lstMonHocDaChon.FormattingEnabled = true;
            this.lstMonHocDaChon.ItemHeight = 16;
            this.lstMonHocDaChon.Location = new System.Drawing.Point(354, 224);
            this.lstMonHocDaChon.Name = "lstMonHocDaChon";
            this.lstMonHocDaChon.Size = new System.Drawing.Size(171, 68);
            this.lstMonHocDaChon.TabIndex = 9;
            // 
            // lstMonHocChuaChon
            // 
            this.lstMonHocChuaChon.FormattingEnabled = true;
            this.lstMonHocChuaChon.ItemHeight = 16;
            this.lstMonHocChuaChon.Location = new System.Drawing.Point(42, 224);
            this.lstMonHocChuaChon.Name = "lstMonHocChuaChon";
            this.lstMonHocChuaChon.Size = new System.Drawing.Size(190, 68);
            this.lstMonHocChuaChon.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ma SV";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ho Ten";
            this.Column2.Name = "Column2";
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Chuyen Nganh";
            this.Column3.Name = "Column3";
            this.Column3.Width = 160;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Gioi Tinh";
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "So Mon";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // frmQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 546);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDangKyMonHoc);
            this.Name = "frmQuanLySinhVien";
            this.Load += new System.EventHandler(this.frmQuanLySinhVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKyMonHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDangKyMonHoc;
        private System.Windows.Forms.ComboBox cmbChuyenNganh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoaTT;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rd_Nu;
        private System.Windows.Forms.RadioButton rd_Nam;
        private System.Windows.Forms.Label lbl_chonmonhoc;
        private System.Windows.Forms.ListBox lstMonHocDaChon;
        private System.Windows.Forms.ListBox lstMonHocChuaChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

