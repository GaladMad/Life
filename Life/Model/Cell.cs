using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life.Model
{
    class Cell
    {
        #region properties and fields
        private static int size = 10;
        private int x, y;
        private bool isAlife = false;
        private bool wasAlife = false;
        private bool isOnBorder = false;
        private Graphics graphics;

        public static int cellSize
        {
            get { return size; }
        }

        public bool IsOnBorder
        {
            get { return isOnBorder; }
            set { isOnBorder = value; }
        }
        public bool IsAlife
        {
            get { return isAlife; }
            set { isAlife = value; }
        }
        public bool WasAlife
        {
            get { return wasAlife; }
            set { wasAlife = value; }
        }
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void draw(Graphics graphics)
        {
            this.graphics = graphics;
            
            Brush newBrush;
            if (isAlife)
            {
                newBrush = new SolidBrush(Color.Black);
            }
            else
            {
                newBrush = new SolidBrush(Color.White);
            }

            graphics.FillRectangle(newBrush, x * size, y * size, size, size);
        }

        public void changeAlive()
        {
            if (isAlife)
            {
                isAlife = false;
            }
            else
            {
                isAlife = true;
            }

            wasAlife = isAlife;
        }
    }
}
