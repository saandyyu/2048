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
        private const int maxRows = 4; // Max Rows
        private const int maxCols = 4;// Max Collums
        BoardClass internalboardRep = new BoardClass(); // create the internalBoard Representation of the board.
        private Label[,] newLabel = new Label[maxRows, maxCols];
        
       
        //This method is a modified version from the NIM game, It basically generatate the label dynamicaly
        // and add the label to the panel in a 4X4 grid
     private void createBoard() { 
        
            pnlBoard.Visible = true;

            Size size = new Size(85, 85);
            Point loc = new Point(0, 0);
            int padding = 10;
            int topMargin = 10;

            // The board is treated like a maxRows x MaxCols array
            for (int row = 0; row < maxRows; row++)
            {
                // For each new row, insert at left the Row i label
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 12;
                for (int col = 0; col < maxCols; col++)
                {
                    newLabel[row, col] = new System.Windows.Forms.Label();
                    newLabel[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding), loc.Y);
                    newLabel[row, col].Size = size;
                    newLabel[row, col].Text = "";
                    newLabel[row, col].Enabled = false;
                    newLabel[row, col].Visible = true;
                    newLabel[row, col].BackColor = System.Drawing.SystemColors.ScrollBar;
                    newLabel[row, col].Name = "lbl" + row + col;
                    newLabel[row, col].Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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

        private void pnlBoard_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
