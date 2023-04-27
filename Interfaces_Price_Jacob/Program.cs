using System;

namespace Interfaces_Price_Jacob
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates a new game and movie object
            Game rE = new Game("Mature", "Horror", "Resident Evil");
            Movie holloween = new Movie("R", "Horror", "Holloween");
            

            //calls the describe and play game method on the rE game object
            Console.WriteLine(rE.Describe());
            rE.PlayGame();

            //calls the Describe() and StartMovie() method ont the holloween Movie object
            Console.WriteLine(holloween.Describe());
            holloween.StartMovie();
        }
    }
}
