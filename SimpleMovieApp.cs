using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MovieApp
{
    internal class SimpleMovieApp
    {
        public static string filePath = "movies.txt";
        public static Movie[] movies = new Movie[5];
        public static int count = 0;

        public static void LoadMovies()
        {
            if (!File.Exists(filePath))
                return;

            string[] lines = File.ReadAllLines(filePath);
            count = 0;
            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    Movie m = Movie.FromString(line);
                    if (count < 5)
                        movies[count++] = m;
                    
                }
            }
        }

        public static void SaveMovie()
        {
            using (StreamWriter sm = new StreamWriter(filePath))
            {
                for(int i=0; i<count; i++)
                {
                    sm.WriteLine(movies[i].ToString());
                }
            }
        }

        public static void AddMovie()
        {
            if(count >= 5)
            {
                Console.WriteLine("Can not add more than 5 movies");
                return;
            }

            Console.Write("Enter Movie Id = ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name = ");
            string name = Console.ReadLine();

            Console.Write("Enter genre = ");
            string genre = Console.ReadLine();

            Console.Write("Enter Year = ");
            int year = int.Parse(Console.ReadLine());

            movies[count++] = new Movie(id, name, genre, year);
            Console.WriteLine("Movie has been added");
        }

        public static void DisplayMovie()
        {
            if(count == 0)
            {
                Console.WriteLine("No movies found");
                return;
            }

            Console.WriteLine("\nMovie List");
            for(int i=0; i < count; i++)
            {
                Movie m = movies[i];
                Console.WriteLine($"Id: {m.MovieId}, Name: {m.Name}, Genre: {m.Genre}, Year: {m.Year}");
            }
        }

        public static void ClearAll()
        {
            count = 0;
            SaveMovie();
            Console.WriteLine("All movies are cleared");
        }
    }
}
