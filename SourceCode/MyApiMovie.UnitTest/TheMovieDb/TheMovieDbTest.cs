using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyApiMovie.TheMovieDb;
using System.Collections.Generic;
namespace MyApiMovie.UnitTest
{
    [TestClass]
    public class TheMovieDbTest
    {
        [TestMethod]
        public void SearchMovieByIdTest()
        {
            TheMovieDb.DO.Movie movie = Core.SearchMovieById(43504);
        }

        [TestMethod]
        public void SearchMovieByIdTitleTest()
        {
            List<TheMovieDb.DO.Movie> moviesTitle = Core.SearchMovieByTitle("Rocky");
        }

        [TestMethod]
        public void SearchMovieByIdCompanyTest()
        {
            List<TheMovieDb.DO.Movie> moviesCompany = Core.SearchMovieByCompanyId(25);
        }

        [TestMethod]
        public void GetFullPathTest()
        {
            //Concatenar cadena Img

            
        }

        
    }
}
