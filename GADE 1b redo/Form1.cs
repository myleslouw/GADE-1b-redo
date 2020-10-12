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
    public partial class Form1 : Form
    {
        GameEngine engine;

        public static string MinHeight;
        public static string MaxHeight;
        public static string MaxWidth;
        public static string MinWidth;

        
        //Map instance = new Map(10,10,10,10,0); 
        public Form1()
        {
            InitializeComponent();
            engine = new GameEngine();
            
        }

        public void GetCoordinate()
        {
            MinHeight = txtbox_minHeight.Text;
            MaxHeight = txtbox_maxHeight.Text;
            MaxWidth = txtbox_maxWidth.Text;
            MinWidth = txtbox_minWidth.Text;
 
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            GetCoordinate();
            
        }

        public void showMap()
        {
            lbl_game.Text += "idk what to do";
        }
    
    }
}
