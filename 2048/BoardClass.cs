using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Phu Ly ,Sandy Yu
//Cis 3309
namespace _2048
{
    class BoardClass
    {
        const int cols = 4;
        const int rows = 4;
        private int Score;
        Random rand = new Random();
        //int BestScore;
        private Tile[,] board;
        //fillBoard();
        
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
        }//end of fillBoard


        //constructor for the boardClass
        public BoardClass()
        {
            board = new Tile[rows, cols];
            fillBoard();

        }


        public void addRandomTile()
        {
            Random rand = new Random();
        }

        public void MoveAvailable()
        {

        }
        //method to see if the game reach 2048, if its reach, end the game.
        public Boolean reach2048()
        {
            bool result = false;
            
            return result;
        } 

    }//end boardClass
}//end Namespace
