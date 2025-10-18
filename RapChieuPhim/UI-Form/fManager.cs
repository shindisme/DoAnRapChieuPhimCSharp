using RapChieuPhim.Class;
using RapChieuPhim.Manage_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RapChieuPhim.UI_Form
{
    public partial class fManager : Form
    {
        private cRoomList Rlist = new cRoomList();
        private cMovieList Mlist = new cMovieList();
        private cStaffList SList = new cStaffList();

        public fManager()
        {
            InitializeComponent();

        }
        #region Event
        private void fManager_Load(object sender, EventArgs e)
        {
            Mlist.LoadFile();
            ShowListOf_Movies(dgvMovies, Mlist.getListOfMovies());
            ComboBox_Genre();
            
            Rlist.LoadFile();
            ShowListOf_Rooms(dgvRoom, Rlist.getListOfRooms());
            ComboBox_RoomType();

            SList.LoadFile();
            ShowListOf_Staffs(dgvStaff, SList.getListOfStaffs());
            cboGender.Items.Add("Nam");
            cboGender.Items.Add("Nữ");

        }

        private void fManager_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void txbDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }
        private void dgvMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cMovie mv = Mlist.getListOfMovies()[e.RowIndex];

                txbMovieCode.Text = mv.MovieID;
                txbMovieName.Text = mv.MovieName;
                txbDirector.Text = mv.Director;
                txbActor.Text = mv.Actors;
                txbCountry.Text = mv.Country;
                txbDuration.Text = mv.Duration.ToString();

                string[] genres = mv.Genres.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                foreach (Control ctrl in grbGenres.Controls)
                {
                    if (ctrl is CheckBox ckb)
                    {
                        ckb.Checked = genres.Contains(ckb.Text);
                    }
                }
            }
        }
        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cRoom r = Rlist.getListOfRooms()[e.RowIndex];
                txbRoomCode.Text = r.RoomID;
                txbRoomName.Text = r.RoomName;
                cboRoomType.Text = r.RoomType;
                if (r.Status == "Mở")
                {
                    rdbOpen.Checked = true;
                }
                else rdbClose.Checked = true;
            }
        }
        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                cStaff s = SList.getListOfStaffs()[e.RowIndex]; 
                txbID.Text = s.ID;
                txbFullName.Text = s.FullName;
                dtpBirthday.Value = s.Birthday;
                txbEmail.Text = s.Email;
                txbPhoneNumber.Text = s.PhoneNumber;
                txbGivePasswrd.Text = s.Password;

                if (s.Role == "Admin")
                {
                    rdbAdmin.Checked = true;
                }
                else rdbStaff.Checked = true;

                if (s.Gender == "Nam")
                {
                    rdbMale.Checked = true;
                }
                else rdbFemale.Checked = true;

            }
        }
        #endregion
        #region Button
        /* ------------------------------------------- Phim ------------------------------------------- */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string movieCode = txbMovieCode.Text;
            string movieName = txbMovieName.Text;
            string director = txbDirector.Text;
            string actors = txbActor.Text;
            string genres = getSelectedGenres();
            int duration;
            if (!int.TryParse(txbDuration.Text, out duration))
            {
                MessageBox.Show("Thời gian không hợp lệ\nVui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDuration.Focus();
                return;
            }
            string country = txbCountry.Text;

            cMovie m = new cMovie(movieCode, movieName, director, actors, genres, duration, country);

            Mlist.Add(m);
            ShowListOf_Movies(dgvMovies, Mlist.getListOfMovies());
            ClearInput();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvMovies.SelectedRows.Count > 0)
            {
                string code = txbMovieCode.Text;
                cMovie mv = Mlist.getMovie(code);

                if (mv != null)
                {
                    Mlist.Delete(code);
                    ShowListOf_Movies(dgvMovies, Mlist.getListOfMovies());
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phim để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phim để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            string movieCode = txbMovieCode.Text;
            string movieName = txbMovieName.Text;
            string director = txbDirector.Text;
            string actors = txbActor.Text;
            string genres = getSelectedGenres();
            string country = txbCountry.Text;
            int duration;
            if (!int.TryParse(txbDuration.Text, out duration))
            {
                MessageBox.Show("Thời gian không hợp lệ\nVui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDuration.Focus();
                return;
            }

            cMovie mv = new cMovie(movieCode, movieName, director, actors, genres, duration, country);

            Mlist.Modify(mv);
            ShowListOf_Movies(dgvStaff, Mlist.getListOfMovies());
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            string movieCode = txbFind_MovieCode.Text.Trim();
            string movieName = txbFind_MovieName.Text.Trim();
            string director = txbFind_Director.Text.Trim();
            string actors = txbFind_Actors.Text.Trim();
            string country = txbFind_Country.Text.Trim();
            string genre = cboFind_Genres.SelectedItem?.ToString() ?? string.Empty;
            List<cMovie> result = new List<cMovie>();

            if (!string.IsNullOrEmpty(movieCode))
            {
                result.AddRange(Mlist.findMovieCode(movieCode));
            }
            if (!string.IsNullOrEmpty(movieName))
            {
                result.AddRange(Mlist.findMovieName(movieName));
            }
            if (!string.IsNullOrEmpty(director))
            {
                result.AddRange(Mlist.findDirector(director));
            }
            if (!string.IsNullOrEmpty(actors))
            {
                result.AddRange(Mlist.findActors(actors));
            }
            if (!string.IsNullOrEmpty(country))
            {
                result.AddRange(Mlist.findCountry(country));
            }
            if (!string.IsNullOrEmpty(genre))
            {
                result.AddRange(Mlist.findGenres(genre));
            }
            result = result.Distinct().ToList();
            ShowListOf_Movies(dgvMovies, result);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Mlist.LoadFile();
            ShowListOf_Movies(dgvMovies, Mlist.getListOfMovies());
            ClearInput();
        }
        /* ------------------------------------------- Phòng Chiếu ------------------------------------------- */
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string roomCode = txbRoomCode.Text.Trim();
            string roomName = txbRoomName.Text.Trim();
            string roomType = cboRoomType.Text.Trim();
            string status;
            if (rdbOpen.Checked)
            {
                status = "Mở";
            }
            else status = "Đóng";

            if (string.IsNullOrWhiteSpace(roomCode) || string.IsNullOrWhiteSpace(roomName))
            {
                MessageBox.Show("Mã phòng và tên phòng không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cRoom r = new cRoom(roomCode, roomName, roomType, status);
            Rlist.Add(r);
            ShowListOf_Rooms(dgvRoom, Rlist.getListOfRooms());
            ClearRoomInput();
        }
        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count > 0 ) 
            {
                string roomCode = txbRoomCode.Text;
                Rlist.Remove(roomCode);
                ShowListOf_Rooms(dgvRoom, Rlist.getListOfRooms());
                dgvRoom.Refresh(); 
                ClearRoomInput();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phòng chiếu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnModifyRoom_Click(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count > 0)
            {
                string id = txbRoomCode.Text.Trim();
                string roomName = txbRoomName.Text.Trim();
                string roomType = cboRoomType.Text.Trim();
                string status = rdbOpen.Checked ? "Mở" : "Đóng";

                if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(roomName))
                {
                    MessageBox.Show("Mã phòng và tên phòng không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cRoom r = new cRoom(id, roomName, roomType, status);
                Rlist.Modify(r);
                ShowListOf_Rooms(dgvRoom, Rlist.getListOfRooms());
                ClearRoomInput();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phòng chiếu để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnRefreshRoom_Click(object sender, EventArgs e)
        {
            ShowListOf_Rooms(dgvRoom, Rlist.getListOfRooms());
            ClearRoomInput();
        }
        private void btnFindRoom_Click(object sender, EventArgs e)
        {
            string id = txbFindRoomID.Text.Trim();
            string name = txbFindRoomName.Text.Trim();
            string type = txbFindRoomType.Text.Trim();
            List<cRoom> result = new List<cRoom>();

            if (!string.IsNullOrEmpty(id))
            {
                result.AddRange(Rlist.FindID(id));
            }
            if (!string.IsNullOrEmpty(name))
            {
                result.AddRange(Rlist.FindRoomName(name));
            }
            if (!string.IsNullOrEmpty(type)) 
            {
                result.AddRange(Rlist.FindRoomType(type));
            }
            result = result.Distinct().ToList();

            ShowListOf_Rooms(dgvRoom, result);
        }

        /* ------------------------------------------- Nhân viên ------------------------------------------- */

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            string id = txbID.Text.Trim();
            string fullName = txbFullName.Text.Trim();
            DateTime birthday = dtpBirthday.Value;
            string gender = rdbMale.Checked ? "Nam" : "Nữ";
            string email = txbEmail.Text.Trim();
            string phoneNumber = txbPhoneNumber.Text.Trim();
            string password = txbGivePasswrd.Text;
            string role = rdbAdmin.Checked ? "Admin" : "Nhân Viên";


            if (!CheckInputStaff(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cStaff s = new cStaff(id, fullName, birthday, gender, email, phoneNumber, role, password);

            SList.Add(s);
            ShowListOf_Staffs(dgvStaff, SList.getListOfStaffs());
            ClearStaffInput();
        }



        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                string id = txbID.Text;
                cStaff s = SList.getStaff(id);

                if (s != null)
                {
                    SList.Delete(id);
                    ShowListOf_Staffs(dgvStaff, SList.getListOfStaffs());
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnModifyStaff_Click(object sender, EventArgs e)
        {
            string id = txbID.Text.Trim();
            string email = txbEmail.Text.Trim();
            string password = txbGivePasswrd.Text;
            DateTime birthday = dtpBirthday.Value;
            string fullName = txbFullName.Text.Trim();
            string phoneNumber = txbPhoneNumber.Text.Trim();
            string gender = rdbMale.Checked ? "Nam" : "Nữ";
            string role = rdbAdmin.Checked ? "Admin" : "Nhân Viên";

            cStaff s = new cStaff(id, fullName, birthday, gender, email, phoneNumber, role, password);

            SList.Modify(s);
            MessageBox.Show("Đã sửa thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowListOf_Staffs(dgvStaff, SList.getListOfStaffs());
        }
        private void btnRefreshStaff_Click(object sender, EventArgs e)
        {
            ShowListOf_Staffs(dgvStaff, SList.getListOfStaffs());
            ClearStaffInput();
        }
        private void btnFindStaff_Click(object sender, EventArgs e)
        {
            string id = txbFind_ID.Text.Trim();
            string name = txbFindFullName.Text.Trim();
            string gender = cboGender.SelectedItem?.ToString() ?? string.Empty;

            List<cStaff> result = new List<cStaff>();
            if (!string.IsNullOrEmpty(id))
            {
                result.AddRange(SList.FindID(id));
            }
            if (!string.IsNullOrEmpty(name))
            {
                result.AddRange(SList.FindName(name));
            }
            if (!string.IsNullOrEmpty(gender))
            {
                result.AddRange(SList.FindGender(gender));
            }
            result = result.Distinct().ToList();
            ShowListOf_Staffs(dgvStaff, result);
        }

        #endregion
        #region Method

        /* ------------------------------------------- Phim ------------------------------------------- */
        private string getSelectedGenres()
        {
            List<string> gList = new List<string>();

            if (ckbAction.Checked) gList.Add("Hành động");
            if (ckbAdventure.Checked) gList.Add("Phiêu lưu");
            if (ckbCartoon.Checked) gList.Add("Hoạt hình");
            if (ckbComedy.Checked) gList.Add("Hài hươc");
            if (ckbCrime.Checked) gList.Add("Tội phạm");
            if (ckbDrama.Checked) gList.Add("Chính kịch");
            if (ckbDetective.Checked) gList.Add("Trinh thám");
            if (ckbFamily.Checked) gList.Add("Gia đình");
            if (ckbFantasy.Checked) gList.Add("Thần thoại");
            if (ckbHistorical.Checked) gList.Add("Cổ trang");
            if (ckbHorror.Checked) gList.Add("Kinh dị");
            if (ckbMusical.Checked) gList.Add("Âm nhạc");
            if (ckbRomance.Checked) gList.Add("Tình cảm");
            if (ckbScience_Fiction.Checked) gList.Add("Khoa học viễn tưởng");
            if (ckbWar.Checked) gList.Add("Chiến tranh");

            return string.Join(", ", gList);

        }
        private void ComboBox_Genre()
        {
            cboFind_Genres.Items.Add("Hành động");
            cboFind_Genres.Items.Add("Phiêu lưu");
            cboFind_Genres.Items.Add("Hoạt hình");
            cboFind_Genres.Items.Add("Hài hước");
            cboFind_Genres.Items.Add("Tội phạm");
            cboFind_Genres.Items.Add("Chính kịch");
            cboFind_Genres.Items.Add("Trinh thám");
            cboFind_Genres.Items.Add("Gia đình");
            cboFind_Genres.Items.Add("Thần thoại");
            cboFind_Genres.Items.Add("Cổ trang");
            cboFind_Genres.Items.Add("Kinh dị");
            cboFind_Genres.Items.Add("Âm nhạc");
            cboFind_Genres.Items.Add("Chiến tranh");
            cboFind_Genres.Items.Add("Khoa học viễn tưởng");
            cboFind_Genres.Items.Add("Tình cảm");
        }
        private void ClearInput()
        {
            txbMovieCode.Clear();
            txbMovieName.Clear();
            txbDirector.Clear();
            txbActor.Clear();
            txbDuration.Clear();
            txbCountry.Clear();
            cboFind_Genres.SelectedIndex = -1;
            txbFind_MovieCode.Clear();
            txbFind_MovieName.Clear();
            txbFind_Director.Clear();
            txbFind_Actors.Clear();
            txbFind_Country.Clear();
            cboFind_Genres.ResetText();
        }
        private void ShowListOf_Movies(DataGridView dgvMovies, List<cMovie> ml)
        {
            dgvMovies.DataSource = ml.ToList();
        }

        /* ------------------------------------------- Phòng Chiếu ------------------------------------------- */
        private void ShowListOf_Rooms(DataGridView dgv, List<cRoom> rl)
        {
            dgv.DataSource = rl.ToList();

        }
        private void ComboBox_RoomType()
        {
            cboRoomType.Items.Add("Rạp Thường");
            cboRoomType.Items.Add("Rạp 3D");
            cboRoomType.Items.Add("Rạp 4D/4DX");
            cboRoomType.Items.Add("Rạp IMAX");
            cboRoomType.Items.Add("Rạp VIP");
        }
        private void ClearRoomInput()
        {
            txbRoomCode.Clear();
            txbRoomName.Clear();
            txbFindRoomID.Clear();
            txbFindRoomType.Clear();
            txbFindRoomName.Clear();
            cboRoomType.SelectedIndex = -1;
            rdbOpen.Checked = false;
            rdbClose.Checked = false;
        }
        /* ------------------------------------------- Nhân Viên ------------------------------------------- */
        private void ShowListOf_Staffs(DataGridView dgv, List<cStaff> sl)
        {
            dgv.DataSource = sl.ToList();

        }
        private void ClearStaffInput()
        {
            txbID.Clear();
            txbFullName.Clear();
            dtpBirthday.Value = DateTime.Now;
            txbEmail.Clear();
            txbPhoneNumber.Clear();
            txbFind_ID.Clear();
            txbFindFullName.Clear();
            cboGender.SelectedIndex = -1;
            txbGivePasswrd.Clear();
        }
        private bool CheckInputStaff(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(txbID.Text))
            {
                errorMessage = "Mã nhân viên không được để trống.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbFullName.Text))
            {
                errorMessage = "Tên nhân viên không được để trống.";
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txbPhoneNumber.Text) && !txbPhoneNumber.Text.All(char.IsDigit))
            {
                errorMessage = "Số điện thoại không hợp lệ.";
                return false;
            }
            return true;
        }
        #endregion

      
    }
}
