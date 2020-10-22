using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_1b_redo
{
    abstract class Item : Tile
    {
        public Item(int itemX, int itemY)
        {
            X = itemX;
            Y = itemY;
        }

        protected Item()
        {   
        }

        public abstract override string ToString();
    }
} 
