using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_1b_redo
{
    class Goblin : Enemy
    {
        public Goblin(int goblinX, int goblinY, int gobDamage, int gobHP, int gobMaxHP, string _symbol )
        {
            X = goblinX;    
            Y = goblinY;
            enemyDamage = gobDamage;
            enemyHP = gobHP;
            enemyMaxHP = gobMaxHP;
            enemySymbol = _symbol;


            enemyHP = 10;
            enemyDamage = 1;
        }

        public movement ReturnMove()
        {
            rndnum.Next(0, 5);
            return movement.NoMvm;


        }

        public override movement ReturnMove(movement move = movement.NoMvm)
        {
            return 0; 
        }
    }
}
