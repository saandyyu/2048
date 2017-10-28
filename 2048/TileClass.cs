using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    public class TileClass
    {
        private int value;
        
        //instanticate tile with a value of zero==empty
        public TileClass()
        {
            this.value=0 ;
        }
        //instanticate tile with a value
        public TileClass(int value)
        {
            this.value = value;
        }
        //set the value of the tile
        public void setValue(int value)
        {
            this.value = value;
        }
        //getter to get the value of the tile
        public int getValue()
        {
            return value;
        }

        //if tile equal to other tiles. Make it easier to merge.
        public bool sameTile(TileClass tile)
        {
            
            return false;
        }
    }
}
