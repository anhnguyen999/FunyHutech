namespace QuanLySinhVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_TenSV = new System.Windows.Forms.Label();
            this.lb_MaSV = new System.Windows.Forms.Label();
            this.lb_ThoiGianDangKy = new System.Windows.Forms.Label();
            this.lb_ChuyenNganh = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.txt_TenSV = new System.Windows.Forms.TextBox();
            this.txt_ThoiGianDangKy = new System.Windows.Forms.TextBox();
            this.cbx_MonDangKy = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_MonDangKy = new System.Windows.Forms.Label();
            this.cbx_ChuyenNganh = new System.Windows.Forms.ComboBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_ChuyenNganh);
            this.groupBox1.Controls.Add(this.cbx_MonDangKy);
            this.groupBox1.Controls.Add(this.txt_ThoiGianDangKy);
            this.groupBox1.Controls.Add(this.txt_TenSV);
            this.groupBox1.Controls.Add(this.txt_MaSV);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.lb_ChuyenNganh);
            this.groupBox1.Controls.Add(this.lb_MonDangKy);
            this.groupBox1.Controls.Add(this.lb_ThoiGianDangKy);
            this.groupBox1.Controls.Add(this.lb_MaSV);
            this.groupBox1.Controls.Add(this.lb_TenSV);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 395);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lb_TenSV
            // 
            this.lb_TenSV.AutoSize = true;
            this.lb_TenSV.Location = new System.Drawing.Point(19, 99);
            this.lb_TenSV.Name = "lb_TenSV";
            this.lb_TenSV.Size = new System.Drawing.Size(97, 17);
            this.lb_TenSV.TabIndex = 0;
            this.lb_TenSV.Text = "Tên Sinh Viên";
            this.lb_TenSV.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lb_TenSV.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_MaSV
            // 
            this.lb_MaSV.AutoSize = true;
            this.lb_MaSV.Location = new System.Drawing.Point(19, 52);
            this.lb_MaSV.Name = "lb_MaSV";
            this.lb_MaSV.Size = new System.Drawing.Size(91, 17);
            this.lb_MaSV.TabIndex = 0;
            this.lb_MaSV.Text = "Mã Sinh Viên";
            // 
            // lb_ThoiGianDangKy
            // 
            this.lb_ThoiGianDangKy.AutoSize = true;
            this.lb_ThoiGianDangKy.Location = new System.Drawing.Point(23, 279);
            this.lb_ThoiGianDangKy.Name = "lb_ThoiGianDangKy";
            this.lb_ThoiGianDangKy.Size = new System.Drawing.Size(128, 17);
            this.lb_ThoiGianDangKy.TabIndex = 0;
            this.lb_ThoiGianDangKy.Text = "Thời Gian Đăng Ký";
            // 
            // lb_ChuyenNganh
            // 
            this.lb_ChuyenNganh.AutoSize = true;
            this.lb_ChuyenNganh.Location = new System.Drawing.Point(19, 165);
            this.lb_ChuyenNganh.Name = "lb_ChuyenNganh";
            this.lb_ChuyenNganh.Size = new System.Drawing.Size(102, 17);
            this.lb_ChuyenNganh.TabIndex = 0;
            this.lb_ChuyenNganh.Text = "Chuyên Ngành";
            this.lb_ChuyenNganh.Click += new System.EventHandler(this.lb_ChuyenNganh_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_add.Location = new System.Drawing.Point(62, 324);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(122, 42);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add/Update";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSV.Location = new System.Drawing.Point(144, 41);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(245, 28);
            this.txt_MaSV.TabIndex = 2;
            this.txt_MaSV.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_TenSV
            // 
            this.txt_TenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSV.Location = new System.Drawing.Point(144, 99);
            this.txt_TenSV.Name = "txt_TenSV";
            this.txt_TenSV.Size = new System.Drawing.Size(245, 28);
            this.txt_TenSV.TabIndex = 2;
            this.txt_TenSV.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_ThoiGianDangKy
            // 
            this.txt_ThoiGianDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThoiGianDangKy.Location = new System.Drawing.Point(189, 273);
            this.txt_ThoiGianDangKy.Name = "txt_ThoiGianDangKy";
            this.txt_ThoiGianDangKy.Size = new System.Drawing.Size(200, 27);
            this.txt_ThoiGianDangKy.TabIndex = 2;
            this.txt_ThoiGianDangKy.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbx_MonDangKy
            // 
            this.cbx_MonDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_MonDangKy.FormattingEnabled = true;
            this.cbx_MonDangKy.Items.AddRange(new object[] {
            "Lập trình web",
            "Tư tưởng Hồ Chí Minh",
            "Xác suất thống kê",
            "Thực tập doanh nghiệp ngành Công nghệ thông tin",
            "Bảo mật thông tin",
            "Phân tích thiết kế hệ thống thông tin",
            "Đồ án cơ sở công nghệ thông tin",
            "Kinh Tế Vĩ Mô",
            "Vẽ",
            "Autocad Xây Dựng Nhà"});
            this.cbx_MonDangKy.Location = new System.Drawing.Point(127, 216);
            this.cbx_MonDangKy.Name = "cbx_MonDangKy";
            this.cbx_MonDangKy.Size = new System.Drawing.Size(262, 28);
            this.cbx_MonDangKy.TabIndex = 3;
            this.cbx_MonDangKy.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.TenChuyenNganh,
            this.TenMonHoc,
            this.NgayDangKy});
            this.dataGridView1.Location = new System.Drawing.Point(461, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(718, 395);
            this.dataGridView1.TabIndex = 1;
            // 
            // MaSV
            // 
            this.MaSV.HeaderText = "Mã SV";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 125;
            // 
            // TenChuyenNganh
            // 
            this.TenChuyenNganh.HeaderText = "Chuyên Ngành";
            this.TenChuyenNganh.MinimumWidth = 6;
            this.TenChuyenNganh.Name = "TenChuyenNganh";
            this.TenChuyenNganh.Width = 125;
            // 
            // TenMonHoc
            // 
            this.TenMonHoc.HeaderText = "Môn Đăng Ký";
            this.TenMonHoc.MinimumWidth = 6;
            this.TenMonHoc.Name = "TenMonHoc";
            this.TenMonHoc.Width = 125;
            // 
            // NgayDangKy
            // 
            this.NgayDangKy.HeaderText = "Ngày Đăng Ký";
            this.NgayDangKy.MinimumWidth = 6;
            this.NgayDangKy.Name = "NgayDangKy";
            this.NgayDangKy.Width = 125;
            // 
            // lb_MonDangKy
            // 
            this.lb_MonDangKy.AutoSize = true;
            this.lb_MonDangKy.Location = new System.Drawing.Point(23, 222);
            this.lb_MonDangKy.Name = "lb_MonDangKy";
            this.lb_MonDangKy.Size = new System.Drawing.Size(93, 17);
            this.lb_MonDangKy.TabIndex = 0;
            this.lb_MonDangKy.Text = "Môn Đăng Ký";
            // 
            // cbx_ChuyenNganh
            // 
            this.cbx_ChuyenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ChuyenNganh.FormattingEnabled = true;
            this.cbx_ChuyenNganh.Items.AddRange(new object[] {
            "CNTT",
            "QTKD",
            "QTDL-NH-KS",
            "LTK",
            "XD",
            "TT",
            "TKDH"});
            this.cbx_ChuyenNganh.Location = new System.Drawing.Point(144, 159);
            this.cbx_ChuyenNganh.Name = "cbx_ChuyenNganh";
            this.cbx_ChuyenNganh.Size = new System.Drawing.Size(245, 28);
            this.cbx_ChuyenNganh.TabIndex = 3;
            this.cbx_ChuyenNganh.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Red;
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Delete.Location = new System.Drawing.Point(233, 324);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(122, 42);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 443);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Quản Lý Sinh Viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ThoiGianDangKy;
        private System.Windows.Forms.TextBox txt_TenSV;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lb_ChuyenNganh;
        private System.Windows.Forms.Label lb_ThoiGianDangKy;
        private System.Windows.Forms.Label lb_MaSV;
        private System.Windows.Forms.Label lb_TenSV;
        private System.Windows.Forms.ComboBox cbx_MonDangKy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDangKy;
        private System.Windows.Forms.ComboBox cbx_ChuyenNganh;
        private System.Windows.Forms.Label lb_MonDangKy;
        private System.Windows.Forms.Button btn_Delete;
    }
}

