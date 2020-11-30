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
    public partial class Form1 : Form
    {
        public static int MinHeight { get; set; }
        public static int MaxHeight { get; set; }
        public static int MaxWidth { get; set; }
        public static int MinWidth { get; set; }

        public string gameText;
        GameEngine engine = new GameEngine();
        //Map mapInstance = new Map();
        private static Map mapInstance { get; set; }

        public Random  rnd = new Random();
        
        
        public Form1()
        {
            InitializeComponent();
            
        }

        public void GetCoordinate()
        {
            MinHeight = Convert.ToInt32(txtbox_minHeight.Text);
            MaxHeight = Convert.ToInt32(txtbox_maxHeight.Text);
            MaxWidth = Convert.ToInt32(txtbox_maxWidth.Text);
            MinWidth = Convert.ToInt32(txtbox_minWidth.Text);
 
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            GetCoordinate();
            //Called gameengine to update maparray.
            engine.CreateMapArrayMethod();
            ShowMap();

            int mapHeight = rnd.Next(MinHeight, MaxHeight);
            int mapWidth = rnd.Next(MinWidth, MaxWidth);
            int enemies = mapInstance.enemiesOnMap;

            int spawnX = rnd.Next(1, mapHeight);
            int spawnY = rnd.Next(1, mapWidth);

            string goblinSymbol = "G"; // G goblin symbol
            string heroSymbol = "H"; // hero symbol
            string mageSymbol = "M";

            mapInstance.Create(spawnX, spawnY, 2, 20, 20, heroSymbol);       // we nned mapInstance to call create     

            int numGoblins = rnd.Next(1, enemies);                //<<<< gives an error   enemies isnt gettign a value.       
            int numMages = mapInstance.enemiesOnMap - numGoblins;

            for (int i = 0; i < numGoblins; i++)    //loops through enemy array and creates el goblinos
            {
                mapInstance.Create(spawnX, spawnY, 1, 10, 10, goblinSymbol);
            }

            for (int i = 0; i < numMages; i++)    //loops through enemy array and creates el goblinos
            {
                mapInstance.Create(spawnX, spawnY, 5, 5, 5, mageSymbol);
            }
            
        }

        public void ShowMap()
        {

            lbl_game.Text = "";
            createMap();

        }

        public void createMap()
        {
            //lbl_game.Text += engine.MapArray.ToString();
            //The above is the gist
            string MapText = engine.MapArray.ToString();   //change the hard coded 5 values



            engine.mapHeight = engine.MapArray.GetLength(0); //needed to loop through map values otherwise they are 0
            engine.mapWidth = engine.MapArray.GetLength(1);

            
            for (int i = 0; i < engine.mapHeight; i++) //Make this height of engine.MapArray    needs above code ^^ the get Length code
            {
                for (int j = 0; j < engine.mapWidth; j++) //Make this width engine.MapArray    //did that
                {
                    lbl_game.Text += engine.MapArray[i, j];
                }
                lbl_game.Text += "\n"; 
            }

        }

        private void btn_Up_Click(object sender, EventArgs e)
        {
            
        }
    }
}
