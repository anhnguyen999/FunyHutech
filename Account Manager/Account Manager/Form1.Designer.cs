namespace Account_Manager
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
            this.TITLE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccID = new System.Windows.Forms.TextBox();
            this.txt_AccName = new System.Windows.Forms.TextBox();
            this.txt_AccAdress = new System.Windows.Forms.TextBox();
            this.txt_AccMoney = new System.Windows.Forms.TextBox();
            this.btnAdd_Update = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstAccount = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAccID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAccName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAccAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAccMoney = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TITLE
            // 
            this.TITLE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TITLE.BackColor = System.Drawing.Color.Gainsboro;
            this.TITLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITLE.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TITLE.Location = new System.Drawing.Point(141, 9);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(512, 34);
            this.TITLE.TabIndex = 0;
            this.TITLE.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            this.TITLE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa Chỉ Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số Tiền Trong Tài Khoản";
            // 
            // txtAccID
            // 
            this.txtAccID.Location = new System.Drawing.Point(343, 57);
            this.txtAccID.Name = "txtAccID";
            this.txtAccID.Size = new System.Drawing.Size(289, 22);
            this.txtAccID.TabIndex = 2;
            // 
            // txt_AccName
            // 
            this.txt_AccName.Location = new System.Drawing.Point(343, 88);
            this.txt_AccName.Name = "txt_AccName";
            this.txt_AccName.Size = new System.Drawing.Size(289, 22);
            this.txt_AccName.TabIndex = 2;
            // 
            // txt_AccAdress
            // 
            this.txt_AccAdress.Location = new System.Drawing.Point(343, 117);
            this.txt_AccAdress.Name = "txt_AccAdress";
            this.txt_AccAdress.Size = new System.Drawing.Size(289, 22);
            this.txt_AccAdress.TabIndex = 2;
            // 
            // txt_AccMoney
            // 
            this.txt_AccMoney.Location = new System.Drawing.Point(343, 145);
            this.txt_AccMoney.Name = "txt_AccMoney";
            this.txt_AccMoney.Size = new System.Drawing.Size(289, 22);
            this.txt_AccMoney.TabIndex = 2;
            // 
            // btnAdd_Update
            // 
            this.btnAdd_Update.Location = new System.Drawing.Point(343, 173);
            this.btnAdd_Update.Name = "btnAdd_Update";
            this.btnAdd_Update.Size = new System.Drawing.Size(117, 36);
            this.btnAdd_Update.TabIndex = 3;
            this.btnAdd_Update.Text = "Thêm/&Cập Nhật";
            this.btnAdd_Update.UseVisualStyleBackColor = true;
            this.btnAdd_Update.Click += new System.EventHandler(this.btnAdd_Update_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(466, 173);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 36);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(547, 173);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstAccount
            // 
            this.lstAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colAccID,
            this.colAccName,
            this.colAccAddress,
            this.colAccMoney});
            this.lstAccount.FullRowSelect = true;
            this.lstAccount.GridLines = true;
            this.lstAccount.HideSelection = false;
            this.lstAccount.Location = new System.Drawing.Point(85, 215);
            this.lstAccount.Name = "lstAccount";
            this.lstAccount.Size = new System.Drawing.Size(661, 153);
            this.lstAccount.TabIndex = 4;
            this.lstAccount.UseCompatibleStateImageBehavior = false;
            this.lstAccount.View = System.Windows.Forms.View.Details;
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            // 
            // colAccID
            // 
            this.colAccID.Text = "ID";
            this.colAccID.Width = 80;
            // 
            // colAccName
            // 
            this.colAccName.Text = "Name";
            this.colAccName.Width = 200;
            // 
            // colAccAddress
            // 
            this.colAccAddress.Text = "Address";
            this.colAccAddress.Width = 150;
            // 
            // colAccMoney
            // 
            this.colAccMoney.Text = "Money";
            this.colAccMoney.Width = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tổng tiền:";
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(521, 389);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(225, 22);
            this.txt_Total.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstAccount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd_Update);
            this.Controls.Add(this.txt_AccMoney);
            this.Controls.Add(this.txt_AccAdress);
            this.Controls.Add(this.txt_AccName);
            this.Controls.Add(this.txtAccID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TITLE);
            this.Name = "Form1";
            this.Text = "Account Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TITLE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccID;
        private System.Windows.Forms.TextBox txt_AccName;
        private System.Windows.Forms.TextBox txt_AccAdress;
        private System.Windows.Forms.TextBox txt_AccMoney;
        private System.Windows.Forms.Button btnAdd_Update;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView lstAccount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colAccID;
        private System.Windows.Forms.ColumnHeader colAccName;
        private System.Windows.Forms.ColumnHeader colAccAddress;
        private System.Windows.Forms.ColumnHeader colAccMoney;
    }
}

