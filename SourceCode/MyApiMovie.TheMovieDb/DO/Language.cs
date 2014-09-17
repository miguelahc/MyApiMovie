using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiMovie.TheMovieDb.DO
{
    public class Language
    {
        public string LanguageId { set; get; }
        public string Name { set; get; }

        public Language(){}
        public Language(string name)
        {
            Name = name;
        }
        public Language(string languageId, string name)
        {
            LanguageId = languageId;
            Name = name;

        }

    }
}
