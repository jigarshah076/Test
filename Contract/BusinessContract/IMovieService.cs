

using Model;
using System.Collections.Generic;

namespace Contract.BusinessContract
{
    public interface IMovieService
    {
        List<Movie> GetAllMovieList();
        
    }
}
