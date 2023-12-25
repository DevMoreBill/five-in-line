using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace five_in_line
{
    public class Game
    {
        private GameBoard board;
        private Cell.CellState currentPlayer;

        public Game(int boardSize)
        {
            board = new GameBoard(boardSize);
            currentPlayer = Cell.CellState.Cross; // Начинает игрок с крестиком
        }
        public bool MakeMove(int row, int column)
        {
            if (board.IsMoveValid(row, column))
            {
                board.MakeMove(row, column, currentPlayer);
                if (board.CheckForWin(row, column))
                {
                    Console.WriteLine("Игрок" + currentPlayer + " победил!");
                    return true;
                }
                else
                {
                    currentPlayer = currentPlayer == Cell.CellState.Cross ? Cell.CellState.Nought : Cell.CellState.Cross;
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Ход невозможен. Выберите другую клетку.");
                return false;
            }
        }
    }
}
