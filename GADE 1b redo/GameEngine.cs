using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_1b_redo
{
    class GameEngine 
    {
        private Map myMap;              //{ get; set; }
        private Form1 form;
        private char[,] mapTiles;
        private int mapHeight;
        private int mapWidth;

        public GameEngine()
        {
            //this.form = form;

            //mapTiles = new char[mapHeight, mapWidth];

            myMap = new Map()


            //foreach (Tile spots in myMap.mapTiles)
            //{
                
            //}
            int mapRows = mapTiles.GetLength(0);
            int mapCol = mapTiles.GetLength(1);


            for (int i = 0; i < mapRows; i++)
            {
                for (int j = 0; j < mapCol; j++)
                {

                }

            }
        }
    }
}
