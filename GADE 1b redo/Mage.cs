using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_1b_redo
{
    class Mage : Enemy
    {
        public Mage(int mageX, int mageY, int mageDmg, int mageHP, int mageMaxHP, string _symbol)
        {
            X = mageX;
            Y = mageY;
            enemyHP = 5;
            enemyMaxHP = 5;
            enemyDamage = 5;
            enemySymbol = _symbol;
        }

        public override movement ReturnMove(movement move = movement.NoMvm)
        {
            return 0;
        }
        public override bool CheckRange(Character target)
        {
            return base.CheckRange(target);
        }
    }
}
