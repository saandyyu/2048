using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    //What is the purpose of the Tile Class? To keep track of the tiles
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

        public void merge(TileClass tile)
        {
            this.setValue(value + tile.getValue());
        }

        public bool equals(TileClass tile)
        {
            return tile.getValue() == this.getValue();
        }

        // * Set the value to zero. In other words, delete / empty the tile.
        // * 

        public void clear()
        {
            this.setValue(0);
        }

    }//end of tileClass
}//end of namespace
