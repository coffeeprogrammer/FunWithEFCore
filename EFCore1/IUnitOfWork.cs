using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore1
{
    public interface IUnitOfWork
    {
        IMovieRepository Movies { get; }

        int Complete();
            }
}
