using RapChieuPhim.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RapChieuPhim.Manage_List
{
    internal class cTicketList
    {
        private List<cTicket> _list;
        private string _filePath;
        private string _showtimeID;

        public cTicketList()
        {
            this._list = new List<cTicket>();
        }

        public List<cTicket> getListOfTicket()
        {
            return this._list;
        }
        public cTicket getTicket(string id)
        {
            foreach (cTicket t in this._list)
            {
                if (t.TicketID.Equals(id))
                    return t;
            }
            return null;
        }
        public string ShowtimeID
        {
            get { return _showtimeID; }
            set
            {
                _showtimeID = value;
                _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "TicketList", $"Showtime_{_showtimeID}.txt");
            }
        }

        public void Add(cTicket t)
        {
            this._list.Add(t);
            SaveFile();
        }

        public void RemoveBySeats(string seats, cSeatList seatList)
        {
            var result = _list.FirstOrDefault(t =>
                string.Join(", ", t.Seats) == seats);

            if (result != null)
            {
                foreach (string seatID in result.Seats)
                {
                    cSeat seat = seatList.getSeats(seatID);
                    if (seat != null)
                    {
                        seat.Status = false;
                    }
                }

                _list.Remove(result);
                SaveFile();
                MessageBox.Show("Đã xóa khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể xóa khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public double TotalMoney() 
        { 
            double sum = 0; 
            foreach (cTicket t in this._list) 
            { 
                sum += t.Price; 
            }
            return sum; 
        }
        public void SaveFile()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "TicketList");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(_filePath))
                {
                    foreach (cTicket t in this._list)
                    {
                        sw.WriteLine(t.Data());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadFile()
        {
            if (File.Exists(this._filePath))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(this._filePath))
                    {
                        this._list.Clear();
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] data = line.Split('|');
                            if (data.Length == 5)
                            {
                                string id = data[0].Trim();
                                string name = data[1].Trim();
                                string phone = data[2].Trim();
                                List<string> seats = new List<string>(data[3].Trim().Split(','));

                                cTicket t = new cTicket(id, name, phone, seats);
                                this._list.Add(t);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
