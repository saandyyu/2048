using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            createBoard();
        }
        private const int maxRows = 4;
        private const int maxCols = 4;
        BoardClass boardRep = new BoardClass();
        private Label[,] newLabel = new Label[maxRows, maxCols];
        

        
     private void createBoard() { 
        
            pnlBoard.Visible = true;

            Size size = new Size(50, 50);
            Point loc = new Point(0, 0);
            int padding = 10;
            int topMargin = 70;

            // The board is treated like a maxRows x MaxCols array
            for (int row = 0; row < maxRows; row++)
            {
                // For each new row, insert at left the Row i Button
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 100;
                for (int col = 0; col < maxCols; col++)
                {
                    newLabel[row, col] = new System.Windows.Forms.Label();
                    newLabel[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding), loc.Y);
                    newLabel[row, col].Size = size;
                    newLabel[row, col].Text = "0";
                    newLabel[row, col].Enabled = false;
                    newLabel[row, col].Visible = true;
                    newLabel[row, col].BackColor = System.Drawing.SystemColors.ScrollBar;
                    newLabel[row, col].Name = "lbl" + row + col;
                    newLabel[row, col].Size = new System.Drawing.Size(55, 55);
                    newLabel[row, col].TextAlign = ContentAlignment.MiddleCenter;

                    pnlBoard.Controls.Add(newLabel[row, col]);
                } // end for col
            } // end for row
        } // end createBoard

        private void button5_Click(object sender, EventArgs e)
        {

        }



        private void btnQuit_Click(object sender, EventArgs e)

        {
            Application.Exit();
        }



    }
}
