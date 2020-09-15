using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GADE_1b_redo;


namespace GADE_1b_redo
{
    public class Map
    {
        public char[,] mapTiles;
        private Tile[,] tileMapTiles;
        public char hero = 'H'; //A Hero object to represent the player character
        public char[] enemyPlacement;
        public int mapHeight, mapWidth;
        public Random rndmNum = new Random();

        private Form1 form;




        public Map(int inputMaxHeight, int inputMaxWidth, int inputMinHeight, int inputMinWidth)
        {


            inputMaxHeight = int.Parse(Form1.MaxHeight);
            inputMinHeight = int.Parse(Form1.MinHeight);
            inputMaxWidth = int.Parse(Form1.MaxWidth);
            inputMinWidth = int.Parse(Form1.MinWidth);

            // enemyCounter =  ;



            mapHeight = rndmNum.Next(inputMinHeight, inputMaxHeight);
            mapWidth = rndmNum.Next(inputMinWidth, inputMaxWidth);

            mapTiles = new char[mapWidth, mapHeight];
            tileMapTiles = new Tile[mapWidth, mapHeight];

            enemyPlacement = new char[(mapHeight + mapWidth) / 2];


            void Create()
            {

            }

            //createse enemy array base on size?
            //create()  create enemy and pit them on a tile
            //UpdateVision   for character vision 
        }

        private void Create()         // ******** private Tile create
        {




            int mapRows = mapTiles.GetLength(0);
            int mapCol = mapTiles.GetLength(1);
            for (int i = 0; i < mapRows; i++)
            {
                for (int j = 0; j < mapCol; j++)
                {

                }

            }
        }
        public void UpdateVision()
        {
            //Updates the vision array for each Character (the

            //hero and each enemy) by saving the character values of the map at the

            //north, south, east and west position from the X and Y positions of the unit
        }
    }
}








