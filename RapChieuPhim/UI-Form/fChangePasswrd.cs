using RapChieuPhim.Class;
using RapChieuPhim.Manage_List;
using System;
using System.Windows.Forms;

namespace RapChieuPhim.UI_Form
{
    public partial class fChangePasswrd : Form
    {
        private cStaffList SList = new cStaffList();
        private string staffID;

        public fChangePasswrd()
        {
            InitializeComponent();
        }
        public void GetUserID(string ID)
        {
            staffID = ID;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cStaff currentStaff = SList.getStaff(staffID);
            if (currentStaff.Password != txbCurrentPasswrd.Text)
            {
                MessageBox.Show("Sai mật khẩu hiện tại!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbCurrentPasswrd.Clear();
                txbCurrentPasswrd.Focus();
                return;
            }
            if (txbNewPasswrd.Text != txbConfirmPasswrd.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbConfirmPasswrd.Clear();
                txbConfirmPasswrd.Focus();
                return;
            }
            cStaff newStaff = new cStaff(
                currentStaff.ID,
                currentStaff.FullName,
                currentStaff.Birthday,
                currentStaff.Gender,
                currentStaff.Email,
                currentStaff.PhoneNumber,
                currentStaff.Role,
                txbNewPasswrd.Text
            );
            SList.Modify(newStaff);
            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void fChangePassword_Load(object sender, EventArgs e)
        {
            SList.LoadFile();
        }
    }
}
