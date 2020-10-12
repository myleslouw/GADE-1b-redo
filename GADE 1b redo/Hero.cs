using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_1b_redo
{
    class Hero : Character
    {
        public Hero(string heroX, string heroY, int heroHP)
        {
            xPos = heroX;    //X = heroX doesnt give an error     //doesnt fix errors in ToString doh. 
            yPos = heroY;
            HP = heroHP;
            maxHP = heroHP;
            damage = 2;
        }

        public override movement ReturnMove(movement move = movement.NoMvm)
        {
            throw new NotImplementedException();
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

            // do as previous to string but change the variables etc

            string heroInfo;
            
            heroInfo = "Player Stats: \n HP: " + heroHP + " / " + maxHP + "\n Damage: 2 \n [" + heroX + " , " + heroY;
            return heroInfo;
        }
    }
}
