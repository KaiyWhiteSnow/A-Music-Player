using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3PlayerV3
{
    public partial class Form1 : Form
    {
        //Creating player
        public System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        //Connection between code and visuals
        public Form1()
        {    
            InitializeComponent();
        }

        //songs 1-3
        private void button1_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\jarda\source\repos\MP3PlayerV3\musicBox\music\M1.wav";
            player.Play();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\jarda\source\repos\MP3PlayerV3\musicBox\music\M2.wav";
            player.Play();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\jarda\source\repos\MP3PlayerV3\musicBox\music\M3.wav";
            player.Play();
        }

        //stop button
        private void button4_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
    }  
}