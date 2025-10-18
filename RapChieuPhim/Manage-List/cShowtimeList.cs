using RapChieuPhim.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace RapChieuPhim.Manage_List
{
    internal class cShowtimeList
    {
        private List<cShowtime> _listST;
        private string _filePath;

        public cShowtimeList()
        {
            this._listST = new List<cShowtime>();
            this._filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\showtime.txt");
        }

        public List<cShowtime> GetListOFShowtime()
        {
            return this._listST;
        }

        public cShowtime getShowtime(string code)
        {
            foreach (cShowtime st in this._listST)
            {
                if (st.StID.Equals(code, StringComparison.OrdinalIgnoreCase))
                {
                    return st;
                }
            }
            return null;
        }

        public void Add(cShowtime st)
        {
            if (getShowtime(st.StID) == null)
            {
                this._listST.Add(st);
                MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveFile();
            }
            else
            {
                MessageBox.Show("Mã suất chiếu đã tồn tại, vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Modify(cShowtime st)
        {
            cShowtime result = getShowtime(st.StID);
            if (result != null)
            {
                result.Date = st.Date;
                result.Movie = st.Movie;
                result.Room = st.Room;
                result.Date = st.Date;
                result.Time = st.Time;
                result.Status = st.Status;

                MessageBox.Show("Đã cập nhật thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveFile();
            }
            else
            {
                MessageBox.Show("Không tìm thấy suất chiếu để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Delete(string code)
        {
            cShowtime result = getShowtime(code);
            if (result != null)
            {
                this._listST.Remove(result);
                MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveFile();
            }
            else
            {
                MessageBox.Show("Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //==================================  Tìm  ==================================
        public List<cShowtime> FindShowtimeID(string id)
        {
            List<cShowtime> listRS = new List<cShowtime>();
            foreach (cShowtime st in this._listST)
            {
                if(st.StID.IndexOf(id, StringComparison.OrdinalIgnoreCase) >= 0)
                    listRS.Add(st);
            }
            return listRS;
        }
        public List<cShowtime> FindMovieName(string mvName)
        {
            List<cShowtime> listRS = new List<cShowtime>();
            foreach (cShowtime st in this._listST)
            {
                if(st.StID.IndexOf(mvName, StringComparison.OrdinalIgnoreCase) >= 0)
                    listRS.Add(st);
            }
            return listRS;
        }
        public List<cShowtime> FindRoomName(string rName)
        {
            List<cShowtime> listRS = new List<cShowtime>();
            foreach (cShowtime st in this._listST)
            {
                if(st.StID.IndexOf(rName, StringComparison.OrdinalIgnoreCase) >= 0)
                    listRS.Add(st);
            }
            return listRS;
        }
        public List<cShowtime> FindDateToDate(DateTime dateFrom, DateTime dateTo)
        {
            List<cShowtime> listRS = new List<cShowtime>();
            foreach (cShowtime st in this._listST)
            {
                if (st.Date.Date >= dateFrom.Date && st.Date.Date <= dateTo.Date)
                {
                    listRS.Add(st);
                }
            }
            return listRS;
        }
        public List<cShowtime> FindTime(TimeSpan time)
        {
            List<cShowtime> listRS = new List<cShowtime>();
            foreach (cShowtime st in this._listST)
            {
                if (st.Time == time)
                {
                    listRS.Add(st);
                }
            }
            return listRS;
        }
        public List<cShowtime> FindStatus(string status)
        {
            List<cShowtime> listRS = new List<cShowtime>();
            foreach (cShowtime r in this._listST)
            {
                if (r.Status.IndexOf(status, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    listRS.Add(r);
                }
            }
            return listRS;
        }
        //==================================  Lưu  ==================================
        public void SaveFile()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this._filePath))
                {
                    foreach (cShowtime st in this._listST)
                    {
                        sw.WriteLine(st.Data());
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadFile()
        {
            try
            {
                if (File.Exists(this._filePath))
                {

                    using (StreamReader sr = new StreamReader(this._filePath))
                    {
                        this._listST.Clear();
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] data = line.Split('|');
                            if (data.Length >= 6)
                            {
                                string showtimeID = data[0].Trim();
                                string movieName = data[1].Trim();
                                string roomName = data[2].Trim();
                                DateTime date = DateTime.ParseExact(data[3].Trim(), "dd/MM/yyyy", null);
                                TimeSpan time = TimeSpan.ParseExact(data[4].Trim(), "hh\\:mm", null);
                                cMovie mv = new cMovie { MovieName = movieName };
                                cRoom r = new cRoom { RoomName = roomName };     
                                string status = data[5].Trim();

                                cShowtime st = new cShowtime(showtimeID, date, time, mv, r,status);
                                this._listST.Add(st); 
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
