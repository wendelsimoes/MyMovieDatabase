using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMovieDatabase.Models;

namespace MyMovieDatabase.Data.EFCore
{
    public class MyMovieDatabaseContext : DbContext
    {
        public MyMovieDatabaseContext(DbContextOptions<MyMovieDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; } = default!;
        public DbSet<Star> Star { get; set; } = default!;
    }
}
