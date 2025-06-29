using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    internal class Movie
    {
        public int MovieId;
        public string Name;
        public string Genre;
        public int Year;

        public Movie(int movieId, string name, string genre, int year)
        {
            MovieId = movieId;
            Name = name;
            Genre = genre;
            Year = year;
        }

        public override string ToString()
        {
            return $"{MovieId},{Name},{Genre},{Year}";
        }

        public static Movie FromString(string data)
        {
            string[] parts = data.Split(',');
            return new Movie(
                int.Parse(parts[0]),
                parts[1],
                parts[2],
                int.Parse(parts[3])
                );
        }
    }
}
