using MyMovieDatabase.Models;

namespace MyMovieDatabase.Data.EFCore
{
    public class EfCoreStarRepository : EfCoreRepository<Star, MyMovieDatabaseContext>
    {
        public EfCoreStarRepository(MyMovieDatabaseContext context) : base(context)
        {
        }
    }
}
