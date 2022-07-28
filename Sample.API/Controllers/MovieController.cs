using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sample.API.Helper;
using Sample.API.Interfaces;
using Sample.API.Models;

namespace Sample.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class MovieController : ControllerBase
    {
        private readonly ILogger<MovieController> _logger;
        private readonly IMovieService _movieService;

        public MovieController(ILogger<MovieController> logger, IMovieService movieService)
        {
            _logger = logger;
            _movieService = movieService;
        }

        /// <summary>
        /// Fetch all movies into a paginated list
        /// </summary>
        /// <param name="page">Pagination number</param>
        /// <returns>A paginated list of movies</returns>
        /// <response code="500">Bad Request</response>
        [ProducesResponseType(typeof(FormattedResponse<PaginatedList<Movie>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(FormattedResponse<>), StatusCodes.Status400BadRequest)]
        [HttpGet("GetAllMovies/{page}")]
        public ActionResult GetAll(int page)
        {
            if (page < 1)
                return BadRequest(new FormattedResponse<BadRequestObjectResult>(null, Constants.PageNumberToLow, Statuses.BadRequest));
            var paginatedResponse = _movieService.GetAll(page);
            if (paginatedResponse.PageIndex > paginatedResponse.TotalPages)
                return BadRequest(new FormattedResponse<PaginatedList<Movie>>(paginatedResponse, Constants.PageNumberToHigh, Statuses.BadRequest));
            return Ok(new FormattedResponse<PaginatedList<Movie>>(paginatedResponse, Constants.Success, Statuses.Success));
        }

        /// <summary>
        /// Fetch a movie by Id
        /// </summary>
        /// <param name="id">Movie Id</param>
        /// <returns>A movie</returns>
        [ProducesResponseType(typeof(FormattedResponse<Movie>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(FormattedResponse<>), StatusCodes.Status404NotFound)]
        [HttpGet("GetMovieById/{id}")]
        public ActionResult GetById(int id)
        {
            var movie = _movieService.GetById(id);
            if (movie == null)
                return NotFound(new FormattedResponse<NotFoundObjectResult>(null, Constants.MovieNotFound, Statuses.NotFound));
            return Ok(new FormattedResponse<Movie>(movie, Constants.Success, Statuses.Success));
        }

        /// <summary>
        /// Fetches a movie list by title fragment
        /// </summary>
        /// <param name="title">Title Fragment</param>
        /// <returns>A list of movies</returns>
        [ProducesResponseType(typeof(FormattedResponse<List<Movie>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(FormattedResponse<>), StatusCodes.Status404NotFound)]
        [HttpGet("GetMovieByTitleFragment/{title}")]
        public ActionResult GetByName(string title)
        {
            var movieList = _movieService.GetByTitle(title);
            if (movieList.Count.Equals(0))
                return NotFound(new FormattedResponse<NotFoundObjectResult>(null, Constants.MovieNotFound, Statuses.NotFound));
            return Ok(new FormattedResponse<List<Movie>>(movieList, Constants.Success, Statuses.Success));
        }

        /// <summary>
        /// Fetch a list of movies that start with a giving sequence of 3 letters
        /// </summary>
        /// <param name="startingTitle">Starting Title (Needs to be 3 characters length)</param>
        /// <returns>List of Movies</returns>
        [ProducesResponseType(typeof(FormattedResponse<List<Movie>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(FormattedResponse<>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(FormattedResponse<>), StatusCodes.Status400BadRequest)]
        [HttpGet("GetMoviesByTitleStart/{startingTitle}")]
        public ActionResult GetByStartingLetters(string startingTitle)
        {
            if (startingTitle.Length != 3)
                return BadRequest(new FormattedResponse<BadRequestObjectResult>(null, Constants.InvalidQuery, Statuses.BadRequest));
            var movieList = _movieService.GetByStartingLetters(startingTitle);
            if (movieList.Count.Equals(0))
                return NotFound(new FormattedResponse<NotFoundObjectResult>(null, Constants.MovieNotFound, Statuses.NotFound));
            return Ok(new FormattedResponse<List<Movie>>(movieList, Constants.Success, Statuses.Success));
        }
    }
}