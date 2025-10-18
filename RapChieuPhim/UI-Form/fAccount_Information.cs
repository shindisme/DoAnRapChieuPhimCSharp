using RapChieuPhim.Class;
using RapChieuPhim.Manage_List;
using System;
using System.Windows.Forms;

namespace RapChieuPhim.UI_Form
{
    public partial class fAccount_Information : Form
    {
        private cStaffList SList = new cStaffList();
        private string staffID;
        public fAccount_Information()
        {
            InitializeComponent();
        }
        public void GetUserID(string ID)
        {
            staffID = ID;
        }
        private void btnChangePasswrd_Click(object sender, EventArgs e)
        {
            fChangePasswrd f = new fChangePasswrd();
            f.GetUserID(staffID);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cStaff currentStaff = SList.getStaff(staffID);
            string fullName = txbFullName.Text.Trim();
            string gender = rdbMale.Checked ? "Nam" : "Nữ";
            DateTime birthday = dtpBirthDay.Value;
            string email = txbEmail.Text.Trim();
            string phoneNumber = txbPhoneNumber.Text.Trim();
            string userID = txbID_ReadOnly.Text.Trim();
            cStaff newStaff = new cStaff(staffID, fullName, birthday, gender, email, phoneNumber, currentStaff.Role, currentStaff.Password);

            SList.Modify(newStaff);
            MessageBox.Show("Đã lưu thông tin","Thông tin",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadStaffInfo()
        {
            cStaff staff = SList.getStaff(staffID);
            if (staff != null)
            {
                txbID_ReadOnly.Text = staff.ID;
                txbFullName.Text = staff.FullName;
                dtpBirthDay.Value = staff.Birthday;
                rdbMale.Checked = staff.Gender == "Nam";
                rdbFemale.Checked = staff.Gender == "Nữ";
                txbEmail.Text = staff.Email;
                txbPhoneNumber.Text = staff.PhoneNumber;
            }
        }
        private void fAccountInfor_Load(object sender, EventArgs e)
        {
            SList.LoadFile();
            LoadStaffInfo();
        }
    }
}
