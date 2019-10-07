using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brandon_Miranda_17610437_Assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int Timer = 0;
        


        private void btnStart_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            Timer = tmrGameTimer;

            engine.map.FillMap();
            if (btnPause.Text == "START")
            {
                btnPause.Text = "PAUSE";
            }

        }
         private void label1_Click(object sender, EventArgs e)
        {
            GameEngine engine = new GameEngine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btnPause.Text == "PAUSE")
            {
                btnPause.Text = "START";
                tmrGameTimer.Stop();
            }
            else if (btnPause.Text == "START")
            {
                btnPause.Text = "PAUSE";
                tmrGameTimer.Start();
            }
            // I feel asleep on my keyboard while working and lost huge portions of code not sure how but hey....
        }
        }    
    }
}

