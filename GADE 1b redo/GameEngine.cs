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
        //private Form1 frmGame = new Form1();

        private static Map myMap { get; set; }

        private int _mapMaxHeight;
        private int _mapMaxWidth;
        private int _mapMinHeight;
        private int _mapMinWidth;

        public string[,] MapArray { get; set; }


        private static readonly char heroChar = 'H';
        private static readonly char goblinChar = 'G';
        private static readonly char emptyChar = '.';
        private static readonly char obstacleChar = 'X';
        private static readonly char mageChar = 'M';


        public GameEngine()
        {

            myMap = new Map(Form1.MaxHeight, Form1.MaxWidth, Form1.MinHeight, Form1.MinHeight);

            MapArray = new string[myMap.mapHeight, myMap.mapWidth];



        }
        public bool MovePlayer(Character.movement direction)
        {


            return false;
        }

        public void CreateMapArrayMethod() 
        {
            
           myMap = new Map(Form1.MaxHeight, Form1.MaxWidth, Form1.MinHeight, Form1.MinHeight);
            MapArray = new string[myMap.mapHeight, myMap.mapWidth];

            for (int i = 0; i < myMap.mapHeight; i++)
            {
                for (int j = 0; j < myMap.mapWidth; j++)
                {
                    MapArray[i, j] = ".";
                }
            }
           



        }

        public override string ToString() //This needs to call your tile method
            //TODO : Use tile method and call that array instead of the MapArray to get the actual new values you have set to the tile.
        {
            string mapString = "";
            for (int i = 0; i < MapArray.Length; i++) 
            {
                for (int j = 0; j < MapArray.Length; j++)
                {
                    mapString += MapArray[i, j];
                }

            }
            return mapString;
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
