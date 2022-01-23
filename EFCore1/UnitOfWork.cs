using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore1
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;

        public UnitOfWork(Context context)
        {
            _context = context;
            Movies = new MovieRepository(_context);

        }

        public IMovieRepository Movies { get; }

        public int Complete()
        {
            //throw new NotImplementedException();

            return _context.SaveChanges();
        }
    }
}
