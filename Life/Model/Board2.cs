using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    class Board2
    {
        private int size;
        public int generation = 0;
        public Cell2[,] cells;

        public Board2(int size)
        {
            this.size = size;
            cells = new Cell2[size, size];

            for (int i = 0; i < this.size; i++)
            {
                for (int k = 0; k < this.size; k++)
                {
                    cells[i, k] = new Cell2(i,k);

                    if (i == 0 || i == size - 1 || k == 0 || k == size - 1)
                    {
                        cells[i, k].IsOnBorder = true;
                    }
                }

            }
        }

        public void CheckALife()
        {
            for (int i = 0; i < this.size; i++)
            {
                for (int k = 0; k < this.size; k++)
                {

                    if (i != 0 && i != size - 1 && k != 0 && k != size - 1)
                    {
                        
                        if(cells[i,k].WasAlife == false && CountNeighbors(i, k) == 3)
                        {
                            cells[i, k].IsAlife = true;
                        }
                        else if (cells[i, k].WasAlife == true && (CountNeighbors(i, k) == 2 || CountNeighbors(i, k) == 3))
                        {

                        }else
                        {
                            cells[i, k].IsAlife = false;
                        }
                    }
                }

            }

            for (int i = 0; i < this.size; i++)
            {
                for (int k = 0; k < this.size; k++)
                {
                    cells[i, k].WasAlife = cells[i, k].IsAlife;

                    if (cells[i, k].IsAlife == true)
                    {
                        cells[i, k].bCell.BackColor = System.Drawing.SystemColors.Control;
                    }
                    else
                    {
                        cells[i, k].bCell.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
                    }
                }

            }

            generation++;
        }

        private int CountNeighbors(int x, int y)
        {
            int neighbors = 0;
            for(int i=-1; i < 2; i++)
            {
                for (int k = -1; k < 2; k++)
                {
                    if((i!=0 && k != 0) || (i != 0 && k == 0) || (i == 0 && k != 0))
                    {
                        if (cells[x + i, y + k].WasAlife)
                        {
                            neighbors++;
                        }
                    }
                }
            }
            
            return neighbors;
        }

        public void AddToPanel(System.Windows.Forms.Panel panel)
        {
            for (int i = 0; i < this.size; i++)
            {
                for (int k = 0; k < this.size; k++)
                {
                    panel.Controls.Add(cells[i, k].bCell);
                }

            }
        }

        public void Clear()
        {
            foreach (var cell in cells)
            {
                cell.IsAlife = false;
                cell.WasAlife = cell.IsAlife;
                cell.bCell.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
                generation = 0;
            }
        }
    }
}
