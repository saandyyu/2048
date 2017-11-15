using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* CIS 3309
  * PROJECT 3: GAME DESIGN
  * PHU LY AND SANDY YU
  * INSTRUCTOR: FRANK FRIEDMAN
  * */

namespace _2048
{
    //The purpose of the tile class is to keep track of the value of the tiles
    public class Tile
    {
        private int value;
        private bool merged;
        
        //instantiate tile with a value of zero == empty
        public Tile()
        {
            this.value = 0 ;
        }
        //instantiate tile with a value
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
        //Takes another tile and compares them to see if they are the same
        //returns true if the value and another tile's value is the same, making the merging process easier
        //returns false if it is not the same tile 
        public bool sameTile(Tile tile)
        {
            if (value == tile.value)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            
            //return true or false. It takes in abother tiles and check to see if the two tiles can be merge. 
            //if so merge it.
            return false;
        }

        //getter and setter for value with no parameters
        public int Value
        {
            get { return this.value; }
            set { this.value = value;}
        }

        //Checks to see if value is 0 and returns boolean empty
        //returns true if it is 0, then the tile is considered to be empty 
        //returns false otherwise
        public Boolean isEmpty()
        {
            bool empty = false;
            if (value == 0)
            {
                empty = true;
            }
            return empty;
        }

        //returns int value after it was multiplied by 2
        public int increase()
        {
            value = value * 2 ;
            return value;
        }

        //returns int value when the value chnaged to 0 making the tile empty
        public int removeTile()
        {
            this.value = 0;
            return value;
        }
    }//end of tileClass
}//end of namespace
