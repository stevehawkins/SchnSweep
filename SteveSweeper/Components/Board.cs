using SteveSweeper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveSweeper.Components
{
    public class Board : IBoard
    {
        readonly List<string> _CellVals = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        IDictionary<int, List<ICell>> _Cells; 
        const int _Rows = 10;
        const int _Columns = 10;

        public Board()
        {
        }

    
        public void Initialise()
        {
          // GEN RANDOM FIRST
            Random rand = new Random();

            bool[] randPos = new bool[100];

            for (int i = 0; i < 90; i++)
                randPos[i] = false;

            for (int i = 90; i < 100; i++)
                randPos[i] = true;

            for (int i = 0; i < 100; i++)
            {
                int pos = rand.Next(100);
                bool save = randPos[i];
                randPos[i] = randPos[pos];
                randPos[pos] = save;
            }

            // ADD TO OUR CELLS
            _Cells = new Dictionary<int, List<ICell>>();

            var currentPos = 0;

            // gen cells
            for (int x = 0; x < _Rows; x++)
            {
                var colList = new List<ICell>();
                for (int y = 0; y < _Columns; y++)
                {
                    // is bomb
                    ICell celltype;
                    if (randPos[currentPos])
                    {
                        celltype = new BombCell();
                    }
                    else
                    {
                        celltype = new BoardCell(); 
                    }

                    celltype.Location = $"{_CellVals[x]}{y+1}"; // ie C2
                    colList.Add(celltype);

                    currentPos++;
                }

                _Cells.Add(x, colList);
            }
        }

        // for testing 
        public void ShowBoard()
        {
            foreach (var lists in _Cells)
            {
                foreach (var ele in lists.Value)
                {
                    if (ele.IsBomb)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }

        public bool IsBombPosition(EnumMove PositionMove, IPlayer CurrentPlayer)
        {
            var row = CurrentPlayer.CurrentRow;
            var col = CurrentPlayer.CurrentColumn;

            switch (PositionMove)
            {
                case EnumMove.UP:
                    row--;
                    break;
                case EnumMove.DOWN:
                    row++;
                    break;
                case EnumMove.LEFT:
                    col--;
                    break;
                case EnumMove.RIGHT:
                    col++;
                    break;
            }

            // get the new item 
            var cell = _Cells[row];
            var itm = cell[col];

            CurrentPlayer.CurrentLocation = itm.Location;
            CurrentPlayer.CurrentRow = row;
            CurrentPlayer.CurrentColumn = col;

            return itm.IsBomb;
        }

        public bool IsMoveValid(EnumMove PositionMove, IPlayer CurrentPlayer)
        {
            // get the current item first 
            var row = CurrentPlayer.CurrentRow;
            var col = CurrentPlayer.CurrentColumn;

            var newRow = row;
            var newCol = col;

            switch (PositionMove)
            {
                case EnumMove.UP:
                    newRow--;
                    break;
                case EnumMove.DOWN:
                    newRow++;
                    break;
                case EnumMove.LEFT:
                    newCol--;
                    break;
                case EnumMove.RIGHT:
                    newCol++;
                    break;
            }

            if(newRow < 0 || newRow >= _Rows ||
                newCol < 0 || newCol >= _Columns)
            {
                // invalid move
                return false;
            }

            return true;
        }
    }
}
