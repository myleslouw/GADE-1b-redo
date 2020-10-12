using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_1b_redo
{
    class GameEngine 
    {
        private Map myMap { get; set; }
        private Form1 form;
        private char[,] mapTiles;
        private int _mapHeight;
        private int _mapWidth;

        private static readonly char heroChar = 'H';
        private static readonly char goblinChar = 'G';
        private static readonly char emptyChar = '.';
        private static readonly char obstacleChar = 'X';





        public GameEngine()
        {
            myMap = new Map();
            myMap.mapHeight = _mapHeight;
            myMap.mapWidth = _mapWidth;

        }
        public bool MovePlayer()
        {


            return false;
        }

        public void Save()
        {

        }

        public void Load()
        {

        }

    }
}
