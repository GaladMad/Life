using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life.Model
{
    class Board
    {
        #region properties and fields
        private int boardSize;
        public int generation = 0;
        public Cell[,] cells;

        #endregion

        public Board(int boardSize)
        {
            this.boardSize = boardSize;
            cells = new Cell[boardSize, boardSize];

            for (int i = 0; i < this.boardSize; i++)
            {
                for (int k = 0; k < this.boardSize; k++)
                {
                    cells[i, k] = new Cell(i, k);

                    if (i == 0 || i == boardSize - 1 || k == 0 || k == boardSize - 1)
                    {
                        cells[i, k].IsOnBorder = true;
                    }
                }

            }
        }

        public void CheckALive()
        {
            for (int i = 0; i < this.boardSize; i++)
            {
                for (int k = 0; k < this.boardSize; k++)
                {

                    if (i != 0 && i != boardSize - 1 && k != 0 && k != boardSize - 1)
                    {

                        if (cells[i, k].WasAlive == false && CountNeighbors(i, k) == 3)
                        {
                            cells[i, k].IsAlive = true;
                        }
                        else if (cells[i, k].WasAlive == true && (CountNeighbors(i, k) == 2 || CountNeighbors(i, k) == 3))
                        {

                        }
                        else
                        {
                            cells[i, k].IsAlive = false;
                        }
                    }
                }

            }

            foreach (var cell in cells)
            {
                cell.WasAlive = cell.IsAlive;
            }

            generation++;
        }

        private int CountNeighbors(int x, int y)
        {
            int neighbors = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int k = -1; k < 2; k++)
                {
                    if ((i != 0 && k != 0) || (i != 0 && k == 0) || (i == 0 && k != 0))
                    {
                        if (cells[x + i, y + k].WasAlive)
                        {
                            neighbors++;
                        }
                    }
                }
            }

            return neighbors;
        }

        public void draw(Graphics graphics)
        {

            foreach (var cell in cells)
            {
                cell.draw(graphics);
            }

            Pen pen = new Pen(Color.Black);
            graphics.DrawRectangle(pen, 0, 0, boardSize * Cell.cellSize, boardSize * Cell.cellSize);

            int grid = Cell.cellSize;

            for (int i = 1; i < boardSize; i++)
            {
                graphics.DrawLine(pen, i * grid, 0, i * grid, boardSize * grid);
                graphics.DrawLine(pen, 0, i * grid, boardSize * grid, i * grid);
            }
        }

        public void Clear()
        {
            foreach (var cell in cells)
            {
                cell.IsAlive=false;
                cell.WasAlive = false;
            }

            generation = 0;
        }
    }
}
