using System;
using System.Collections.Generic;
using System.Linq;

namespace DeferredExecution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie (2010, "Movie A"),
                new Movie (2020, "Movie B"),
                new Movie (2005, "Movie C"),
                new Movie (2008, "Movie D")
            };

            var query = movies.Where(m => m.Year > 2005);

            foreach (var movie in query)
            {
                Console.WriteLine($"Name: {movie.Name}");
            }

            Console.WriteLine("**********************************");


            var query2 = movies.FilterWithoutYield(m => m.Year > 2005);

            foreach (var movie in query2)
            {
                Console.WriteLine($"Name: {movie.Name}");
            }

            Console.WriteLine("**********************************");


            var query3 = movies.FilterWithYield(m => m.Year > 2005);

            foreach (var movie in query3)
            {
                Console.WriteLine($"Name: {movie.Name}");
            }

        }
    }
}
