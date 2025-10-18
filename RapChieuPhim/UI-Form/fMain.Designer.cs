namespace RapChieuPhim.UI_Form
{
    partial class fMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAccountInfor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManager = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSellTicket = new System.Windows.Forms.Button();
            this.btnShowtime = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAccount,
            this.menuManager,
            this.menuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAccount
            // 
            this.menuAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAccountInfor,
            this.menuLogout});
            this.menuAccount.Name = "menuAccount";
            this.menuAccount.Size = new System.Drawing.Size(96, 27);
            this.menuAccount.Text = "Tài khoản";
            // 
            // menuAccountInfor
            // 
            this.menuAccountInfor.Name = "menuAccountInfor";
            this.menuAccountInfor.Size = new System.Drawing.Size(244, 28);
            this.menuAccountInfor.Text = "Thông tin tài khoản";
            this.menuAccountInfor.Click += new System.EventHandler(this.menuAccountInfor_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(244, 28);
            this.menuLogout.Text = "Đăng xuất";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // menuManager
            // 
            this.menuManager.Name = "menuManager";
            this.menuManager.Size = new System.Drawing.Size(83, 27);
            this.menuManager.Text = "Quản lý";
            this.menuManager.Click += new System.EventHandler(this.menuManager_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(68, 27);
            this.menuExit.Text = "Thoát";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // btnSellTicket
            // 
            this.btnSellTicket.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellTicket.Location = new System.Drawing.Point(95, 122);
            this.btnSellTicket.Name = "btnSellTicket";
            this.btnSellTicket.Size = new System.Drawing.Size(141, 135);
            this.btnSellTicket.TabIndex = 1;
            this.btnSellTicket.Text = "Bán Vé";
            this.btnSellTicket.UseVisualStyleBackColor = true;
            this.btnSellTicket.Click += new System.EventHandler(this.btnSellTicket_Click);
            // 
            // btnShowtime
            // 
            this.btnShowtime.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowtime.Location = new System.Drawing.Point(363, 122);
            this.btnShowtime.Name = "btnShowtime";
            this.btnShowtime.Size = new System.Drawing.Size(141, 135);
            this.btnShowtime.TabIndex = 2;
            this.btnShowtime.Text = "Suất Chiếu";
            this.btnShowtime.UseVisualStyleBackColor = true;
            this.btnShowtime.Click += new System.EventHandler(this.btnShowtime_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 361);
            this.Controls.Add(this.btnShowtime);
            this.Controls.Add(this.btnSellTicket);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAccount;
        private System.Windows.Forms.ToolStripMenuItem menuAccountInfor;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem menuManager;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Button btnSellTicket;
        private System.Windows.Forms.Button btnShowtime;
    }
}