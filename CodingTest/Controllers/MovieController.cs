using Contract.BusinessContract;
using Microsoft.AspNetCore.Mvc;

namespace CodingTest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        public IMovieService _movieService { get; }
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public ActionResult<string> GetAllMovieList()
        {
            var data = _movieService.GetAllMovieList();
            return Newtonsoft.Json.JsonConvert.SerializeObject(data);
        }
    }
}