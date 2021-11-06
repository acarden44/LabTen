using System;
using System.Collections.Generic;

namespace Lab10Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieList = new List<Movie>
            {
                new Movie ("Cinderella", "Animated"),
                new Movie ("Finding Nemo", "Animated"),
                new Movie ("Snow White", "Animated"),
                new Movie ("Toy Story", "Animated"),
                new Movie ("Toy Story 2", "Animated"),
                new Movie ("Beautiful Boy", "Drama"),
                new Movie ("Gone with the Wind", "Drama"),
                new Movie ("On Golden Pond", "Drama"),
                new Movie ("Stand by Me", "Drama"),
                new Movie ("West Side Story", "Drama"),
                new Movie ("Blade Runner", "Scifi"),
                new Movie ("Serenity", "Scifi"),
                new Movie ("Star Wars", "Scifi"),
                new Movie ("The New Mutants", "Scifi"),
                new Movie ("The Tomorrow War", "Scifi"),
                new Movie ("Candyman", "Horror"),
                new Movie ("Friday the 13th", "Horror"),
                new Movie ("Halloween", "Horror"),
                new Movie ("IT the Movie", "Horror"),
                new Movie ("Nightmare on Elm Street", "Horror"),
            };
            Console.WriteLine("Welcome to Movie Phone Online!");
            Console.WriteLine("----------------------------------");
            Console.WriteLine();

            bool userContinue = true;
            while (userContinue)
            {
                string userInput = GetUserInput("Which genre are you interested in?\nScifi\tDrama\tHorror\tAnimated");

                Console.WriteLine();
                Movie.PrintMoviesByType(movieList, userInput);
                Console.WriteLine();

                userContinue = AnotherGenre("Would you like to see another genre? (y/n)", "n", "y");
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
