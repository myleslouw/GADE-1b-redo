using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GADE_1b_redo
{
    public class Map
    {
        //private Form1 frmGame = new Form1();
        private Tile[,] tileMapTiles;

        private static Hero myHero { get; set; }
        private static Goblin myGoblin { get; set; }
        private static Mage myMage { get; set; }

        private static int heroX;
        private static int heroY;
        private static int heroHP;

        private Enemy[] enemies;
        public int numEnemies;
        public int enemiesOnMap;
        public int mapHeight, mapWidth;
        public int inputMaxHeight, inputMinHeight, inputMaxWidth, inputMinWidth;
        public Random rndmNum = new Random();

        

        public string madeMap;

        Item[] mapItems; 


        public Map(int inputMaxHeight, int inputMaxWidth, int inputMinHeight, int inputMinWidth, int numEnemies = 0, int numOfGold = 0) //Enemies and gold are default valuies, i need to change this later to actual values or edit in code later
        {

            inputMaxHeight = Form1.MaxHeight;
            inputMaxWidth = Form1.MaxWidth;
            inputMinHeight = Form1.MinHeight;
            inputMinWidth = Form1.MinWidth;

            mapHeight = rndmNum.Next(inputMinHeight, inputMaxHeight);
            mapWidth = rndmNum.Next(inputMinWidth, inputMaxWidth);

            tileMapTiles = new Tile[mapHeight, mapWidth]; 

            enemies = new Enemy[GetNumEnemies()];  //values taken from getNumEnemies
            enemiesOnMap = enemies.Length;
            

            //UpdateVision   for character vision 
        }

        public Map()
        {

        }

        private int GetNumEnemies()
        {
            
            double rawNumEnemies;   //using "math" requires a double/float
           
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

            return numEnemies;  
        }

        public void Create(int unitX, int unitY, int unitDamage, int unitHP, int unitMaxHP, string symbol)
        {
            //Print a single unit with given parameters as the variables/info
            string goblinSymbol = "G"; // G goblin symbol
            string heroSymbol = "H"; // hero symbol
            string mageSymbol = "M";
            
            if (symbol == heroSymbol)
            {
                myHero = new Hero(unitX, unitY, unitDamage, unitHP, unitMaxHP, symbol);
            }
            else if (symbol == goblinSymbol)
            {
                myGoblin = new Goblin(unitX, unitY, unitDamage, unitHP, unitMaxHP, symbol);
            }
            else if (symbol == mageSymbol)
            {
                myMage = new Mage(unitX, unitY, unitDamage, unitHP, unitMaxHP, symbol);
            }
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

        //public Item GetItemAtPosition(int x, int y)   task 2 work
        //{

        //}
    }
}








