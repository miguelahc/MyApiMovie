using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiMovie.TheMovieDb.DO
{
    public class Genre
    {
        public int GenreId { set; get; }
        public string Name { set; get; }
        public Genre() { }
        public Genre(string name)
        {
            Name = name;
        }
        public Genre(int genreId, string name)
        {
            GenreId = genreId;
            Name = name;
        }
    }
}
