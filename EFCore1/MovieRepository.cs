using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFCore1
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {

        public MovieRepository(Context dbContext) : base(dbContext)
        {

        }

        public async Task<IList<Movie>> Query(Expression<Func<Movie, bool>> filter)
        {
            throw new NotImplementedException();
        }

    }
}
