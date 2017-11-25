using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            bool freez;

            if(bStart.Text == "Start")
            {
                bStart.Text = "Stop";
                freez = false;

            }
            else
            {
                bStart.Text = "Start";
                freez = true;
            }


            for (int i = 0; i < 100; i++)
            {
                //board.CheckALife();
                //this.lCountGeneration.Text = Convert.ToString(board.generation);
            }
            
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            //board.CheckALife();
            //this.lCountGeneration.Text = Convert.ToString(board.generation);
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            //board.Clear();
            //this.lCountGeneration.Text = "0";
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            if (Cell.BackColor == System.Drawing.SystemColors.ActiveCaptionText)
            {
                Cell.BackColor = System.Drawing.SystemColors.Control;
            }
            else
            {
                Cell.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myP = new Pen(Color.Black);
            Brush myB = new SolidBrush(Color.Red);
            g.DrawRectangle(myP, 10, 10, 520, 520);
            g.FillRectangle(myB, 20, 20, 50, 50);

        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X - 10;
            int y = e.Y - 10;
            this.lGeneration.Text = $"X={x}, Y={y}";
        }
    }
}
