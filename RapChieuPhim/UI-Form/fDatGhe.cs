using RapChieuPhim.Class;
using RapChieuPhim.Manage_List;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RapChieuPhim.UI_Form
{
    public partial class fDatGhe : Form
    {
        private cSeatList seatList;
        private cTicketList tList;
        private cShowtime showtime;

        public fDatGhe()
        {
            InitializeComponent();
        }

        private void fSellTicket_Load(object sender, EventArgs e)
        {
            createSeats(9, 12);
            LoadSelectedSeats();
            ShowListOfTicket(dgvTicket, tList.getListOfTicket());
        }

        private void createSeats(int rows, int cols)
        {
            int btnSize = 50;
            int spacing = 10;
            int extraSpacing = 15;
            int x = 70, y = 130;
            char letter = 'A';

            for (int i = 0; i < rows; i++)
            {
                x = 70;
                for (int j = 0; j < cols; j++)
                {
                    Button btn = new Button
                    {
                        Size = new Size(btnSize, btnSize),
                        Location = new Point(x, y),
                        Text = $"{letter}{j + 1}",
                        BackColor = Color.White,
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    btn.Click += BtnSeat_Click;
                    pnlSeats.Controls.Add(btn);

                    cSeat seat = new cSeat(btn.Text);
                    seatList.AddSeat(seat);

                    if (j > 0 && j % 8 == 0)
                    {
                        x += extraSpacing;
                    }

                    x += btnSize + spacing;
                }
                letter++;
                y += btnSize + spacing;
            }
        }

        private void LoadSelectedSeats()
        {
            seatList.LoadFile(showtime.StID);
            foreach (Control control in pnlSeats.Controls)
            {
                if (control is Button btnSeat)
                {
                    cSeat seat = seatList.getSeats(btnSeat.Text);
                    if (seat != null)
                    {
                        btnSeat.BackColor = seat.Status ? Color.Yellow : Color.White;
                    }
                }
            }

            foreach (DataGridViewRow row in dgvTicket.Rows)
            {
                string[] seats = row.Cells["Ghế"].Value.ToString().Split(new[] { ", " }, StringSplitOptions.None);
                foreach (string seatID in seats)
                {
                    Button btnSeat = pnlSeats.Controls.OfType<Button>().FirstOrDefault(b => b.Text == seatID);
                    if (btnSeat != null)
                    {
                        btnSeat.BackColor = Color.Yellow;
                    }
                }
            }
        }

        private void BtnSeat_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            cSeat seat = seatList.getSeats(btn.Text);

            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.LightGreen;
            }
            else if (btn.BackColor == Color.LightGreen)
            {
                btn.BackColor = Color.White;
            }
            else if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show($"Ghế: {btn.Text} đã được mua.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            bool isSeatSelected = false;
            List<string> selectedSeats = new List<string>();

            foreach (Control control in pnlSeats.Controls)
            {
                if (control is Button btnSeat && btnSeat.BackColor == Color.LightGreen)
                {
                    isSeatSelected = true;
                    selectedSeats.Add(btnSeat.Text);
                }
            }
            if (!isSeatSelected)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            fCustomer f = new fCustomer();
            if (f.ShowDialog() == DialogResult.OK)
            {

                if (tList.getTicket(f.txbTicketID.Text) != null)
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cTicket t = new cTicket(f.txbTicketID.Text,f.txbName.Text, f.txbPhone.Text, selectedSeats);
                tList.Add(t);

                foreach (string seatID in selectedSeats)
                {
                    cSeat seat = seatList.getSeats(seatID);
                    if (seat != null)
                    {
                        seat.Status = true;
                    }
                }

                seatList.SaveFile(showtime.StID);
                tList.SaveFile();

                foreach (Control control in pnlSeats.Controls)
                {
                    if (control is Button btnSeat && selectedSeats.Contains(btnSeat.Text))
                    {
                        btnSeat.BackColor = Color.Yellow;
                    }
                }

                ShowListOfTicket(dgvTicket, tList.getListOfTicket());
            }
        }

        private void ShowListOfTicket(DataGridView dgv, List<cTicket> ticket)
        {
            List<object> tìcketList = new List<object>();
            foreach (cTicket t in ticket)
            {
                tìcketList.Add(new
                {
                    Mã = t.TicketID,
                    Tên = t.Name,
                    SĐT = t.Phone, 
                    Ghế = string.Join(", ", t.Seats),
                    Giá = t.Price 
                });
            }
            dgv.DataSource = tìcketList;
        }

        internal void SetSelectedShowtime(cShowtime selectedShowtime)
        {
            showtime = selectedShowtime;
            seatList = new cSeatList();
            tList = new cTicketList();
            tList.ShowtimeID = showtime.StID;
            LoadSelectedSeats();
            tList.LoadFile();
            ShowListOfTicket(dgvTicket, tList.getListOfTicket());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTicket.CurrentRow != null && dgvTicket.CurrentRow.Index != -1)
            {
                var row = dgvTicket.CurrentRow;
                string customerSeats = row.Cells["Ghế"].Value.ToString();

                DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (confirmResult == DialogResult.No)
                {
                    return;
                }

                cTicket result = null;
                foreach (cTicket t in tList.getListOfTicket())
                {
                    if (string.Join(", ", t.Seats) == customerSeats)
                    {
                        result = t;
                        break;
                    }
                }

                if (result != null)
                {
                    foreach (var seatID in result.Seats)
                    {
                        cSeat seat = seatList.getSeats(seatID);
                        if (seat != null)
                        {
                            seat.Status = false;
                            Button btnSeat = pnlSeats.Controls.OfType<Button>().FirstOrDefault(b => b.Text == seatID);
                            if (btnSeat != null)
                            {
                                btnSeat.BackColor = Color.White;
                            }
                        }
                    }
                    tList.RemoveBySeats(customerSeats, seatList);
                    seatList.SaveFile(showtime.StID);
                    ShowListOfTicket(dgvTicket, tList.getListOfTicket());
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            seatList.SaveFile(showtime.StID);
            tList.SaveFile();
            this.Close();
        }
    }
}
