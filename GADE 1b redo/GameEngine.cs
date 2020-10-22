using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_1b_redo
{
    class GameEngine : Map
    {
        private Form1 frmGame = new Form1();

        private static Map myMap { get; set; }

        private int _mapMaxHeight;
        private int _mapMaxWidth;

        private string[,] mapArray = new string[myMap.mapHeight, myMap.mapWidth];



        private static readonly char heroChar = 'H';
        private static readonly char goblinChar = 'G';
        private static readonly char emptyChar = '.';
        private static readonly char obstacleChar = 'X';
        private static readonly char mageChar = 'M';


        public GameEngine()
        {
            myMap = new Map();


            myMap.inputMaxHeight = frmGame.MaxHeight;
            myMap.inputMaxWidth = frmGame.MaxWidth;
            myMap.inputMinHeight = frmGame.MinHeight;
            myMap.inputMinWidth = frmGame.MinWidth;

        }
        public bool MovePlayer(Character.movement direction)
        {
            return false;
        }

        public override string ToString()
        { 

            for (int i = 0; i < myMap.mapHeight; i++)
            {
                for (int j = 0; j < myMap.mapWidth; j++)
                {
                    mapArray[i,j] = ".";
                }
            }
            return null;

        }

        public string[,] MapArray
        {
            get { return mapArray; }
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
