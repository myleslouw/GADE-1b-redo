using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_1b_redo
{
    abstract class Tile
    {
        protected int X { get; set; }
        protected int Y { get; set; }
        public enum TileType { Hero, Enemy, Gold, Weapon, EmptyTile };

        public Tile(int x, int y)
        {
            X = x;
            Y = y;
        }

        protected Tile()
        {
        }
    }
}