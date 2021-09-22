using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveSweeper.Interfaces
{
    public interface IPlayer
    {
        int CurrentRow { get; set; }
        int CurrentColumn { get; set; }
        string CurrentLocation { get; set; }
        int BombCount { get; set; }
        int Lives { get; set; }
        int MoveCount { get; set; }

        void DecrementLives();
        void Initialise();
    }
}
