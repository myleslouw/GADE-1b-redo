using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_1b_redo
{
    class Gold : Item
    {
        private int goldCount;
        private Random rndGold = new Random();
        
        public Gold(int goldX, int goldY) : base()
        {
            X = goldX;
            Y = goldY;

            goldCount = rndGold.Next(0, 6);   //it says between 1 and 5? not sure if this is correct 
        }

            
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
