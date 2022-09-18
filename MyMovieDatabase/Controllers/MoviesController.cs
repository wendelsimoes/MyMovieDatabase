using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMovieDatabase.Data.EFCore;
using MyMovieDatabase.Models;

namespace MyMovieDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : BaseController<Movie, EfCoreMovieRepository>
    {
        private readonly MyMovieDatabaseContext _context;

        public MoviesController(EfCoreMovieRepository repository) : base(repository)
        {
        }
    }
}
