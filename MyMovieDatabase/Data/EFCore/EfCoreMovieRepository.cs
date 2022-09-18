using MyMovieDatabase.Models;

namespace MyMovieDatabase.Data.EFCore
{
    public class EfCoreMovieRepository : EfCoreRepository<Movie, MyMovieDatabaseContext>
    {
        public EfCoreMovieRepository(MyMovieDatabaseContext context) : base(context)
        {

        }
    }
}
