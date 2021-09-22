using SteveSweeper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveSweeper.Components
{
    public class Player : IPlayer
    {
        public int BombCount { get; set; } = 0;
        public int Lives { get ; set ; }
        public int MoveCount { get; set; } = 0;
        public int CurrentRow { get; set ; }
        public int CurrentColumn { get ; set ; }
        public string CurrentLocation { get; set; } = "A1";

        public void DecrementLives()
        {
            Lives--;
        }

        public void Initialise()
        {
            BombCount = 0;
            Lives = 3;
            MoveCount = 0;

            CurrentColumn = 0;
            CurrentRow = 0;
        }

    }
}
