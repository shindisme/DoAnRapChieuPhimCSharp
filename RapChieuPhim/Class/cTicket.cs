using System.Collections.Generic;

namespace RapChieuPhim.Class
{
    internal class cTicket
    {
        private string _ticketID;
        private string _nameCus;
        private string _phone;
        public List<string> _seats;

        public cTicket(string ticketID, string name, string phone, List<string> seats)
        {
            this._ticketID = ticketID;
            this._nameCus = name;
            this._phone = phone;
            this._seats = seats;
        }
        public string TicketID
        {
            get { return this._ticketID; }
            set { this._ticketID = value; }
        }
        public string Name
        {
            get { return this._nameCus; }
            set { this._nameCus = value; }
        }
        public string Phone
        {
            get { return this._phone; }
            set { this._phone = value; }
        }
        public List<string> Seats
        {
            get { return this._seats; }
            set { this._seats = value; }
        }
        public double Price
        {
            get { return Seats.Count * 90000; }
        }

        public string Data()
        {
            return $"{TicketID}|{Name}|{Phone}|{string.Join(",", Seats)}|{Price}";
        }
    }
}
