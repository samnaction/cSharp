using System;

namespace DeferredExecution
{
    public class Movie
    {
        public Movie(int year, string name)
        {
            _year = year;
            Name = name;
        }
        private int _year;
        public string Name { get; set; }

        public int Year {
            get
            {
                Console.WriteLine($"Returning Year : {_year} for Name : {Name} ");
                return _year;
            } 
            set
            {
                _year = value;
            }
        }
    }
}
