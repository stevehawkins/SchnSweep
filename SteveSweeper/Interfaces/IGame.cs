using SteveSweeper.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveSweeper.Interfaces
{
    public interface IGame
    {
        void CreateNewGame(IDisplay Display);

        void Move(string MovePosition);

        void DebugBoardDisplay();

        bool IsGameOver();

    }
}
