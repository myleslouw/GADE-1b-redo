using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_1b_redo
{ 
    abstract class Tile
    {
        protected string X;
        protected string Y;
        public enum TileType { Hero, Enemy, Gold};
        

    }

    class Obstacle : Tile
    {
        
    }

    class EmptyTile : Tile
    {

    }

    abstract class Character : Tile
    {
        protected int HP;
        protected int maxHP;
        protected int damage;
        protected Tile[] characterVision;
        public enum movement{NoMvm, Up, Down, Left, Right};



        public Character(string xPos, string yPos)
        {
            X = xPos;
            Y = yPos;

            
        }

        public virtual void Attack(Character target)
        {
            
        }

        public bool IsDead()
        {
            return false;
        }

        public virtual bool CheckRange(Character target)
        {
            return false;
        }

        //private int DistanceTo(target)
        //{

        //}

        public void Move(movement move)
        {

        }

        //public abstract movement ReturnMove(movement move = 0)
        //{

        //}
        //public abstract override string ToString()
        //{

        //}

    }

    

}
