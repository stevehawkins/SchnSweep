using SteveSweeper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveSweeper.Components
{
    public class Game : IGame
    {
        readonly IBoard _PlayerBoard = new Board();
        readonly IPlayer _Player = new Player();

        public void CreateNewGame()
        {
            _PlayerBoard.Initialise();
            _Player.Initialise();
        }

        public void DebugBoardDisplay()
        {
            _PlayerBoard.ShowBoard();
        }

        public bool IsGameOver()
        {
            if (_Player.Lives == 0)
                return true;

            return false;
        }

        public void Move(string MovePosition)
        {
            var PlayerMove = EnumMove.INVALID;

            switch (MovePosition)
            {
                case "up":
                    PlayerMove= EnumMove.UP;
                    break;
                case "down":
                    PlayerMove = EnumMove.DOWN;
                    break;
                case "left":
                    PlayerMove = EnumMove.LEFT;
                    break;
                case "right":
                    PlayerMove = EnumMove.RIGHT;
                    break;
            }
           
            if (PlayerMove == EnumMove.INVALID)
            {
                Console.WriteLine("Invalid Command use : up / left / right / down");
                return;
            }

            var result = _PlayerBoard.IsMoveValid(PlayerMove, _Player);

            if(!result)
            {
                Console.WriteLine("Invalid Move");
            }
            else
            {
                var isBomb = _PlayerBoard.IsBombPosition(PlayerMove, _Player);
                if(isBomb)
                {
                    _Player.DecrementLives();                    
                    _Player.BombCount++;

                    Console.WriteLine("BOOM -> ");
                }

                _Player.MoveCount++;
            }

            Console.WriteLine($"Position {_Player.CurrentLocation} : Lives {_Player.Lives} : Moves : {_Player.MoveCount}");
        }
    }
}
