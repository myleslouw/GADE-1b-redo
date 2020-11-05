using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_1b_redo
{
    abstract class Character : Tile
    {
        protected int HP;
        protected int maxHP;
        protected int damage;
        protected Tile[] characterVision;
        public enum movement { NoMvm, Up, Down, Left, Right };

        protected string symbol;

        

        public Character(int xPos, int yPos, string _symbol)
        {
            X = xPos;
            Y = yPos;
            symbol = _symbol;

        }
        protected Character()
        {

        }

        public virtual void Attack(Character target)
        {
            target.HP -= damage;


        }

        public bool IsDead()
        {
            return false;
        }

        public virtual bool CheckRange(Character target)
        {

            if (DistanceTo(target) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private int DistanceTo(Character target)
        {
            return 0;
        }

        public void Move(movement move)
        {
         
            switch (move)
            {
                case movement.Up:
                    //character moves up
                    //character = Y++;

                    //fetch position of character (x pos and Y pos)
                    //increase/decrease acordingly
                    
                    Y = Y++;        

                    break;
                case movement.Down:
                    //char moves down    

                    Y = Y--;

                    break;
                case movement.Left:
                    //moves left
                    //character = X--;

                    X = X--;

                    break;
                case movement.Right:
                    // right etc
                    //character = X++;

                    X = X++;
                    break;
                case movement.NoMvm:
                    //character.xPos = character.xPos;
                    //character.yPos = character.yPos

                    X = X;
                    Y = Y;

                    break;
            }


            //characterVision[0] =  Y + 1;


        }
        public abstract movement ReturnMove(movement move = 0);

        public abstract override string ToString();


        public void Pickup(Item i)
        {

        }

    }
}
