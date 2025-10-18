using RapChieuPhim.Manage_List;
using System;
using System.Collections.Generic;

namespace RapChieuPhim.Class
{
    internal class cShowtime
    {
        private string _stID;
        private cMovie _movie;
        private cRoom _room;
        private DateTime _date;
        private TimeSpan _time;
        private string _status;
        private List<cTicket> _customer;
        public cShowtime()
        {
            this._stID = null;
            this._movie = new cMovie();
            this._room = new cRoom();
            this._date = DateTime.Now;
            this._time = TimeSpan.Zero;
            this._status = null;
        }
        public cShowtime(string stID, DateTime date, TimeSpan time, cMovie movie, cRoom room, string status)
        {
            this._stID = stID;
            this._date = date;
            this._time = time;
            this.Status = status;
            this._movie = movie;
            this._room = room;
            this._customer = new List<cTicket>();
        }

        public string StID
        {
            get { return _stID; }
            set { _stID = value; }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public TimeSpan Time
        {
            get { return _time; }
            set { _time = value; }
        }
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public cMovie Movie
        {
            get { return _movie; }
            set { _movie = value; }
        }
        public cRoom Room
        {
            get { return _room; }
            set { _room = value; }
        }
        public string MovieName
        {
            get { return Movie.MovieName; }
            set { Movie.MovieName = value; }
        }
        public string RoomName
        {
            get { return Room.RoomName; }
            set {  Room.RoomName = value; }
        }
        public List<cTicket> CustomerList 
        {
            get { return _customer; }
            set { _customer = value; }
        }
        public string Data()
        {
            return $"{StID}|{MovieName}|{RoomName}|{Date:dd/MM/yyyy}|{Time:hh\\:mm}|{Status}";
        }
    }
}