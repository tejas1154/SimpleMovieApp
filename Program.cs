namespace MovieApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleMovieApp.LoadMovies();

            int choice;
            do
            {
                Console.WriteLine("\nSimple Movie App");
                Console.WriteLine("1. Display Movie");
                Console.WriteLine("2. Add Movie");
                Console.WriteLine("3. Clear All");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice = ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        SimpleMovieApp.DisplayMovie();
                        break;

                    case 2:
                        SimpleMovieApp.AddMovie();
                        break;

                    case 3:
                        SimpleMovieApp.ClearAll();
                        break;

                    case 4:
                        SimpleMovieApp.SaveMovie();
                        break;

                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
            } while (choice != 4);
        }
    }
}
