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
    //The purpose of the board class is to keep track of the board

    class BoardClass
    {
        //initializing attributes for this class
        const int cols = 4;
        const int rows = 4;
        Random rand = new Random();

        public Tile[,] board;
        //ScoreClass scores = new ScoreClass();
        int newScore = 0;
        private int addNumber = 2;
        private int newX, newY;

        public enum Direction
        {
            eTOP,
            eBOTTOM,
            eLEFT,
            eRIGHT,
        };
        //fill the board with 4 by 4 board with 0s, it creates and instances of tile class
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

        //Adds a random tile between 2 or 4 and randomly adds it to an empty space on the board 
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
        //by checking if the board is full with no tiles that are able to merge
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
             
            if (!empty) // display Message to let user know if the board is full with no possible merges 
            {
                MessageBox.Show("NO MORE MOVE AVAILABLE, GAME OVER", "GAME OVER");
                Application.Exit();
            }
        }

        //method to see if the player has reached a 2048 tile
        //returns true if 2048 tile is on the board 
        //returns false otherwise
        public Boolean reach2048()
        {
            bool result = false;
            for (int i = 0; i < rows; i++)//traverse through the 2D array.
            {
                for (int j = 0; j < cols; j++)
                {
                    //if 2048 is found in the 2D array
                    //we set result to true to indicate
                    //that a 2048 tile was reached  
                    while (board[i, j].getValue() == 2048)
                    {
                        result = true;
                    }
                    return result;
                }
            }
            return result;
        }
        //Checks to see if the game is over
        //returns true if the board is filled with no more moves are available and there are no merges to be done
        //returns false when the board is not filled or there are moves available and there are merges to be done
        public Boolean gameOver()
        {
            bool result = false;
            for (int i = 0; i < rows; i++)//traverse through the 2D array.
            {
                for (int j = 0; j < cols; j++)
                {
                    //if a 0 is found in the 2D array, we can confirm that the board is indeed empty;
                    //so we set empty to true;
                    while (board[i, j].getValue() == 0 && !result)
                    {
                        result = true;
                        return result;
                    }
                }//end of cols
            }//end of  rows
            return result;
        }

        //Moves all tiles in either direction (up,down,left,right) and merges the tiles if able to 
        public void moveBoard(Direction moveDirection)
        {
            if (gameOver() == false)
            {
                return;
            }
            Boolean boardAdd = false;
            int maxMergedValue = 2;
            switch (moveDirection)
            {
                //Moves all the tiles to the left of the board
                case Direction.eLEFT:
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            for (int k = j + 1; k < 4; k++)
                            {
                                if (board[i, k].isEmpty())
                                {
                                    continue;
                                }
                                else if (board[i, k].sameTile(board[i, j]))
                                {
                                    maxMergedValue = Math.Max(maxMergedValue, board[i, j].increase());
                                    board[i, k].removeTile();
                                    boardAdd = true;
                                    newScore += board[i, j].Value;
                                    break;
                                }
                                else
                                {
                                    if (board[i, j].isEmpty() && !board[i, k].isEmpty())
                                    {
                                        board[i, j].Value = board[i, k].Value;
                                        board[i, k].removeTile();
                                        j--;
                                        boardAdd = true;
                                        break;
                                    }
                                    else if (!board[i, j].isEmpty())
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    break;
                //Moves all the tiles to bottom of the board 
                case Direction.eBOTTOM:
                    for (int j = 0; j < 4; j++)
                    {
                        for (int i = 3; i >= 0; i--)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (board[k, j].isEmpty())
                                {
                                    continue;
                                }
                                else if (board[k, j].sameTile(board[i, j]))
                                {
                                    maxMergedValue = Math.Max(maxMergedValue, board[i, j].increase());
                                    newScore += board[i, j].Value;
                                    board[k, j].removeTile();
                                    boardAdd = true;
                                    break;
                                }
                                else
                                {
                                    if (board[i, j].isEmpty() && !board[k, j].isEmpty())
                                    {
                                        board[i, j].Value = board[k, j].Value;
                                        board[k, j].removeTile();
                                        i++;
                                        boardAdd = true;
                                        break;
                                    }
                                    else if (!board[i, j].isEmpty())
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    break;
                //Moves all the tiles to the right of the board 
                case Direction.eRIGHT:
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 3; j >= 0; j--)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (board[i, k].isEmpty())
                                {
                                    continue;
                                }
                                else if (board[i, k].sameTile(board[i, j]))
                                {
                                    maxMergedValue = Math.Max(maxMergedValue, board[i, j].increase());
                                    newScore += board[i, j].Value;
                                    board[i, k].removeTile();
                                    boardAdd = true;
                                    break;
                                }
                                else
                                {
                                    if (board[i, j].isEmpty() && !board[i, k].isEmpty())
                                    {
                                        board[i, j].Value = board[i, k].Value;
                                        board[i, k].removeTile();
                                        j++;
                                        boardAdd = true;
                                        break;
                                    }
                                    else if (!board[i, j].isEmpty())
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    break;
                //Moves all the of the tiles to the top of the board
                case Direction.eTOP:
                    for (int j = 0; j < 4; j++)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            for (int k = i + 1; k < 4; k++)
                            {
                                if (board[k, j].isEmpty())
                                {
                                    continue;
                                }
                                else if (board[k, j].sameTile(board[i, j]))
                                {
                                    maxMergedValue = Math.Max(maxMergedValue, board[i, j].increase());
                                    newScore += board[i, j].Value;
                                    board[k, j].removeTile();
                                    boardAdd = true;
                                    break;
                                }
                                else
                                {
                                    if (board[i, j].isEmpty() && !board[k, j].isEmpty())
                                    {

                                        board[i, j].Value = board[k, j].Value;
                                        board[k, j].removeTile();
                                        i--;
                                        boardAdd = true;
                                        break;
                                    }
                                    else if (!board[i, j].isEmpty())
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    break;
            }

            if (boardAdd)
            {
                this.addRandomTile();
            }
        }
        
        //updates the board whenever the player chooses a direction
        public void Update()
        {
            while (!gameOver() && addNumber > 0)
            {
                int nX = rand.Next(0, 4), nY = rand.Next(0, 4);

                if (board[nX,nY].Value == 0)
                {
                    board[nX,nY].Value = rand.Next(0, 20) == 0 ? rand.Next(0, 15) == 0 ? 8 : 4 : 2;
                    newX = nX;
                    newY = nY;
                    --addNumber;
                }
            }
        }
    }//end boardClass
}//end Namespace

