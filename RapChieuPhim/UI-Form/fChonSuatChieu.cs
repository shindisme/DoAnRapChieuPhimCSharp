using RapChieuPhim.Class;
using RapChieuPhim.Manage_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RapChieuPhim.UI_Form
{
    public partial class fChonSuatChieu : Form
    {
        private cShowtimeList STList = new cShowtimeList();
        public fChonSuatChieu()
        {
            InitializeComponent();
            
        }

        private void fSelectSuatChieu_Load(object sender, EventArgs e)
        {
            STList.LoadFile();
            ShowListOfShowtime(dgvShowtime, STList.GetListOFShowtime());

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbMovie.Text) || string.IsNullOrWhiteSpace(txbRoom.Text))
            {
                MessageBox.Show("Vui lòng chọn thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (dgvShowtime.CurrentRow != null)
                {
                    int selectedRowIndex = dgvShowtime.CurrentRow.Index;
                    cShowtime selectedShowtime = STList.GetListOFShowtime()[selectedRowIndex];

                    fDatGhe sellTicketForm = new fDatGhe();
                    sellTicketForm.SetSelectedShowtime(selectedShowtime);
                    this.Hide();
                    sellTicketForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một suất chiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string movieName = txbMovie.Text.Trim();
            string roomName = txbRoom.Text.Trim();
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date; 
            TimeSpan time = dtpTime.Value.TimeOfDay;

            List<cShowtime> result = new List<cShowtime>();

            if (!string.IsNullOrEmpty(movieName))
            {
                result.AddRange(STList.FindMovieName(movieName));
            }
            if (!string.IsNullOrEmpty(roomName))
            {
                result.AddRange(STList.FindRoomName(roomName));
            }
            if (from != DateTime.MinValue && to > from)
            {
                result.AddRange(STList.FindDateToDate(from, to));
            }
            if (time != TimeSpan.Zero)
            {
                result.AddRange(STList.FindTime(time));
            }
            result = result.Distinct().ToList();
            ShowListOfShowtime(dgvShowtime, result);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txbMovie.Clear();
            txbRoom.Clear();
            ShowListOfShowtime(dgvShowtime, STList.GetListOFShowtime());
        }

        private void dgvShowtime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cShowtime st = STList.GetListOFShowtime()[e.RowIndex];
                txbMovie.Text = st.MovieName;
                txbRoom.Text = st.RoomName;
                dtpTime.Value = DateTime.Today.Add(st.Time); 
            }
        }
       
        private void ShowListOfShowtime(DataGridView dgv, List<cShowtime> list)
        {
            List<cShowtime> rsList = new List<cShowtime>();
            foreach (cShowtime st in list)
            {
                if (st.Status == "Đang chiếu")
                {
                    rsList.Add(st);
                }
            }
            dgv.DataSource = rsList.ToList();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
