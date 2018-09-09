using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Limb
    {
        //an array of size 2 to represent one bodypart of the snake
        int[] position = new int[2];

        //initialize Limb
        public Limb(int[] position)
        {
            this.position = position;
        }

        //new position for Limb
        public void setPosition(int[] newPosition)
        {
            this.position = newPosition;
        }

        //Returns the current Position of Limb
        public int[] getPosition()
        {
            return this.position;
        }

        public Boolean isSameAs(Limb other)
        {
            int[] otherPos = other.getPosition();
            if (this.position[0] == otherPos[0] && this.position[1] == otherPos[1])
                return true;
            return false;
        }
    }
}
