using System;
using System.Windows.Forms;

namespace RapChieuPhim.UI_Form
{
    public partial class fMain : Form
    {
        private string staffID;
        private string role;
        public fMain()
        {
            InitializeComponent();
        }
        public void GetUser(string ID, string Role)
        {
            this.staffID = ID;
            this.role = Role;
        }
        private void btnSellTicket_Click(object sender, EventArgs e)
        {
            fChonSuatChieu f = new fChonSuatChieu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnShowtime_Click(object sender, EventArgs e)
        {
            fShowtime f = new fShowtime();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void menuAccountInfor_Click(object sender, EventArgs e)
        {
            fAccount_Information f = new fAccount_Information();
            f.GetUserID(this.staffID); 
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void menuManager_Click(object sender, EventArgs e)
        {
            if (this.role == "Nhân Viên")
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            else
            {
                fManager f = new fManager();
            this.Hide();
            f.ShowDialog();
            this.Show();
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
