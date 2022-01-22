using EFCore1;
using Microsoft.EntityFrameworkCore;
using System;
using Models;

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
                    MovieId = 1,
                    Title = "Star Wars",
                    Year = 1978,
                    Rating = 9
                };
                context.Movies.Add(movie1);
                context.SaveChanges();



            }


        }
    }
}
