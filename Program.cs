using System;

namespace TablicaWynikowGry
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            Player player1 = new Player("Alicja");
            Player player2 = new Player("Adam");

            game.RegisterObserver(player1);
            game.RegisterObserver(player2);

            game.UpdateScore("Alicja", 10);
            game.UpdateScore("Adam", 15);
        }
    }
}
