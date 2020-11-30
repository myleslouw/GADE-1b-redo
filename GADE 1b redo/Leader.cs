using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_1b_redo
{
    class Leader : Enemy
    {
        private Tile leaderTarget { get; set; }

        Leader()
        {

        }

        Leader(int leaderX, int leaderY)
        {
            X = leaderX;
            Y = leaderY;
            HP = 20;
            damage = 2;
        }
        public override movement ReturnMove(movement move = movement.NoMvm)
        {
            throw new NotImplementedException();
        }
    }
}
