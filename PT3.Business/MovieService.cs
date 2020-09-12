using Contract.BusinessContract;
using Contract.DataAccessContract;
using Model;
using System.Collections.Generic;

namespace Business
{
    public class MovieService : IMovieService
    {
        public IMovieDBClient _movieDBClient { get; }
        public MovieService(IMovieDBClient movieDBClient)
        {
            _movieDBClient = movieDBClient;
        }
        
        public List<Movie> GetAllMovieList()
        {
            return _movieDBClient.GetAllMovieList();
        }
    }
}
