﻿using System;
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
            
            int mapRows = mapTiles.GetLength(0);
            int mapCol = mapTiles.GetLength(1);


            for (int i = 0; i < mapRows; i++)
            {
                for (int j = 0; j < mapCol; j++)
                {
                    
                }

            }
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
