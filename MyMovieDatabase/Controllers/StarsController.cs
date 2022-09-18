using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyMovieDatabase.Data.EFCore;
using MyMovieDatabase.Models;

namespace MyMovieDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarsController : BaseController<Star, EfCoreStarRepository>
    {
        public StarsController(EfCoreStarRepository repository) : base(repository)
        {

        }
    }
}
