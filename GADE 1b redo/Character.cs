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

        public Character(string xPos, string yPos, string _symbol)
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
            //target.HP -= damage;
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
            if (move == movement.Up)    ///use the pos variables
            {
                //character moves up
                //character = Y++;
                

            }
            else if (move == movement.Down)
            {
                //char moves down    
                //change to case thingys
                //character = Y--
            }
            else if (move == movement.Left)
            {
                //moves left
                //character = X--
            }
            else if (move == movement.Right)
            {
                // right etc
                //character = X++
            }
            else if (move == movement.NoMvm)
            {
                //doesnt move duh
                //character.xPos = character.xPos
                //character.yPos = character.yPos
            }

        }
        public abstract movement ReturnMove(movement move = 0);

        public abstract override string ToString();
    }
}
