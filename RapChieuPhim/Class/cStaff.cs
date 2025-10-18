using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim.Class
{
    internal class cStaff
    {
        private string _id;
        private string _fullName;
        private DateTime _birthday;
        private string _gender;
        private string _email;
        private string _phoneNumber;
        private string _password;
        private string _role;
        public cStaff()
        {
            this._id = null;
            this._fullName = null;
            this._birthday = DateTime.Now;
            this._gender = null;
            this._email = null;
            this._phoneNumber = null;
            this._password = null;
            this._role = null;
        }
        public cStaff(string id, string fullName, DateTime birthday, string gender, string email, string phoneNumber, string role, string password)
        {
            this._id = id;
            this._fullName = fullName;
            this._birthday = birthday;
            this._gender = gender;
            this._email = email;
            this._password = password;
            this._phoneNumber = phoneNumber;
            this._role = role;
        }
        public string ID
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public string FullName
        {
            get { return this._fullName; }
            set { this._fullName = value; }
        }
        public DateTime Birthday
        {
            get { return this._birthday; }
            set { this._birthday = value; }
        }
        public string Gender
        {
            get { return this._gender; }
            set { this._gender = value; }
        }
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }
        public string PhoneNumber
        {
            get { return this._phoneNumber; }
            set { this._phoneNumber = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Role
        {
            get { return _role; }
            set { _role = value; }
        }
        public string Data()
        {
            return $"{ID} | {FullName} | {Birthday:dd/MM/yyyy} | {Gender} | {Email} | {PhoneNumber} | {Role} | {Password}.";
        }
    }
}
