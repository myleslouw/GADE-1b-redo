using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_1b_redo
{
    class MeleeWeapon : Weapon
    {
        public enum Types { Dagger, Longsword }

        public override int Range
        {
            set { Range = value}
        }

        public MeleeWeapon(Types weaponType, int weaponPlaceX, int weaponPlaceY)
        {
            if (weaponType == Types.Dagger)
            {
                typeOfWeapon = "Dagger";
                durability = 10;
                damage = 3;
                cost = 3;
            }

            if (weaponType == Types.Longsword)
            {
                typeOfWeapon = "LongSword";
                durability = 6;
                damage = 4;
                cost = 5;
            }

        }
    }
}
