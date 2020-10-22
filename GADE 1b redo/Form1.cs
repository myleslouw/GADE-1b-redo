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
        

        public int MinHeight;
        public int MaxHeight;
        public int MaxWidth;
        public int MinWidth;

        public string gameText;

        
        
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
            ShowMap();

            
        }

        public void ShowMap()
        {
            //gameText = "testing";
            lbl_game.Text +=  gameText;
        }

        private void btn_Up_Click(object sender, EventArgs e)
        {
            
        }
    }
}
