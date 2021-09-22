using SteveSweeper.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveSweeper.Interfaces
{
    public interface IBoard
    {
        void Initialise();

        void ShowBoard();

        bool IsBombPosition(EnumMove PositionMove, IPlayer CurrentPlayer);

        bool IsMoveValid(EnumMove PositionMove, IPlayer CurrentPlayer);

    }
}
