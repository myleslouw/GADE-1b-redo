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
        public enum TileType { Hero, Enemy, Gold };


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
        public enum movement { NoMvm, Up, Down, Left, Right };

        protected string symbol;

        public Character()
        {
            //idk what this is for  it solved this error 
            //There is no argument given that corresponds to the required formal parameter 'xPos' of 'Character.Character(string, string, string)'
        }
        public Character(string xPos, string yPos, string _symbol)
        {
            X = xPos;
            Y = yPos;
            symbol = _symbol;


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

    abstract class Enemy : Character
    {
        protected int rndmNum;
        protected int enemyDamage { get; set; }  // is this correct inheritance
        protected int enemyHP { get; set; }
        protected int enemyMaxHP { get; set; }
        protected string enemySymbol { get; set; }


        public Enemy()
        {

        }
        public Enemy(string enemyX, string enemyY, string _enemySymbol)
        {
            X = enemyX;
            Y = enemyY;
            symbol = _enemySymbol;

        }
        public override string ToString()
        {
            return "EnemyClassName at [X, Y] (Amount DMG)";   //?????????
        }

    }

    class Goblin : Enemy
    {
        public Goblin(string goblinX, string goblinY, int goblinDamage, int goblinHP)
        {
            X = goblinX;
            Y = goblinY;
            goblinHP = 10;     // *******   have i misused inheritance 
        }

        //public override ReturnMove()
        //{
        //    return
        //}
    }

    class Hero : Character
    {
        public Hero()
        {

        }
        //public override ReturnMove()
        //{
        //    return
        //}
        public override string ToString()
        {
            return "Player Stats: \n HP: HP/MAX HP \n Damage: 2 \n at [X, Y]";   //?????????
        }

    }


}
