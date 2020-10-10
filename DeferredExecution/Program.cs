using System;
using System.Collections.Generic;
using System.Linq;

namespace DeferredExecution
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Random().Where(n => n > 0.5).Take(5).OrderByDescending( n => n);

            //Infinit Loop
            //var numbers = Random().Where(n => n > 0.5).OrderByDescending(n => n).Take(5);


            foreach (var number in numbers)
            {
                Console.WriteLine($"Number::{number}");
            }


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

            Console.WriteLine("**********************************");

            var query4 = movies.FilterWithYield(m => m.Year > 2010).Take(1);

            var enumerator = query.GetEnumerator();

            //foreach (var movie in query4)
            //{
            //    Console.WriteLine($"Name: {movie.Name}");
            //}

        }

        public static IEnumerable<double> Random()
        {
            var random = new Random();
            while (true)
                yield return random.NextDouble();
        }
    }
}
