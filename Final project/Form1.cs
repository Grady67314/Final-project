using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project
{
    
    public partial class Form1 : Form
    {
        List<string> names = new List<string> { "Bartholemew Roosevelt the I", "Bartholemew Roosevelt the II", "Bartholemew Roosevelt the III", "Bartholemew Roosevelt the IV", "Bartholemew Roosevelt the V", "Bartholemew Roosevelt the VI", };
        Random randName = new Random();
        int gold = 1000;
        int morality = 0;
        string currentCharacter;
        int tally = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void keepButton_Click(object sender, EventArgs e)
        {
            morality -= 10;
            Display();
        }

        private void giveButton_Click(object sender, EventArgs e)
        {
            gold -= 100;
            morality += 10;
            Display();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Random randName = new Random();
            int character = randName.Next(0, 6);
            switch (character)
            {
                case 1:
                    pictureBox2.Visible = true;
                    break;
                case 2:
                    rockPaperScissors.Visible = true;
                    break; 

            }
            currentCharacter = names[character];
           
        }
        private void Display()
        {
            statLabel.Text = "Gold: " + gold + "\nMorality: " + morality;
        }     
        private void Check()
        {
            if (tally == 10) 
            {
                if (gold <= 0 & morality > 0)
                {
                    KindKing();
                }
            }
        }
        private void KindKing()
        {
            kindkingPictureBox.Visible = true;
        }

        private void rockButton_Click(object sender, EventArgs e)
        {

        }
    }
}
