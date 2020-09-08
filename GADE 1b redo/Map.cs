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
        public char hero = 'H'; //A Hero object to represent the player character
        public char[] enemyPlacement;
        public int mapHeight, mapWidth;
        public Random rndmNum = new Random();




        public Map(int inputMinHeight, int inputMaxHeight, int inputMaxWidth, int inputMinWidth, int enemyCounter)
        {
            inputMaxHeight = int.Parse(Form1.MaxHeight);
            inputMinHeight = int.Parse(Form1.MinHeight);
            inputMaxWidth = int.Parse(Form1.MaxWidth);
            inputMinWidth = int.Parse(Form1.MinWidth);

            // enemyCounter =  ;



            mapHeight = rndmNum.Next(inputMaxHeight + inputMinHeight);
            mapWidth = rndmNum.Next(inputMaxWidth + inputMinWidth);

            mapTiles = new char[mapHeight, mapWidth];


            Create();

            //createse enemy array base on size?
            //create()  create enemy and pit them on a tile
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


    }







}
