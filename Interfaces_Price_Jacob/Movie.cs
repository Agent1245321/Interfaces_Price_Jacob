using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Price_Jacob
{
    /// <summary>
    /// This is the movie class, it implements the IGenre interface
    /// </summary>
    class Movie : IGenre
    {
        //the constructor for the movie class, it has three string parameters: esbr, genre, and title
        public Movie(string esbr, string genre, string title)
        {
            //it sets the corresponding properties to their parameters
            ESBR = esbr;
            Genre = genre;
            Title = title;
        }


        public string ESBR
        {
            //automatic getter and setter for ESBR property
            get; set;
        }

        public string Genre
        {
            //automatic getter and setter for Genre property
            get; set;
        }

        public string Title
        {
            //automatic getter and setter for Title property
            get; set;
        }

        //the Describe Method returning a description of the movies title, genre, and ESBR rating;
        public string Describe()
        {
            return $"The movie {Title} is a\\n {Genre} film with the rating {ESBR}";
        }

        //the start movie method, telling the user to be quite
        public void StartMovie()
        {
            Console.WriteLine($"{Title} is starting, shhhhhhhh!");
        }
    }
}
