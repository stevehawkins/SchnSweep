using SteveSweeper.Components;
using SteveSweeper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveSweeper
{
    class Program
    {
        static void Main(string[] args)
        {

            // board
            IGame game = new Game();
            game.CreateNewGame();

            // test only
            game.DebugBoardDisplay();

            while(!game.IsGameOver())
            {
                var userInput = Console.ReadLine();
                userInput = userInput.ToLower().Trim();
                game.Move(userInput);
            }

            Console.WriteLine("Game Over");
            Console.ReadLine();
        }
    }
}
