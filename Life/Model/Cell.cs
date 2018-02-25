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
        private bool isAlive = false;
        private bool wasAlive = false;
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
        public bool IsAlive
        {
            get { return isAlive; }
            set { isAlive = value; }
        }
        public bool WasAlive
        {
            get { return wasAlive; }
            set { wasAlive = value; }
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
            if (isAlive)
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
            if (isAlive)
            {
                isAlive = false;
            }
            else
            {
                isAlive = true;
            }

            wasAlive = isAlive;
        }
    }
}
