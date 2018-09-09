using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    //calculates the places where the snake currently is
    class SnakeTheAnimal
    {
        private LinkedList<Limb> body;
        private int direction = 0;
        private int directionChange = 0;
        private LinkedList<Limb> newLimb;

        public SnakeTheAnimal()
        {
            newLimb = new LinkedList<Limb>();
            body = new LinkedList<Limb>();
            this.body.AddFirst(new Limb(new int[] { 380, 380 }));
            this.body.AddLast(new Limb(new int[] { 380, 360 }));
            this.body.AddLast(new Limb(new int[] { 380, 340 }));
            this.direction = -1;
        }

        //returns the whole Snake
        public LinkedList<Limb> getBody()
        {
            return this.body;
        }

        //last direction key press
        public void lastKey(int last)
        {
            this.directionChange = last;
        }
        
        //sets movement direction (0-3) of snake new
        private void setDirection(int newDirection)
        {
            direction += newDirection;
            if (direction == 4)
                direction = 0;
            if (direction == -1)
                direction = 3;
        }

        /* moves the snake by deleting the last bodypart and adding a new one in front
         *in case of the snake growing it does not remove the last bodypart
         */
        public void move()
        {
            //Checks wheter the snake has eaten something and will grow or not
            if (!newLimb.Any() || !newLimb.First().isSameAs(body.Last()))
                body.RemoveLast();
            else
            {
                newLimb.RemoveFirst();
            }

            //decides where the snake will be heading next and creates the head
            int[] currentHead = (int[])body.First().getPosition().Clone();
            this.setDirection(this.directionChange);
            this.directionChange = 0; 

            switch (direction)
            {
                case 0:
                    currentHead[0] += 20;
                    body.AddFirst(new Limb(currentHead));
                    break;
                case 1:
                    currentHead[1] -= 20;
                    body.AddFirst(new Limb(currentHead));
                    break;
                case 2:
                    currentHead[0] -= 20;
                    body.AddFirst(new Limb(currentHead));
                    break;
                case 3:
                    currentHead[1] += 20;
                    body.AddFirst(new Limb(currentHead));
                    break;

            }


        }

        public void eat(int[] food)
        {
            this.newLimb.AddLast(new Limb(food));
        }
    }
}
