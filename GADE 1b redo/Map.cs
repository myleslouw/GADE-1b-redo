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
        private Form1 frmGame = new Form1();
        private Tile[,] tileMapTiles;

        private static int heroX;
        private static int heroY;
        private static int heroHP;

        private Hero myHero = new Hero(heroX, heroY, heroHP); //A Hero object to represent the player character
        private Enemy[] enemies;
        public int mapHeight, mapWidth;
        public int inputMaxHeight, inputMinHeight, inputMaxWidth, inputMinWidth;
        public Random rndmNum = new Random();

        public string madeMap;

        Item[] mapItems; 


        public Map(int inputMaxHeight, int inputMaxWidth, int inputMinHeight, int inputMinWidth, int numEnemies, int mumOfGold)
        {


            mapHeight = rndmNum.Next(inputMinHeight, inputMaxHeight);
            mapWidth = rndmNum.Next(inputMinWidth, inputMaxWidth);


            tileMapTiles = new Tile[mapWidth, mapHeight];

            enemies = new Enemy[GetNumEnemies()];  //values taken from getNumEnemies

            
            int spawnX = rndmNum.Next(mapHeight, mapWidth);
            int spawnY = rndmNum.Next(mapHeight, mapWidth);
            string goblinSymbol = "G"; // G golbin symbol
            string heroSymbol = "H"; // hero symbol
            string mageSymbol = "M";

            string _spawnX = Convert.ToString(spawnX);
            string _spawnY = Convert.ToString(spawnY);

            Create(_spawnX,_spawnY, 2, 20 , 20, heroSymbol);    //creates a hero

            for (int i = 0; i < enemies.Length; i++)    //loops through enemy array and creates el goblinos
            {
                Create(_spawnX, _spawnY, 1, 10, 10, goblinSymbol);
            }
           

            Create(_spawnX, _spawnY, 5, 5, 5, mageSymbol); //creates mage    //task 2

            

            
            //UpdateVision   for character vision 
        }

        public Map()
        {
        }


        private int GetNumEnemies()
        {
            
            double rawNumEnemies;   //using "math" requires a double
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
        private Tile Create(Tile.TileType test)
        {
            

            return null;
        }

        //public Item GetItemAtPosition(int x, int y)
        //{

        //}
    }
}








