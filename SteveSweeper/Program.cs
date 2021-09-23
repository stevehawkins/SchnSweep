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
            var view = new ConsoleDisplay();
            // board
            IGame game = new Game();
            game.CreateNewGame(view);

            // test only
            game.DebugBoardDisplay();

            while(!game.IsGameOver())
            {
                var userInput = view.ReadLine();
                userInput = userInput.ToLower().Trim();
                game.Move(userInput);
            }

            view.WriteLine("Game Over");
            view.ReadLine();
        }
    }
}
