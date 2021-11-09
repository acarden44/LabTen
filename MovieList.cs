using System;
using System.Collections.Generic;

namespace Lab10Movies
{
    class Movie
    {
        private string title;
        private string category;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public Movie()
        {

        }

        public Movie(string movieTitle, string movieCategory)
        {
            title = movieTitle;
            category = movieCategory;
        }

        public static void PrintMoviesByType(List<Movie> movieList, string categorySelected)
        {
            foreach (Movie movie in movieList)
            {
                if (categorySelected == movie.category)
                {
                    Console.WriteLine($"{movie.title}");
                }
            }
        }
    }

}