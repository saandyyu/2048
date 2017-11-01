using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    //What is the purpose of the Tile Class? To keep track of the tiles
    public class Tile
    {
        private int value;
        private bool merged;
        
        //instanticate tile with a value of zero==empty
        public Tile()
        {
            this.value=0 ;
        }
        //instanticate tile with a value
        public Tile(int value)
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
        public bool sameTile(Tile tile)
        {
            return false;
        }

        public void merge(Tile tile)
        {
            this.setValue(value + tile.getValue());
        }

        public bool equals(Tile otherTile)
        {
            return otherTile.getValue() == this.getValue();
        }

        // * Set the value to zero. In other words, delete / empty the tile.
        // * 
        public void clear()
        {
            this.setValue(0);
        }

        //set the value to the class attributes
        public void setMerged( bool mergeValue)
        {
            this.merged = mergeValue;
        }
        


        public int mergeWith(Tile otherTile)
        {
            //do somthing
            return value;
        }
        public bool canMergeWith(Tile otherTile)
        {
            //return true or fals. It takes in abother tiles and check to see if the two tiles can be merge. 
            //if so merge it.
            return false;
        }

    }//end of tileClass
}//end of namespace
