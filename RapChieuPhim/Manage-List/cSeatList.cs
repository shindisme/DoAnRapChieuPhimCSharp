using RapChieuPhim.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RapChieuPhim.Manage_List
{
    internal class cSeatList
    {
        private List<cSeat> _list;

        public cSeatList()
        {
            this._list = new List<cSeat>();
        }
        public cSeat getSeats(string id)
        {
            foreach (var seat in _list)
            {
                if (seat.SeatID.Equals(id, StringComparison.OrdinalIgnoreCase))
                {
                    return seat;
                }
            }
            return null;
        }
        public List<cSeat> getListOfSeats()
        {
            return this._list;
        }

        public void AddSeat(cSeat seat)
        {
            this._list.Add(seat);
        }

        public void SaveFile(string showtimeID)
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "SeatList");
            string filePath = Path.Combine(directoryPath, $"Showtime_{showtimeID}.txt");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (cSeat seat in _list)
                {
                    sw.WriteLine($"{seat.SeatID}|{seat.Status}");
                }
            }
        }

        public void LoadFile(string showtimeID)
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "SeatList");
            string filePath = Path.Combine(directoryPath, $"Showtime_{showtimeID}.txt");
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 2)
                        {
                            string seatID = parts[0].Trim();
                            bool status = bool.Parse(parts[1].Trim());
                            cSeat seat = getSeats(seatID);
                            if (seat != null)
                            {
                                seat.Status = status;
                            }
                            else
                            {
                                cSeat newSeat = new cSeat(seatID)
                                {
                                    Status = status
                                };
                                AddSeat(newSeat);
                            }
                        }
                    }
                }
            }
        }
    }
}
