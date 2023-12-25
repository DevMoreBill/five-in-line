using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace five_in_line
{
    public class GameBoard

    {
        private Cell[,] cells;

        public GameBoard(int size)
        {
            cells = new Cell[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    cells[i, j] = new Cell();
                }
            }
        }

        public bool IsMoveValid(int row, int column)
        {
            return cells[row, column].State == Cell.CellState.Empty;
        }


        public bool CheckForWin(int row, int column)
        {
            Cell.CellState player = cells[row, column].State;

            // Проверка горизонталей

            int count = 1;
            for (int c = column - 1; c >= 0; c--) // Проверяем влево

            {
                if (cells[row, c].State == player)
                {
                    count++;
                }
                else

                {
                    break;
                }
            }
            for (int c = column + 1; c < cells.GetLength(1); c++) // Проверяем вправо

            {
                if (cells[row, c].State == player)
                {
                    count++;
                }
                else

                {
                    break;
                }
            }
            if (count >= 5)
            {
                return true;
            }

            // Проверка вертикалей

            count = 1;
            for (int r = row - 1; r >= 0; r--) // Проверяем вверх

            {
                if (cells[r, column].State == player)
                {
                    count++;
                }
                else

                {
                    break;
                }
            }
            for (int r = row + 1; r < cells.GetLength(0); r++) // Проверяем вниз

            {
                if (cells[r, column].State == player)
                {
                    count++;
                }
                else

                {
                    break;
                }
            }
            if (count >= 5)
            {
                return true;
            }

            // Проверка диагоналей

            count = 1;
            for (int r = row - 1, c = column - 1; r >= 0 && c >= 0; r--, c--) // Проверяем левую верхнюю диагональ

            {
                if (cells[r, c].State == player)
                {
                    count++;
                }
                else

                {
                    break;
                }
            }
            for (int r = row + 1, c = column + 1; r < cells.GetLength(0) && c < cells.GetLength(1); r++, c++) // Проверяем правую нижнюю диагональ

            {
                if (cells[r, c].State == player)
                {
                    count++;
                }
                else

                {
                    break;
                }
            }
            if (count >= 5)
            {
                return true;
            }

            count = 1;
            for (int r = row - 1, c = column + 1; r >= 0 && c < cells.GetLength(1); r--, c++) // Проверяем правую верхнюю диагональ

            {
                if (cells[r, c].State == player)
                {
                    count++;
                }
                else

                {
                    break;
                }
            }
            for (int r = row + 1, c = column - 1; r < cells.GetLength(0) && c >= 0; r++, c--) // Проверяем левую нижнюю диагональ

            {
                if (cells[r, c].State == player)
                {
                    count++;
                }
                else

                {
                    break;
                }
            }
            if (count >= 5)
            {
                return true;
            }

            return false;
        }

        public void MakeMove(int row, int column, Cell.CellState player)
        {
            cells[row, column].State = player;
        }
    }
}
