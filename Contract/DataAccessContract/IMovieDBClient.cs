
using Model;
using System.Collections.Generic;

namespace Contract.DataAccessContract
{
    public interface IMovieDBClient
    {
        List<Movie> GetAllMovieList();
    }
}
