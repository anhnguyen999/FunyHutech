namespace UngDungMayTinh
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            this.btnPhepCong = new System.Windows.Forms.Button();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.btnPhepTru = new System.Windows.Forms.Button();
            this.btnPhepNhan = new System.Windows.Forms.Button();
            this.btnPhepChia = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorCheckNumber = new System.Windows.Forms.ErrorProvider(this.components);
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorCheckNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(90, 19);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(365, 31);
            label1.TabIndex = 1;
            label1.Text = "CHƯƠNG TRÌNH MÁY TÍNH";
            // 
            // btnPhepCong
            // 
            this.btnPhepCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhepCong.Location = new System.Drawing.Point(179, 161);
            this.btnPhepCong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPhepCong.Name = "btnPhepCong";
            this.btnPhepCong.Size = new System.Drawing.Size(58, 41);
            this.btnPhepCong.TabIndex = 0;
            this.btnPhepCong.Text = "+";
            this.btnPhepCong.UseVisualStyleBackColor = true;
            this.btnPhepCong.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // txtSoA
            // 
            this.txtSoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoA.Location = new System.Drawing.Point(179, 83);
            this.txtSoA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(245, 26);
            this.txtSoA.TabIndex = 2;
            this.txtSoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "SỐ A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "SỐ B";
            // 
            // txtSoB
            // 
            this.txtSoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoB.Location = new System.Drawing.Point(179, 122);
            this.txtSoB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(245, 26);
            this.txtSoB.TabIndex = 4;
            this.txtSoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumber_KeyPress);
            // 
            // btnPhepTru
            // 
            this.btnPhepTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhepTru.Location = new System.Drawing.Point(241, 161);
            this.btnPhepTru.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPhepTru.Name = "btnPhepTru";
            this.btnPhepTru.Size = new System.Drawing.Size(58, 41);
            this.btnPhepTru.TabIndex = 0;
            this.btnPhepTru.Text = "-";
            this.btnPhepTru.UseVisualStyleBackColor = true;
            this.btnPhepTru.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // btnPhepNhan
            // 
            this.btnPhepNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhepNhan.Location = new System.Drawing.Point(303, 161);
            this.btnPhepNhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPhepNhan.Name = "btnPhepNhan";
            this.btnPhepNhan.Size = new System.Drawing.Size(58, 41);
            this.btnPhepNhan.TabIndex = 0;
            this.btnPhepNhan.Text = "*";
            this.btnPhepNhan.UseVisualStyleBackColor = true;
            this.btnPhepNhan.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // btnPhepChia
            // 
            this.btnPhepChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhepChia.Location = new System.Drawing.Point(365, 161);
            this.btnPhepChia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPhepChia.Name = "btnPhepChia";
            this.btnPhepChia.Size = new System.Drawing.Size(58, 41);
            this.btnPhepChia.TabIndex = 0;
            this.btnPhepChia.Text = "/";
            this.btnPhepChia.UseVisualStyleBackColor = true;
            this.btnPhepChia.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(241, 222);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(183, 26);
            this.txtKetQua.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "KẾT QUẢ";
            // 
            // errorCheckNumber
            // 
            this.errorCheckNumber.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnPhepChia);
            this.Controls.Add(this.btnPhepNhan);
            this.Controls.Add(this.btnPhepTru);
            this.Controls.Add(this.btnPhepCong);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorCheckNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPhepCong;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Button btnPhepTru;
        private System.Windows.Forms.Button btnPhepNhan;
        private System.Windows.Forms.Button btnPhepChia;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorCheckNumber;
    }
}

