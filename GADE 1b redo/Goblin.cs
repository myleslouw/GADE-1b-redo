using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_1b_redo
{
    class Goblin : Enemy
    {
        public Goblin(string goblinX, string goblinY)
        {
            X = goblinX;    //should fix issues 
            Y = goblinY;

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
            throw new NotImplementedException();
        }
    }
}
