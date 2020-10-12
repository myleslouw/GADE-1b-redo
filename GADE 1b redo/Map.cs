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
        //public char[,] mapTiles;
        private Tile[,] tileMapTiles;
        private Hero myHero = new Hero(); //A Hero object to represent the player character
        private Enemy[] enemies;
        public int mapHeight, mapWidth;
        public Random rndmNum = new Random();


        public Map(int inputMaxHeight, int inputMaxWidth, int inputMinHeight, int inputMinWidth, int numEnemies)
        {

            mapHeight = rndmNum.Next(inputMinHeight, inputMaxHeight);
            mapWidth = rndmNum.Next(inputMinWidth, inputMaxWidth);


            tileMapTiles = new Tile[mapWidth, mapHeight];

            enemies = new Enemy[GetNumEnemies()];  //values taken from getNumEnemies

            
            int goblinX = rndmNum.Next(mapHeight, mapWidth);
            int goblinY = rndmNum.Next(mapHeight, mapWidth);
            string goblinSymbol = "G";  //golbin symbol
            string heroSymbol = "H"; // hero symbol

            string sGoblinX = Convert.ToString(goblinX);
            string sGoblinY = Convert.ToString(goblinY);

            for (int i = 0; i < enemies.Length; i++)    //loops through enemy array and creates a goblino
            {
                Create(sGoblinX, sGoblinY, 1, 10, 10, goblinSymbol);
            }
            Create(sGoblinX,sGoblinY, 2, 20 , 20, heroSymbol);    //creates a hero?
            

            //create()  create enemy and pit them on a tile (pre lessons)
            //UpdateVision   for character vision 
        }

        private int GetNumEnemies()
        {
            
            double rawNumEnemies;
            int numEnemies;
            if (mapHeight < 7)
            {
                rawNumEnemies = ((mapHeight * mapWidth) / 10);
                numEnemies = Convert.ToInt32(Math.Ceiling(rawNumEnemies));
            }

            else
            {
                rawNumEnemies = ((mapHeight * mapWidth) / 10);
                numEnemies = Convert.ToInt32(Math.Floor(rawNumEnemies));
            }

            if (mapWidth < 7)
            {
                rawNumEnemies = ((mapHeight * mapWidth) / 10);
                numEnemies = Convert.ToInt32(Math.Ceiling(rawNumEnemies));
            }
            else
            {
                rawNumEnemies = ((mapHeight * mapWidth) / 10);
                numEnemies = Convert.ToInt32(Math.Ceiling(rawNumEnemies));
            }

            return numEnemies;  //is this correct?
        }

        private void Create(string unitX, string unitY, int unitDamage, int unitHP, int unitMaxHP, string symbol)
        {
           //create instance of character (hero or enemy)
           //create instance of an object 
           


        }

        public void UpdateVision()
        {
            //Updates the vision array for each Character (the

            //hero and each enemy) by saving the character values of the map at the

            //north, south, east and west position from the X and Y positions of the unit
        }
        //private Tile Create()
        //{
        //    return 
        //}
        public Item GetItemAtPosition(int x, int y)
        {

        }
    }
}








