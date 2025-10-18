using RapChieuPhim.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapChieuPhim.Manage_List
{
    internal class cMovieList
    {
        private List<cMovie> _list;
        private string _filePath;

        public cMovieList()
        {
            this._list = new List<cMovie>();
            this._filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\movies.txt");
        }
        public List<cMovie> getListOfMovies()
        {
            return this._list;
        }
        public cMovie getMovie(string code)
        {
            foreach (cMovie mv in this._list)
            {
                if (mv.MovieID.Equals(code)) 
                {
                    return mv;
                }
            }
            return null;
        }
        public void Add(cMovie mv)
        {
            if (getMovie(mv.MovieID) == null)
            {
                this._list.Add(mv);
                MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveFile();
            }
            else
            {
                MessageBox.Show("Mã phim đã tồn tại, vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Modify(cMovie mv)
        {
            cMovie result = getMovie(mv.MovieID);
            if (result != null)
            {
                result.MovieID = mv.MovieID;
                result.MovieName = mv.MovieName;
                result.Director = mv.Director;
                result.Actors = mv.Actors;
                result.Genres = mv.Genres;
                result.Country = mv.Country;
                result.Duration = mv.Duration;

                MessageBox.Show("Đã sửa thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveFile();
            }

        }
        public void Delete(string code)
        {
            cMovie result = getMovie(code);
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

        // ================================================= Tìm =================================================
        public List<cMovie> findMovieCode(string code)
        {
            List<cMovie> result = new List<cMovie>();
            foreach (cMovie m in this._list)
            {
                if (m.MovieID.IndexOf(code, StringComparison.OrdinalIgnoreCase) >= 0)
                    result.Add(m);
            }
            return result;
        }
        public List<cMovie> findMovieName(string name)
        {
            List<cMovie> result = new List<cMovie>();
            foreach (cMovie m in this._list)
            {
                if (m.MovieName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                    result.Add(m);
            }
            return result;
        }
        public List<cMovie> findDirector(string director)
        {
            List<cMovie> result = new List<cMovie>();
            foreach (cMovie m in this._list)
            {
                if (m.Director.IndexOf(director, StringComparison.OrdinalIgnoreCase) >= 0)
                    result.Add(m);
            }
            return result;
        }
        public List<cMovie> findActors(string actors)
        {
            List<cMovie> result = new List<cMovie>();
            foreach (cMovie m in this._list)
            {
                if (m.Actors.IndexOf(actors, StringComparison.OrdinalIgnoreCase) >= 0)
                    result.Add(m);
            }
            return result;
        }
        public List<cMovie> findCountry(string country)
        {
            List<cMovie> result = new List<cMovie>();
            foreach (cMovie m in this._list)
            {
                if (m.Country.IndexOf(country, StringComparison.OrdinalIgnoreCase) >= 0)
                    result.Add(m);
            }
            return result;
        }
        public List<cMovie> findGenres(string genres)
        {
            List<cMovie> result = new List<cMovie>();
            foreach (cMovie m in this._list)
            {
                if (m.Genres.IndexOf(genres, StringComparison.OrdinalIgnoreCase) >= 0)
                    result.Add(m);
            }
            return result;
        }
        //================================================= Lưu =================================================
        public void SaveFile()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this._filePath))
                {
                    foreach (cMovie movie in this._list)
                    {
                        sw.WriteLine(movie.Data());
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
                        this._list.Clear();
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] data = line.Split('|');
                            if (data.Length == 7)
                            {
                                string movieCode = data[0].Trim();
                                string movieName = data[1].Trim();
                                string director = data[2].Trim();
                                string actors = data[3].Trim();
                                string genres = data[4].Trim();
                                int duration = int.Parse(data[5].Trim().Replace(" phút", ""));
                                string country = data[6].Trim().TrimEnd('.');

                                cMovie m = new cMovie(movieCode, movieName, director, actors, genres, duration, country);
                                this._list.Add(m);
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
