using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim.Class
{
    internal class cMovie
    {
        private string _movieID;
        private string _movieName;
        private string _director;
        private string _country;
        private string _actors;
        private string _genres;
        private int _duration;


        public cMovie()
        {
            this._movieID = null;
            this._movieName = null;
            this._director = null;
            this._country = null;
            this._actors = null;
            this._genres = null;
            this._duration = 0;
        }
        public cMovie(string movieID, string movieName, string director, string actors, string genres, int duration, string country)
        {
            this._movieID = movieID;
            this._movieName = movieName;
            this._director = director;
            this._actors = actors;
            this._genres = genres;
            this._duration = duration;
            this._country = country;
        }

        public string MovieID
        {
            get { return this._movieID; }
            set { this._movieID = value; }
        }
        public string MovieName
        {
            get { return this._movieName; }
            set { this._movieName = value; }
        }
        public string Director
        {
            get { return this._director; }
            set { this._director = value; }
        }
        public int Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }
        public string Actors
        {
            get { return this._actors; }
            set { this._actors = value; }
        }
        public string Genres
        {
            get { return this._genres; }
            set { this._genres = value; }
        }
        public string Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        public string Data()
        {
            return $"{MovieID}|{MovieName}|{Director}|{Actors}|{Genres}|{Duration} phút|{Country}.";
        }
    }
}
