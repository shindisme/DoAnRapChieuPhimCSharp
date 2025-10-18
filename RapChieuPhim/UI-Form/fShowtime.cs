using RapChieuPhim.Class;
using RapChieuPhim.Manage_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RapChieuPhim.UI_Form
{
    public partial class fShowtime : Form
    {
        private cShowtimeList STList = new cShowtimeList();
        private cMovieList Mlist = new cMovieList();
        private cRoomList RList = new cRoomList(); 
        public fShowtime()
        {
            InitializeComponent();
        }

        private void fShowtime_Load(object sender, EventArgs e)
        {
            STList.LoadFile();
            Mlist.LoadFile();
            RList.LoadFile();
            ComboBox_Movies(cboMovieName, Mlist.getListOfMovies());
            ComboBox_Rooms(cboRoomName, RList.getListOfRooms());
            ShowList_Showtime(dgvShowtime, STList.GetListOFShowtime());
            cboStatus.Items.Add("Chưa chiếu");
            cboStatus.Items.Add("Đang chiếu");
            cboStatus.Items.Add("Đã chiếu");


        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                cShowtime idExits = STList.getShowtime(txbShowtimeId.Text);
                if (idExits != null)  
                {
                    MessageBox.Show("Mã suất chiếu đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbShowtimeId.Clear();  
                    txbShowtimeId.Focus();
                }
                else
                {
                    cMovie mv = new cMovie();
                    mv.MovieName = cboMovieName.Text;
                    mv.MovieID = cboMovieName.SelectedValue.ToString();
                    cRoom r = new cRoom();
                    r.RoomName = cboRoomName.Text;
                    r.RoomID = cboRoomName.SelectedValue.ToString();

                    string stID = txbShowtimeId.Text.Trim();
                    DateTime date = dtpDate.Value.Date;
                    TimeSpan time = dtpTime.Value.TimeOfDay;
                    string status;
                    if (rdbNotShown.Checked)
                    {
                        status = "Chưa chiếu";
                    }
                    else if (rdbShown.Checked)
                    {
                        status = "Đã chiếu";
                    }
                    else
                    {
                        status = "Đang chiếu";
                    }
                    cShowtime st = new cShowtime(stID, date, time, mv, r, status);
                    STList.Add(st);
                    ShowList_Showtime(dgvShowtime, STList.GetListOFShowtime());
                    ClearInput();
                }
                
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvShowtime.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa suất chiếu này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string id = txbShowtimeId.Text;
                    STList.Delete(id);
                    ShowList_Showtime(dgvShowtime, STList.GetListOFShowtime());
                    ClearInput();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn suất chiếu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgvShowtime.SelectedRows.Count > 0)
            {
                if (CheckInput())
                {
                    cMovie mv = new cMovie();
                    mv.MovieName = cboMovieName.Text;
                    mv.MovieID = cboMovieName.SelectedValue.ToString();
                    cRoom r = new cRoom();
                    r.RoomName = cboRoomName.Text;
                    r.RoomID = cboRoomName.SelectedValue.ToString();

                    string stID = txbShowtimeId.Text.Trim();
                    DateTime date = dtpDate.Value.Date;
                    TimeSpan time = dtpTime.Value.TimeOfDay;
                    string status;
                    if (rdbNotShown.Checked)
                    {
                        status = "Chưa chiếu"; 
                    }
                    else if (rdbShown.Checked)
                    {
                        status = "Đã chiếu"; 
                    }
                    else
                    {
                        status = "Đang chiếu"; 
                    }

                    cShowtime st = new cShowtime(stID, date, time, mv, r, status);
                    STList.Modify(st);
                    ShowList_Showtime(dgvShowtime, STList.GetListOFShowtime());
                    ClearInput();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn suất chiếu để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            STList.LoadFile();
            ClearInput();
            ShowList_Showtime(dgvShowtime, STList.GetListOFShowtime());
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            string showtimeID = txbFindID.Text.Trim();
            string movieName = txbFindMovieName.Text.Trim();
            string roomName = txbFindRoomName.Text.Trim();
            DateTime dateFrom = dtpFrom.Value.Date;
            DateTime dateTo = dtpTo.Value.Date;
            string status = cboStatus.SelectedItem?.ToString() ?? string.Empty;
            List<cShowtime> result = new List<cShowtime>();

            if (!string.IsNullOrEmpty(movieName))
            {
                result.AddRange(STList.FindMovieName(movieName));
            }
            if (!string.IsNullOrEmpty(roomName))
            {
                result.AddRange(STList.FindRoomName(roomName));
            }
            if (dateFrom != DateTime.MinValue && dateTo > dateFrom)
            {
                result.AddRange(STList.FindDateToDate(dateFrom, dateTo));
            }
            if(!string.IsNullOrEmpty(status))
                result.AddRange(STList.FindStatus(status));
            result = result.Distinct().ToList();
            ShowList_Showtime(dgvShowtime, result);
        }
        private void ClearInput()
        {
            txbShowtimeId.Clear();
            cboMovieName.SelectedIndex = -1;
            cboRoomName.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
            cboStatus.SelectedIndex = -1;
        }
        private void ComboBox_Movies(ComboBox cbo, List<cMovie> list)
        {
            cbo.Items.Clear();
            cbo.DisplayMember = "MovieName";
            cbo.ValueMember = "MovieID";
            cbo.DataSource = list.ToList();
            
        }
        private void ComboBox_Rooms(ComboBox cbo, List<cRoom> list)
        {
            cbo.DisplayMember = "RoomName";
            cbo.ValueMember = "RoomID";
            cbo.DataSource = list.ToList();
            List<cRoom> rsList = new List<cRoom>();
            foreach (cRoom room in RList.getListOfRooms())
            {
                if (!string.IsNullOrEmpty(room.Status) && room.Status.Trim().Equals("Mở", StringComparison.OrdinalIgnoreCase))
                {
                    rsList.Add(room);
                }
            }
            cboRoomName.DataSource = rsList.ToList();
        }
        private void ShowList_Showtime(DataGridView dgv, List<cShowtime> list)
        {
            dgv.DataSource = list.ToList();
        }

        private void dgvShowtime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvShowtime.Rows.Count)
            {
                cShowtime st = STList.GetListOFShowtime()[e.RowIndex];
                txbShowtimeId.Text = st.StID;
                cboMovieName.Text = st.MovieName;
                cboRoomName.Text = st.RoomName;
                dtpDate.Value = st.Date; 
                dtpTime.Value = DateTime.Today.Add(st.Time);
                if (st.Status =="Đang chiếu")
                {
                    rdbShowing.Checked = true;
                }
                else if (st.Status == "Đã chiếu")
                    rdbShown.Checked = true;
                else rdbNotShown.Checked = true;
            }
        }
        private bool CheckInput()
        {
            if (string.IsNullOrWhiteSpace(txbShowtimeId.Text))
            {
                MessageBox.Show("Mã suất chiếu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboMovieName.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phim!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboRoomName.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phòng chiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

     
    }
}