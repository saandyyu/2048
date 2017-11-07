using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* CIS 3309
  * PROJECT 3: GAME DESIGN
  * PHU LY AND SANDY YU
  * INSTRUCTOR: FRANK FRIEDMAN
  * */
namespace _2048
{
    class BoardClass
    {
        const int cols = 4;
        const int rows = 4;
        //private int Score;
        Random rand = new Random();
        //int BestScore;
        public Tile[,] board;
        
        //fill the board with 4 by 4 board, it create and instances of tile class
        public void fillBoard()
        {
            for(int i = 0; i < rows;i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    board[i, j] = new Tile();
                }//end of cols
            }//end of  rows
            addRandomTile();
            addRandomTile();
        }//end of fillBoard


        //constructor for the boardClass
        public BoardClass()
        {
            board = new Tile[rows, cols];
            fillBoard();

        }


        public void addRandomTile()
        {
            //Random rand = new Random();
            int row, colum;
            bool notValid = true;
            int value;
            while (notValid)
            {
                row = rand.Next(0, rows);               //generate random Cols and rows
                colum = rand.Next(0, rows);
                if (board[row, colum].getValue() == 0)
                {
                    value = rand.Next(10) < 9 ? 2 : 4;
                    board[row, colum].setValue(value);
                    notValid = false;
                }
            }
        }

        //Check to see if there are move available
        public void MoveAvailable()
        {
            bool empty = false;  
            for (int i = 0; i < rows; i++)//traverse through the 2D array.
            {
                for (int j = 0; j < cols; j++)
                {
                    //if a 0 is found in the 2D array, we can confirm that the board is indeed empty;
                    //so we set empty to true;
                    while (board[i, j].getValue() == 0 && !empty) 
                    {
                        empty = true; 
                    }
                }//end of cols
            }//end of  rows
            if (!empty) // display Message to let user know if the board is full;
            {
                MessageBox.Show("NO MORE MOVE AVAILABLE, GAME OVER", "GAME OVER");
                Application.Exit();
            }
        }
        //method to see if the game reach 2048, if its reach, end the game.
        public Boolean reach2048()
        {
            bool result = false;
            
            return result;
        } 

        public bool moveleftTile()
        {
            return false;
        }
        public bool moveRightTile()
        {
            return false;
        }
        public bool moveUpTile()
        {
            return false;
        }
        public bool moveDownTile()
        {
            return false;
        }

    }//end boardClass
}//end Namespace
