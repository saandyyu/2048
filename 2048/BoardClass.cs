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

        Random rand = new Random();

        public Tile[,] board;
        //ScoreClass scores = new ScoreClass();
        private int addNumber = 2;
        private Boolean gameOver = false;
        private int newX, newY;

        public enum GameState
        {
            eGame,
            eAbout,
        };
        public enum Direction
        {
            eTOP,
            eBOTTOM,
            eLEFT,
            eRIGHT,
        };
        private GameState currentGameState = GameState.eGame;
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
            if (!empty) // display Message to let user know if the board is full with no possible merges 
            {
                MessageBox.Show("NO MORE MOVE AVAILABLE, GAME OVER", "GAME OVER");
                Application.Exit();
            }
        }

        //method to see if the player has reached a 2048 tile
        //if its reach, game is over 
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

        public void moveBoard(Direction moveDirection)
        {
            Boolean boardAdd = false;

            if (currentGameState == GameState.eAbout) currentGameState = GameState.eGame;

            switch (moveDirection)
            {
                //move all tiles up
                case Direction.eTOP:
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            for (int k = j + 1; k < 4; k++)
                            {
                                if (board[i, k].getValue() == 0)
                                {
                                    continue;
                                }
                                else if (board[i, k] == board[i, j])
                                {
                                   // board[i, j] = board[i, j] *2;
                                    //score += board[i, j];
                                    board[i, k].setValue(0);
                                    boardAdd = true;
                                    break;
                                }
                                else
                                {
                                    if (board[i, j].getValue() == 0 && board[i, k].getValue() != 0)
                                    {
                                        board[i, j] = board[i, k];
                                        board[i, k].setValue(0);
                                        j--;
                                        boardAdd = true;
                                        break;
                                    }
                                    else if (board[i, j].getValue() != 0)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    break;
                case Direction.eRIGHT:
                    for (int j = 0; j < 4; j++)
                    {
                        for (int i = 3; i >= 0; i--)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (board[k, j].getValue() == 0)
                                {
                                    continue;
                                }
                                else if (board[k, j] == board[i, j])
                                {
                                    //board[i, j] *= 2;
                                    //score += board[i,j];
                                    board[k, j].setValue(0);
                                    boardAdd = true;
                                    break;
                                }
                                else
                                {
                                    if (board[i, j].getValue() == 0 && board[k, j].getValue() != 0)
                                    {
                                        board[i, j] = board[k, j];
                                        board[k, j].setValue(0);
                                        i++;
                                        boardAdd = true;
                                        break;
                                    }
                                    else if (board[i, j].getValue() != 0)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    break;
                case Direction.eBOTTOM:
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 3; j >= 0; j--)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (board[i, k].getValue() == 0)
                                {
                                    continue;
                                }
                                else if (board[i, k] == board[i, j])
                                {
                                    //board[i, j].getValue() *= 2;
                                    //score += board[i,j];
                                    board[i, k].setValue(0);
                                    boardAdd = true;
                                    break;
                                }
                                else
                                {
                                    if (board[i, j].getValue() == 0 && board[i, k].getValue() != 0)
                                    {
                                        board[i, j] = board[i, k];
                                        board[i, k].setValue(0);
                                        j++;
                                        boardAdd = true;
                                        break;
                                    }
                                    else if (board[i, j].getValue() != 0)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    break;
                case Direction.eLEFT:
                    for (int j = 0; j < 4; j++)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            for (int k = i + 1; k < 4; k++)
                            {
                                if (board[k, j].getValue() == 0)
                                {
                                    continue;
                                }
                                else if (board[k, j] == board[i, j])
                                {
                                    //board[i, j] *= 2; 
                                    //score += board[i,j];
                                    board[k, j].setValue(0);
                                    boardAdd = true;
                                    break;
                                }
                                else
                                {
                                    if (board[i, j].getValue() == 0 && board[k, j].getValue() != 0)
                                    {
                                        board[i, j] = board[k, j];
                                        //board[k, j].setValue(0);
                                        i--;
                                        boardAdd = true;
                                        break;
                                    }
                                    else if (board[i, j].getValue() != 0)
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
                ++addNumber;
            }

        }
        public void Update()
        {
            while (!gameOver && addNumber > 0)
            {
                int nX = rand.Next(0, 4), nY = rand.Next(0, 4);

                if (board[nX,nY].getValue() == 0)
                {
                    //board[nX,nY].getValue() = rand.Next(0, 20) == 0 ? rand.Next(0, 15) == 0 ? 8 : 4 : 2;
                    newX = nX;
                    newY = nY;
                    --addNumber;
                }
            }
        }
    }//end boardClass
}//end Namespace

