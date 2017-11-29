using Life.Model;
using System.Collections.Generic;

namespace Life
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bStart = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.lGeneration = new System.Windows.Forms.Label();
            this.lCountGeneration = new System.Windows.Forms.Label();
            this.bClear = new System.Windows.Forms.Button();
            this.Cell = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelGraphics = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.timerGeneration = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(15, 15);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(95, 15);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(75, 23);
            this.bNext.TabIndex = 1;
            this.bNext.Text = "Next";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // lGeneration
            // 
            this.lGeneration.AutoSize = true;
            this.lGeneration.Location = new System.Drawing.Point(257, 20);
            this.lGeneration.Name = "lGeneration";
            this.lGeneration.Size = new System.Drawing.Size(83, 17);
            this.lGeneration.TabIndex = 2;
            this.lGeneration.Text = "Generation:";
            // 
            // lCountGeneration
            // 
            this.lCountGeneration.AutoSize = true;
            this.lCountGeneration.Location = new System.Drawing.Point(346, 21);
            this.lCountGeneration.Name = "lCountGeneration";
            this.lCountGeneration.Size = new System.Drawing.Size(16, 17);
            this.lCountGeneration.TabIndex = 3;
            this.lCountGeneration.Text = "0";
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(176, 15);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 4;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // Cell
            // 
            this.Cell.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cell.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Cell.Location = new System.Drawing.Point(410, 18);
            this.Cell.Name = "Cell";
            this.Cell.Size = new System.Drawing.Size(20, 20);
            this.Cell.TabIndex = 0;
            this.Cell.UseVisualStyleBackColor = false;
            this.Cell.Click += new System.EventHandler(this.Cell_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.bStart);
            this.panelMain.Controls.Add(this.Cell);
            this.panelMain.Controls.Add(this.bNext);
            this.panelMain.Controls.Add(this.lCountGeneration);
            this.panelMain.Controls.Add(this.bClear);
            this.panelMain.Controls.Add(this.lGeneration);
            this.panelMain.Location = new System.Drawing.Point(3, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(716, 44);
            this.panelMain.TabIndex = 7;
            // 
            // panelGraphics
            // 
            this.panelGraphics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraphics.Location = new System.Drawing.Point(3, 53);
            this.panelGraphics.Name = "panelGraphics";
            this.panelGraphics.Size = new System.Drawing.Size(716, 677);
            this.panelGraphics.TabIndex = 5;
            this.panelGraphics.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panelGraphics.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.panelGraphics, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.panelMain, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(722, 733);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // timerGeneration
            // 
            this.timerGeneration.Interval = 500;
            this.timerGeneration.Tick += new System.EventHandler(this.timerGeneration_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 733);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Life";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Label lGeneration;
        private System.Windows.Forms.Label lCountGeneration;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button Cell;
        private System.Windows.Forms.Panel panelGraphics;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        Board board = new Board(53);
        private System.Windows.Forms.Timer timerGeneration;
    }
}

