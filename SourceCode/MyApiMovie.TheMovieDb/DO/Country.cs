using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiMovie.TheMovieDb.DO
{
    public class Country
    {
        public string CountryId { set; get; }
        public string Name { set; get; }
        public Country() { }
        public Country(string name) 
        {
            Name = name;
        }
        public Country(string countryId, string name)
        {
            CountryId = countryId;
            Name = name;
        }
    }
}
