using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_1b_redo
{
    class Shop
    {
        Weapon[] weaponArray = new Weapon[3];
        Random random = new Random();
        Character buyerCharacter;

        public Shop(Character buyer)
        {
            RandomWeapon();

        }

        private Weapon RandomWeapon()
        {
            Weapon weapon;

            random.Next(RangedWeapon.Types);
            
            return weapon;
        }
        public bool CanBuy(int num)
        {
            

            return false;
        }
        public void Buy(int num)
        {
            buyerCharacter.Pickup();

            RandomWeapon();
        }
        public string DisplayWeapon()
        {

            return "Buy " + RangedWeapon.Types + "( " + cost + " )";
        }

    }
}
