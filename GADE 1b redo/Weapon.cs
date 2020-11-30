using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_1b_redo
{
    abstract class Weapon : Item

    {
        protected int damage { get; set; }
        private int range;
        protected virtual int Range
        {
            get { return range; }
        }
        protected int durability;
        protected int cost;
        protected string typeOfWeapon;

        public Weapon(string weaponSymbol, int weaponX, int weaponY)
        {

        }


        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
