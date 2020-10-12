using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_1b_redo
{
    abstract class Tile
    {
        protected string X { get; set; }
        protected string Y { get; set; }
        public enum TileType { Hero, Enemy, Gold, Weapon };

        public Tile(string x, string y)
        {
            X = x;
            Y = y;
        }

        protected Tile()
        {
        }
    }
}