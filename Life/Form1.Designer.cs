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
            this.bStart = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.lGeneration = new System.Windows.Forms.Label();
            this.lCountGeneration = new System.Windows.Forms.Label();
            this.bClear = new System.Windows.Forms.Button();
            this.Cell = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            board = new Board(70);
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(14, 37);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(95, 37);
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
            this.lGeneration.Location = new System.Drawing.Point(257, 40);
            this.lGeneration.Name = "lGeneration";
            this.lGeneration.Size = new System.Drawing.Size(83, 17);
            this.lGeneration.TabIndex = 2;
            this.lGeneration.Text = "Generation:";
            // 
            // lCountGeneration
            // 
            this.lCountGeneration.AutoSize = true;
            this.lCountGeneration.Location = new System.Drawing.Point(335, 41);
            this.lCountGeneration.Name = "lCountGeneration";
            this.lCountGeneration.Size = new System.Drawing.Size(16, 17);
            this.lCountGeneration.TabIndex = 3;
            this.lCountGeneration.Text = "0";
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(176, 37);
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
            this.Cell.Location = new System.Drawing.Point(414, 37);
            this.Cell.Name = "Cell";
            this.Cell.Size = new System.Drawing.Size(20, 20);
            this.Cell.TabIndex = 0;
            this.Cell.UseVisualStyleBackColor = false;
            this.Cell.Click += new System.EventHandler(this.Cell_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.bStart);
            this.panel.Controls.Add(this.Cell);
            this.panel.Controls.Add(this.bNext);
            this.panel.Controls.Add(this.lCountGeneration);
            this.panel.Controls.Add(this.bClear);
            this.panel.Controls.Add(this.lGeneration);
            board.AddToPanel(panel);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(722, 813);
            this.panel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 813);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Life";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Label lGeneration;
        private System.Windows.Forms.Label lCountGeneration;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button Cell;
        private Board board;

    }
}

