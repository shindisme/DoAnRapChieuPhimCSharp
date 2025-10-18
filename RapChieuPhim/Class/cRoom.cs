using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim.Class
{
    internal class cRoom
    {
        private string _roomID;
        private string _roomName;
        private string _roomType;
        private string _status;

        public cRoom()
        {
            this._roomID = null;
            this._roomName = null;
            this._roomType = null;
            this._status = null;
        }
        public cRoom(string roomID, string roomName, string roomType, string status)
        {
            this._roomID = roomID;
            this._roomName = roomName;
            this._roomType = roomType;
            this._status = status;
        }

        public string RoomID
        {
            get { return this._roomID; }
            set { this._roomID = value; }
        }
        public string RoomName
        {
            get { return this._roomName; }
            set { this._roomName = value; }
        }
        public string RoomType
        {
            get { return this._roomType; }
            set { this._roomType = value; }
        }
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        public string Data()
        {
            return $"{RoomID} | {RoomName} | {RoomType} | {Status}.";
        }
    }
}
