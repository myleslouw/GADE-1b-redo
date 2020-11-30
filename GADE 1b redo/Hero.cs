using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_1b_redo
{
    class Hero : Character
    {
        public Hero(int heroX, int heroY, int dmg, int heroHP, int heroMaxHP, string _symbol)
        {
            X = heroX;    //X = heroX doesnt give an error     //doesnt fix errors in ToString doh. 
            Y = heroY;
            HP = heroHP;
            maxHP = heroHP;
            damage = 2;
            symbol = _symbol;
        }

        public override movement ReturnMove(movement move = movement.NoMvm)
        {
            //if ()
            //{
            //    move = movement.Up;
            //}

            return 0;
        }

        //public override ReturnMove()
        //{
        //    check characterVision
        //     if characterVIsion == true then move
        

        //    click up button->move = movement.Up
        //    click down button->move = movement.down    you get the point
        //    click up button->move = movement.Up
        //    click up button->move = movement.Up

        //    return movement.NoMvm;
        //}

        public override string ToString()
        {
            string heroInfo;

            heroInfo = "Player Stats: \n HP: " + HP + " / " + maxHP + "\n Damage: 2 \n [" + X + " , " + Y;
            return heroInfo;
        }
    }
}
