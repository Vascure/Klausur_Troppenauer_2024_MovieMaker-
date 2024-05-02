using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klausur_Troppenauer_2024_MovieMaker_
{
    abstract class RentalStore
    {



        protected List<Movie> movies;
        private int movieNumber;

        public RentalStore(List<Movie> movies)
        {
            this.movies = movies;
        }

        private void DisplayMovies(List<Movie> movies)
        {
            int counter = 1;
            foreach (var movie in movies)
            {
                Console.WriteLine(counter + ": "+" Name: "+ " " + movie.Get_Title() + " " +" Directed by: "+  movie.getDirector() + " Film wurde ausgeliehen: " + movie.IsRented);
                counter++;
            }
        }


        private void rentMovie()
        {
            if (this.movieNumber < movies.Count())
            {
                if (!movies[movieNumber].IsRented)
                {
                    movies[movieNumber].IsRented = true;
                    Console.WriteLine("You have rented this movie!");
                }
                else
                {
                    Console.WriteLine("Sorry, this Movie is currently unavailable.");
                }

            }
            else
            {throw new Exception();
                Console.WriteLine("I cannot understand what you are trying to tell me.");
                
            }

        }

        private void getUserInput()
        {
            bool valideInput = false;
            Console.WriteLine("Enter the number of the Movie you want to rent.");
            while (!valideInput)
            {
                if (Int32.TryParse(Console.ReadLine(), out movieNumber))

                {
                    movieNumber--;
                    try
                    {

                        rentMovie();
                        valideInput = true;
                    }
                    catch (Exception e)
                    {

                    }
                }
                else
                {
                    Console.WriteLine("Input Invalid. Please try to type in a number.");
                }
            }
        }

        public void addMovie( Movie movie )
        {
            movies.Add(movie);
        }

            public void Start()
            {
                var validInput = false;
                while (!validInput)
                {
                    Console.WriteLine("These are the available Movies: ");
                    DisplayMovies(movies);

                    Console.WriteLine("Please enter 'R' to rent a movie 'X' to go back.");
                    var answer = Console.ReadLine();
                    if (answer == "r" || answer == "R")
                    {
                    getUserInput();


                    }
                    else if (answer == "x" || answer == "X")
                    {
                        validInput = true;
                        return;
                    }
                    else
                    {
                        Console.WriteLine("I cannot read what you are trying to tell me- please try something else.");
                    }

                }
            }
        }
    }

