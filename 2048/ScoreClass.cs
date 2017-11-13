using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    class ScoreClass
    {
        int score;
        int bestScore;

        public int scoreCounter(int scoreNumber)
        {
            switch (scoreNumber)
            {
                case 0:
                    return 0;
                case 2:
                    return 4;
                case 4:
                    return 8;
                case 8:
                    return 16;
                case 16:
                    return 32;
                case 32:
                    return 64;
                case 64:
                    return 128;
                case 128:
                    return 256;
                case 256:
                    return 512;
                case 512:
                    return 1024;
                case 1024:
                    return 2048;
                //case 2048:
                //    return 16;
                //case 4096:
                //case 8192:
                //case 16384:
            }

            return 0;
        }

        public int getScore()
        {
            return score;
        }
        public void setScore(int score)
        {
            this.score = score; 
        }
    }//end of class
}//end of namespace
