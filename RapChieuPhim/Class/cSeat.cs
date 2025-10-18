using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace RapChieuPhim.Class
{
    internal class cSeat
    {
        private string _seatID;
        private bool _status;
        public cSeat(string seatID)
        {
            this._seatID = seatID;
            this._status = false;
        }
        public string SeatID 
        {
            get { return this._seatID; }
            set { this._seatID = value; }
        }
        public bool Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
    }
}