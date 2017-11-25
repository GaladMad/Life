using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life
{
    class Cell2
    {
        private Button btCell = new Button();
        private int defLocX = 10;
        private int defLocY = 70;
        private int size = 10;
        private bool isAlife = false;
        private bool wasAlife = false;
        private bool isOnBorder = false;


        public Button bCell { get { return btCell; } }
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

        public Cell2(int x, int y)
        {
            X = x;
            Y = y;

            btCell.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            btCell.UseVisualStyleBackColor = false;
            btCell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btCell.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            btCell.Location = new System.Drawing.Point(defLocX + x*size, defLocY + y*size);
            btCell.Size = new System.Drawing.Size(size, size);
            btCell.Click += new System.EventHandler(bCell_Click);

        }

        private void bCell_Click(object sender, EventArgs e)
        {
            if(isAlife == false)
            {
                isAlife = true;
                btCell.BackColor = System.Drawing.SystemColors.Control;
            }
            else
            {
                isAlife = false;
                btCell.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            }

            wasAlife = isAlife;
        }
    }
}
