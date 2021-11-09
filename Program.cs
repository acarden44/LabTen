using System;
using System.Collections.Generic;

namespace Lab10Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieList = new List<Movie> //stores a list of movies by category
            {
                //1 = Animated 2 = Drama 3 = SciFi 4 = Horror
                new Movie ("Cinderella", "1"),
                new Movie ("Finding Nemo", "1"),
                new Movie ("Snow White", "1"),
                new Movie ("Toy Story", "1"),
                new Movie ("Toy Story 2", "1"),
                new Movie ("Beautiful Boy", "2"),
                new Movie ("Gone with the Wind", "2"),
                new Movie ("On Golden Pond", "2"),
                new Movie ("Stand by Me", "2"),
                new Movie ("West Side Story", "2"),
                new Movie ("Blade Runner", "3"),
                new Movie ("Serenity", "3"),
                new Movie ("Star Wars", "3"),
                new Movie ("The New Mutants", "3"),
                new Movie ("The Tomorrow War", "3"),
                new Movie ("Candyman", "4"),
                new Movie ("Friday the 13th", "4"),
                new Movie ("Halloween", "4"),
                new Movie ("IT the Movie", "4"),
                new Movie ("Nightmare on Elm Street", "4"),
            };
            Console.WriteLine("Welcome to Movie Phone Online!");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("There are 5 genre's with 5 movies in each.");
            Console.WriteLine();

            bool userContinue = true;
            while (userContinue)
            {
                string userInput = GetUserInput("Which genre are you interested in seeing the list for? " +
                    "\n1 = Animated\t2 = Drama \t3 = Science Fiction\t4 = Horror"); //user chooses the genre

                Console.WriteLine();
                Movie.PrintMoviesByType(movieList, userInput);
                Console.WriteLine();

                userContinue = AnotherGenre("Would you like to see another genre? (y/n)", "n", "y"); //users asked if they want to continue.
            }
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static bool AnotherGenre(string message, string yes, string no)
        {
            string anothergenre = GetUserInput(message);
            if (anothergenre == yes)
            {
                return false;
            }
            else if (anothergenre == no)
            {
                return true;
            }
            else
            {
                return AnotherGenre(message, yes, no);
            }
        }
    }
}