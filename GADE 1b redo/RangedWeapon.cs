using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_1b_redo
{
    class RangedWeapon : Weapon
    {
        public enum Types { Rifle, LongBow }

        public override int Range
        {
            set { return base.Range}
        }
       
        public RangedWeapon(Types weaponType, int weaponPlaceX, int weaponPlaceY)
        {
            if (weaponType == Types.Rifle)
            {
                typeOfWeapon = "Rifle";
                durability = 3;
                Range = 3;
                damage = 5;
                cost = 7;
            }

            if (weaponType == Types.LongBow)
            {
                typeOfWeapon = "LongBow";
                durability = 4;
                Range = 2;
                damage = 4;
                cost = 6;
            }

        }

        
    }
}
