using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiMovie.TheMovieDb.DO
{
    public class Movie
    {
        public int MovieId { set; get; }
        public bool Adult { set; get; }
        public string BackdropPath { set; get; }
        public List<Genre> Genres { set; get; }
        public string HomePage { set; get; }
        public string ImdbId { set; get; }
        public string Title { set; get; }
        public string OriginalTitle { set; get; }
        public string OverView { set; get; }
        public float Popularity { set; get; }
        public string PosterPath { set; get; }
        public List<Company> Companies { set; get; }
        public List<Country> Countries { set; get; }
        public DateTime ReleaseDate { set; get; }
        public int RunTime { set; get; }
        public List<Language> Languages { set; get; }

        public Movie() {
            Genres = new List<Genre>();
            Companies = new List<Company>();
            Countries = new List<Country>();
            Languages = new List<Language>();
        }

    }
}
