using Sample.API.Data;
using Sample.API.Helper;
using Sample.API.Interfaces;
using Sample.API.Models;

namespace Sample.API.Service
{
    public class MovieService : IMovieService
    {
        private MovieData _data;
        public MovieService()
        {
            this._data = new MovieData();
        }

        public PaginatedList<Movie> GetAll(int page)
        {
            return PaginatedList<Movie>.Create(_data.GetAllMovies(), page, 10);
        }

        public Movie? GetById(int id)
        {
            return _data.GetMovieById(id);
        }

        public List<Movie> GetByTitle(string title)
        {
            return _data.GetMoviesByTitle(title);
        }

        public List<Movie> GetByStartingLetters(string startingTitle)
        {
            return _data.GetMoviesByStartingLetters(startingTitle);
        }
    }
}
