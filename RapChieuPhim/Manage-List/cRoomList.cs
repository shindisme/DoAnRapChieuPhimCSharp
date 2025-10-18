using RapChieuPhim.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapChieuPhim.Manage_List
{
    internal class cRoomList
    {
        private List<cRoom> _list;
        private string _filePath;
        public cRoomList()
        {
            this._list = new List<cRoom>();
            this._filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\rooms.txt");
        }

        public List<cRoom> getListOfRooms()
        {
            return this._list;
        }

        public cRoom getRoom(string id)
        {
            foreach (cRoom r in this._list)
            {
                if (r.RoomID.Equals(id))
                {
                    return r;
                }
            }
            return null;
        }

        public void Add(cRoom r)
        {
            if (getRoom(r.RoomID) == null)
            {
                this._list.Add(r);
                MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveFile();
            }
            else
            {
                MessageBox.Show("Mã phòng đã tồn tại, vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Remove(string roomid)
        {
            cRoom result = getRoom(roomid);
            if (result != null)
            {
                _list.Remove(result);
                MessageBox.Show("Đã xóa phòng chiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveFile();
            }
            else
            {
                MessageBox.Show("Không tìm thấy phòng chiếu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Modify(cRoom r)
        {
            cRoom result = getRoom(r.RoomID);
            if (result != null)
            {
                result.RoomID = r.RoomID;
                result.RoomName = r.RoomName;
                result.RoomType = r.RoomType;
                result.Status = r.Status;
                SaveFile();
                MessageBox.Show("Đã sửa thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //============================================= Tìm ==============================================
        public List<cRoom> FindID(string id)
        {
            List<cRoom> listRS = new List<cRoom>();
            foreach (cRoom m in this._list)
            {
                if (m.RoomID.IndexOf(id, StringComparison.OrdinalIgnoreCase) >= 0)
                    listRS.Add(m);
            }
            return listRS;
        }

        public List<cRoom> FindRoomName(string name)
        {
            List<cRoom> listRS = new List<cRoom>();
            foreach (cRoom m in this._list)
            {
                if (m.RoomName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                    listRS.Add(m);
            }
            return listRS;
        }

        public List<cRoom> FindRoomType(string type)
        {
            List<cRoom> listRS = new List<cRoom>();
            foreach (cRoom m in this._list)
            {
                if (m.RoomType.IndexOf(type, StringComparison.OrdinalIgnoreCase) >= 0)
                    listRS.Add(m);
            }
            return listRS;
        }

        public List<cRoom> FindStatus(string status)
        {
            List<cRoom> listRS = new List<cRoom>();
            foreach (cRoom r in this._list)
            {
                if (r.Status.IndexOf(status, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    listRS.Add(r);
                }
            }
            return listRS;
        }

        //============================================= Lưu ==============================================
        public void SaveFile()
        {
            using (StreamWriter writer = new StreamWriter(this._filePath))
            {
                foreach (cRoom room in this._list)
                {
                    writer.WriteLine(room.Data());
                }
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
                        string line;
                        this._list.Clear();
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] data = line.Split('|');
                            if (data.Length == 4)
                            {
                                string roomCode = data[0].Trim();
                                string roomName = data[1].Trim();
                                string roomType = data[2].Trim();
                                string status = data[3].Trim().TrimEnd('.');

                                cRoom r = new cRoom(roomCode, roomName, roomType, status);
                                this._list.Add(r);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
