using RapChieuPhim.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapChieuPhim.Manage_List
{
    internal class cStaffList
    {
        private List<cStaff> _list;
        private string _filePath;

        public cStaffList()
        {
            this._list = new List<cStaff>();
            this._filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\staffs.txt");
        }

        public List<cStaff> getListOfStaffs()
        {
            return this._list;
        }
        public cStaff getStaff(string id)
        {
            foreach (cStaff s in this._list)
            {
                if (s.ID.Equals(id))
                    return s;
            }
            return null;
        }
        public void Add(cStaff s)
        {
            if (s == null)
            {
                MessageBox.Show("Nhân viên không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (getStaff(s.ID) == null)
            {
                this._list.Add(s);
                MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveFile();
            }
            else
            {
                MessageBox.Show("Mã đã tồn tại, vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Modify(cStaff s)
        {
            cStaff result = getStaff(s.ID);
            if (result != null)
            {
                result.FullName = s.FullName;
                result.Birthday = s.Birthday;
                result.Gender = s.Gender;
                result.Email = s.Email;
                result.PhoneNumber = s.PhoneNumber;
                result.Password = s.Password;
                result.Role = s.Role;

                SaveFile();
            }

        }

        public void Delete(string id)
        {
            cStaff result = getStaff(id);
            if (result != null)
            {
                this._list.Remove(result);
                MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveFile();
            }
            else
            {
                MessageBox.Show("Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public bool Login(string userName, string password)
        {
            foreach (cStaff s in this._list)
            {
                if (s.ID == userName && s.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        // ================================ Tìm ================================
        public List<cStaff> FindID(string id)
        {
            List<cStaff> listRS = new List<cStaff>();
            foreach (cStaff st in this._list)
            {
                if (st.ID.IndexOf(id, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    listRS.Add(st);
                }
            }
            return listRS;
        }
        public List<cStaff> FindName(string name)
        {
            List<cStaff> listRS = new List<cStaff>();
            foreach (cStaff st in this._list)
            {
                if (st.FullName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    listRS.Add(st);
                }
            }
            return listRS;
        }
        public List<cStaff> FindGender(string gender)
        {
            List<cStaff> listRS = new List<cStaff>();
            foreach (cStaff st in this._list)
            {
                if (st.Gender.IndexOf(gender, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    listRS.Add(st);
                }
            }
            return listRS;
        }

        //================================ Lưu ================================
        public void SaveFile()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this._filePath))
                {
                    foreach (cStaff staff in this._list)
                    {
                        sw.WriteLine(staff.Data());
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
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] data = line.Split('|');
                            if (data.Length == 8)
                            {
                                string id = data[0].Trim();
                                string name = data[1].Trim();
                                DateTime birthday = DateTime.Parse(data[2].Trim());
                                string gender = data[3].Trim();
                                string email = data[4].Trim();
                                string phone = data[5].Trim();
                                string role = data[6].Trim();
                                string password = data[7].Trim().TrimEnd('.');

                                cStaff s = new cStaff(id, name, birthday, gender, email, phone, role, password);
                                _list.Add(s);
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
