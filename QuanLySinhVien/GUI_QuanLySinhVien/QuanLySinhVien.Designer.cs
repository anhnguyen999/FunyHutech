namespace GUI_QuanLySinhVien
{
    partial class QuanLySinhVien
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
            this.components = new System.ComponentModel.Container();
            this.cbChuyenNganh = new System.Windows.Forms.ComboBox();
            this.chuyenNganhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chuyenNganhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbChuyenNganh
            // 
            this.cbChuyenNganh.DataSource = this.chuyenNganhBindingSource;
            this.cbChuyenNganh.FormattingEnabled = true;
            this.cbChuyenNganh.Location = new System.Drawing.Point(355, 151);
            this.cbChuyenNganh.Name = "cbChuyenNganh";
            this.cbChuyenNganh.Size = new System.Drawing.Size(292, 24);
            this.cbChuyenNganh.TabIndex = 0;
            // 
            // 
            // chuyenNganhBindingSource
            // 
            this.chuyenNganhBindingSource.DataMember = "ChuyenNganh";
            // 
            // chuyenNganhTableAdapter
            // 
            // 
            // QuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbChuyenNganh);
            this.Name = "QuanLySinhVien";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.QuanLySinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chuyenNganhBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbChuyenNganh;
        private System.Windows.Forms.BindingSource chuyenNganhBindingSource;
    }
}