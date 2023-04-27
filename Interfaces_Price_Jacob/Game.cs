using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Price_Jacob
{
    /// <summary>
    /// This is the Game class, it implements the IGenre interface
    /// </summary>
    class Game : IGenre
    {
        //the constructor for the game class, it has three string parameters: esbr, genre, and title
        public Game(string esbr, string genre, string title)
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

        //the Describe Method returning a description of the games title, genre, and ESBR rating;
        public string Describe()
        {
            return $"The game {Title} is a\\n {Genre} game with the rating {ESBR}";
        }

        //the PlayGame method, prints to console which game is starting
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is starting");
        }
    }
}
