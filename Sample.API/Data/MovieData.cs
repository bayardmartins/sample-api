using Sample.API.Models;

namespace Sample.API.Data
{
    public class MovieData
    {
        private List<Movie> _movies;
        public MovieData()
        {
            MockDB mock = new MockDB();
            _movies = mock.GetMovies();
        }

        public List<Movie> GetAllMovies()
        {
            return _movies;
        }

        public Movie? GetMovieById(int id)
        {
            return _movies.FirstOrDefault(x => x.Id == id);
        }

        public List<Movie> GetMoviesByTitle(string title)
        {
            return _movies.FindAll(x => x.Title.ToLower().Contains(title.ToLower()));
        }

        public List<Movie> GetMoviesByStartingLetters(string title)
        {
            return _movies.FindAll(x => x.Title.ToLower().StartsWith(title.ToLower()));
        }
    }
}
