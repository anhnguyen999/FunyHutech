namespace Calculator
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
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.errNumber1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNumber2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNumber1.Location = new System.Drawing.Point(12, 77);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(94, 24);
            this.lblNumber1.TabIndex = 0;
            this.lblNumber1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(29, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "CALCULATOR PROGRAM";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNumber2.Location = new System.Drawing.Point(12, 134);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(94, 24);
            this.lblNumber2.TabIndex = 2;
            this.lblNumber2.Text = "Number 2";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblResult.Location = new System.Drawing.Point(44, 307);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(62, 24);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNumber1.Location = new System.Drawing.Point(116, 76);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(346, 30);
            this.txtNumber1.TabIndex = 4;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNumber2.Location = new System.Drawing.Point(116, 134);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(346, 30);
            this.txtNumber2.TabIndex = 5;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtResult.Location = new System.Drawing.Point(116, 302);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(346, 30);
            this.txtResult.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btnAdd.Location = new System.Drawing.Point(48, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 52);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btnSub.Location = new System.Drawing.Point(148, 205);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(60, 52);
            this.btnSub.TabIndex = 8;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            // 
            // btnMul
            // 
            this.btnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btnMul.Location = new System.Drawing.Point(251, 205);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(60, 52);
            this.btnMul.TabIndex = 9;
            this.btnMul.Text = "x";
            this.btnMul.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btnDiv.Location = new System.Drawing.Point(358, 205);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(60, 52);
            this.btnDiv.TabIndex = 10;
            this.btnDiv.Text = ":";
            this.btnDiv.UseVisualStyleBackColor = true;
            // 
            // errNumber1
            // 
            this.errNumber1.ContainerControl = this;
            // 
            // errNumber2
            // 
            this.errNumber2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 363);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumber1);
            this.Name = "Form1";
            this.Text = "Calculator Program";
            ((System.ComponentModel.ISupportInitialize)(this.errNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.ErrorProvider errNumber1;
        private System.Windows.Forms.ErrorProvider errNumber2;
    }
}

