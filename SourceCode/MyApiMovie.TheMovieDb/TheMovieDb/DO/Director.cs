using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiMovie.TheMovieDb.DO
{
    public class Director
    {
        public int DirectorId { set; get; }
        public string Name { set; get; }
        public Director() { }
        public Director(string name) 
        {
            Name = name;
        }
        public Director(int directorId, string name)
        {
            DirectorId = directorId;
            Name = name;
        }
    }
}
