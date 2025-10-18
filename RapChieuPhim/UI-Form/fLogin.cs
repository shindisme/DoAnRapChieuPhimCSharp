using RapChieuPhim.Class;
using RapChieuPhim.Manage_List;
using System;
using System.Windows.Forms;

namespace RapChieuPhim.UI_Form
{
    public partial class fLogin : Form
    {
        private cStaffList SList = new cStaffList();
        public fLogin()
        {
            InitializeComponent();
        }
        private void fLogin_Load(object sender, EventArgs e)
        {
            SList.LoadFile();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thật sự muốn thoát!?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                e.Cancel = true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text.Trim();
            string password = txbPassword.Text.Trim();

            if (userName == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (SList.Login(userName, password))
            {
                cStaff s = SList.getStaff(userName);
                fMain f = new fMain();
                f.GetUser(s.ID, s.Role);
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                f.ShowDialog();
            }
            else MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
