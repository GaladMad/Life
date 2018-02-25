using Life.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

            if(bStart.Text == "Start")
            {
                bStart.Text = "Stop";
                timerGeneration.Enabled = true;

            }
            else
            {
                bStart.Text = "Start";
                timerGeneration.Enabled = false;
            }
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            createNewGeneration();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            board.Clear();
            this.lCountGeneration.Text = "0";
            panelGraphics.Invalidate();
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
            
            Graphics graphics = e.Graphics;

            board.draw(graphics);
        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            
            int x = e.X;
            int y = e.Y;
            //this.lGeneration.Text = $"X={x/10}, Y={y/10}";

            board.cells[(e.X) / 10, (e.Y) / 10].changeAlive();
            panelGraphics.Invalidate();
        }

        private void timerGeneration_Tick(object sender, EventArgs e)
        {
            createNewGeneration();
        }

        private void createNewGeneration()
        {
            board.CheckALive();
            this.lCountGeneration.Text = Convert.ToString(board.generation);
            panelGraphics.Invalidate();
        }
    }
}
