using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    class BoardClass
    {
        const int Size = 4;
        int Score;
        int BestScore;
        int[,] Board;
        
        //constructor for the boardClass
        public BoardClass()
        {
            Board = new int[Size, Size];
        }

        //method to see if the game reach 2048, if its reach, end the game.
        public Boolean reach2048()
        {
            bool result = false;
            
            return result;
        } 
    }//end boardClass
}//end Namespace
