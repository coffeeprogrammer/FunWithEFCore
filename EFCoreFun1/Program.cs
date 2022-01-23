using EFCore1;
using Microsoft.EntityFrameworkCore;
using System;
using Models;
using System.Collections.Generic;

namespace EFCoreFun1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entity framework core");

            using (var context = new Context())
            {
                var movie1 = new Movie()
                {
                    Id = 1,
                    Title = "Star Wars",
                    Year = 1978,
                    Rating = 9
                };
                //context.Movies.Add(movie1);
                //context.SaveChanges();

                IGenericRepository<Movie> moviesRepo = new MovieRepository(context);

                moviesRepo.Create(movie1);
                var movies = moviesRepo.GetAll().ToListAsync().Result;
                ViewAll(movies);
                movie1.Year = 1979;
                moviesRepo.Update(1, movie1);
                movies = moviesRepo.GetAll().ToListAsync().Result;
                ViewAll(movies);

            }
        }


        public static void ViewAll(List<Movie> movies)
        {
            foreach (var m in movies)
            {
                Console.WriteLine(m.Id);
                Console.WriteLine(m.Title);
                Console.WriteLine(m.Year);
            }

        }
    }
}
