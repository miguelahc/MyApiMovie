using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApiMovie.TheMovieDb.DO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MyApiMovie.TheMovieDb.TheMovieDb;

namespace MyApiMovie.TheMovieDb
{
    public static class Core
    {
        
        public static List<Movie> SearchMovieByCompanyId(int companyId)
        {
            //http://api.themoviedb.org/3/company/25/movies?api_key=fbc0dda5d56d33fc8be3a4bc875ad311&language=es
            string searchMovieUri = String.Format("{0}company/{1}/movies?api_key={2}&language={3}", TheMovieDb.TheMovieDbConfig.UrlBase,companyId, TheMovieDb.TheMovieDbConfig.ApiKey, TheMovieDb.TheMovieDbConfig.Language);
            WebClient webclient = new WebClient() { Encoding = Encoding.UTF8 };
            List<Movie> listMovie = new List<Movie>();
            try
            {
                dynamic objectDynamicResult = JObject.Parse(webclient.DownloadString(searchMovieUri));
                foreach (var item in objectDynamicResult.results)
                {
                    Movie movie = new Movie();
                    movie.Adult = item.adult;
                    string backdropPath=item.backdrop_path;
                    movie.BackdropPath = TheMovieDb.ImageTool.GetFullPath(backdropPath, ImageTool.TypeImage.backdrop, ImageTool.SizeImage.original);
                    movie.MovieId = item.id;
                    movie.OriginalTitle = item.original_title;
                    string releaseDate = item.release_date;
                    movie.ReleaseDate = DateTime.Parse(releaseDate);
                    string posterPath=item.poster_path;
                    movie.PosterPath = TheMovieDb.ImageTool.GetFullPath(posterPath, ImageTool.TypeImage.poster, ImageTool.SizeImage.original);
                    movie.Popularity = item.popularity;
                    movie.Title = item.title;
                    movie.Popularity = item.vote_average;
                    listMovie.Add(movie);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return listMovie;

        }

        public static List<Movie> SearchMovieByTitle(String title)
        {
            //http://api.themoviedb.org/3/search/multi?api_key=fbc0dda5d56d33fc8be3a4bc875ad311&query=rocky
            string searchMovieUri = String.Format("{0}search/multi?api_key={1}&query={2}&language={3}", TheMovieDb.TheMovieDbConfig.UrlBase, TheMovieDb.TheMovieDbConfig.ApiKey, title,TheMovieDb.TheMovieDbConfig.Language);
            WebClient webclient = new WebClient() { Encoding = Encoding.UTF8 };
            List<Movie> listMovie = new List<Movie>();
            try
            {
                dynamic objectDynamicResult = JObject.Parse(webclient.DownloadString(searchMovieUri));
                foreach (var item in objectDynamicResult.results)
                {
                    if (item.media_type = "movie")
                    {
                        Movie movie = new Movie();
                        movie.Adult = item.adult;
                        string backdropPath=item.backdrop_path;
                        movie.BackdropPath = TheMovieDb.ImageTool.GetFullPath(backdropPath , ImageTool.TypeImage.backdrop, ImageTool.SizeImage.original);
                        movie.MovieId = item.id;
                        movie.OriginalTitle = item.original_title;
                        string releaseDate = item.release_date;
                        movie.ReleaseDate=DateTime.Parse(releaseDate);
                        string posterPath=item.poster_path;
                        movie.PosterPath= TheMovieDb.ImageTool.GetFullPath(posterPath, ImageTool.TypeImage.poster, ImageTool.SizeImage.original);
                        movie.Popularity = item.popularity;
                        movie.Title = item.title;
                        listMovie.Add(movie);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return listMovie;
        }

        public static Movie SearchMovieById(int movieId)
        {
            //http://api.themoviedb.org/3/movie/1366?api_key=fbc0dda5d56d33fc8be3a4bc875ad311&language=es
            string searchMovieUri=String.Format("{0}movie/{1}?api_key={2}&language={3}", TheMovieDb.TheMovieDbConfig.UrlBase,movieId,TheMovieDb.TheMovieDbConfig.ApiKey,TheMovieDb.TheMovieDbConfig.Language);
            WebClient webclient = new WebClient() { Encoding = Encoding.UTF8 };
            Movie movie = new Movie();
            try
            {
                dynamic objectDynamicMovie = JObject.Parse(webclient.DownloadString(searchMovieUri));
                movie.MovieId = objectDynamicMovie.id;
                movie.Adult = objectDynamicMovie.adult;
                string backdropPath = objectDynamicMovie.backdrop_path;
                movie.BackdropPath = TheMovieDb.ImageTool.GetFullPath(backdropPath, ImageTool.TypeImage.backdrop, ImageTool.SizeImage.original);
                movie.HomePage = objectDynamicMovie.homepage;
                movie.ImdbId = objectDynamicMovie.imdb_id;
                movie.Title = objectDynamicMovie.title;
                movie.OriginalTitle = objectDynamicMovie.original_title;
                movie.OverView = objectDynamicMovie.overview;
                movie.Popularity = objectDynamicMovie.popularity;
                string posterPath=objectDynamicMovie.poster_path;
                movie.PosterPath = TheMovieDb.ImageTool.GetFullPath(posterPath, ImageTool.TypeImage.poster, ImageTool.SizeImage.original);
                string releaseDate = objectDynamicMovie.release_date;
                movie.ReleaseDate = DateTime.Parse(releaseDate);
                if ( objectDynamicMovie.runtime !=null)
                    movie.RunTime =  objectDynamicMovie.runtime;
                
                foreach (var item in objectDynamicMovie.genres)
                {
                    Genre genre = new Genre();
                    genre.GenreId = item.id;
                    genre.Name = item.name;
                    movie.Genres.Add(genre);
                }

                foreach (var item in objectDynamicMovie.production_companies)
                {
                    Company company = new Company();
                    company.CompanyId = item.id;
                    company.Name = item.name;
                    movie.Companies.Add(company);
                }

                foreach (var item in objectDynamicMovie.production_countries)
                {
                    Country country = new Country();
                    country.CountryId = item.id;
                    country.Name = item.name;
                    movie.Countries.Add(country);
                }

                foreach (var item in objectDynamicMovie.spoken_languages)
                {
                    Language language = new Language();
                    language.LanguageId = item.id;
                    language.Name = item.name;
                    movie.Languages.Add(language);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return movie;
        }
     }
}
