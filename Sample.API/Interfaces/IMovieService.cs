using Sample.API.Helper;
using Sample.API.Models;

namespace Sample.API.Interfaces
{
    public interface IMovieService
    {
        public PaginatedList<Movie> GetAll(int page);
        public Movie GetById(int id);
        public List<Movie> GetByTitle(string title);
        public List<Movie> GetByStartingLetters(string title);
    }
}
