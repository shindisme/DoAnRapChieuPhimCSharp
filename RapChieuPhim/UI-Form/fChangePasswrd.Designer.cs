namespace RapChieuPhim.UI_Form
{
    partial class fChangePasswrd
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txbConfirmPasswrd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNewPasswrd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCurrentPasswrd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(299, 189);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 42);
            this.btnExit.TabIndex = 110;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(185, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 42);
            this.btnSave.TabIndex = 111;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txbConfirmPasswrd
            // 
            this.txbConfirmPasswrd.BackColor = System.Drawing.SystemColors.Window;
            this.txbConfirmPasswrd.Font = new System.Drawing.Font("Rockwell", 9F);
            this.txbConfirmPasswrd.Location = new System.Drawing.Point(185, 144);
            this.txbConfirmPasswrd.Name = "txbConfirmPasswrd";
            this.txbConfirmPasswrd.Size = new System.Drawing.Size(205, 25);
            this.txbConfirmPasswrd.TabIndex = 104;
            this.txbConfirmPasswrd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 107;
            this.label2.Text = "Nhập lại mật khẩu:";
            // 
            // txbNewPasswrd
            // 
            this.txbNewPasswrd.BackColor = System.Drawing.SystemColors.Window;
            this.txbNewPasswrd.Font = new System.Drawing.Font("Rockwell", 9F);
            this.txbNewPasswrd.Location = new System.Drawing.Point(185, 90);
            this.txbNewPasswrd.Name = "txbNewPasswrd";
            this.txbNewPasswrd.Size = new System.Drawing.Size(205, 25);
            this.txbNewPasswrd.TabIndex = 105;
            this.txbNewPasswrd.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 108;
            this.label1.Text = "Mật khẩu mới:";
            // 
            // txbCurrentPasswrd
            // 
            this.txbCurrentPasswrd.BackColor = System.Drawing.SystemColors.Window;
            this.txbCurrentPasswrd.Font = new System.Drawing.Font("Rockwell", 9F);
            this.txbCurrentPasswrd.Location = new System.Drawing.Point(185, 38);
            this.txbCurrentPasswrd.Name = "txbCurrentPasswrd";
            this.txbCurrentPasswrd.Size = new System.Drawing.Size(205, 25);
            this.txbCurrentPasswrd.TabIndex = 106;
            this.txbCurrentPasswrd.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 24);
            this.label4.TabIndex = 109;
            this.label4.Text = "Mật khẩu hiện tại:";
            // 
            // fChangePasswrd
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(448, 252);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbConfirmPasswrd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNewPasswrd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCurrentPasswrd);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fChangePasswrd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.fChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbConfirmPasswrd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNewPasswrd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCurrentPasswrd;
        private System.Windows.Forms.Label label4;
    }
}