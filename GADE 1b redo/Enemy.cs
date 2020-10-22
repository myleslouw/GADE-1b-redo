using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_1b_redo
{
    abstract class Enemy : Character
    {

        protected Random rndnum = new Random();
        protected int enemyDamage { get; set; }  
        protected int enemyHP { get; set; }
        protected int enemyMaxHP { get; set; }
        protected string enemySymbol { get; set; }


        public Enemy()
        {

        }

        public Enemy(int enemyX, int enemyY, string _enemySymbol, int _enemyDamage, int _enemyHP, int _enemyMaxHP)
        {
            X = enemyX;
            Y = enemyY;
            symbol = _enemySymbol;
            enemyDamage = _enemyDamage;
            enemyHP = _enemyHP;
            enemyMaxHP = _enemyMaxHP;

        }
        public override string ToString()
        {
            string enemyInfo;
            string className = "Enemy";
            enemyInfo = className + " at [" + X + ", " + Y + "] (" + enemyDamage + ")";
            return enemyInfo;

        }
    }
}
