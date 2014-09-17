using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiMovie.TheMovieDb.DO
{
    public class Company
    {
        public int CompanyId { set; get; }
        public string Name { set; get; }

        public Company() { }
        public Company(string name) 
        {
            Name = name;
        }
        public Company(int companyId, string name)
        {
            CompanyId = companyId;
            Name=name;
        }
    }
}
