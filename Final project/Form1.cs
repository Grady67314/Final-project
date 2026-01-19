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
        List<string> names = new List<string> { "Bob", "Jeff", "Jerry", "Bartholemew Roosevelt the IV", "Jimothy", "Timothy", };
        Random randName = new Random();
        int gold = 1000;
        int morality = 0;
        string currentCharacter;
        int tally = 0;
        int name = 0;
        int stepSize = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void keepButton_Click(object sender, EventArgs e)
        {
            morality -= 10;
            Display();
            outputLabel.Text = "I see. I suppose we will go without";
        }

        private void giveButton_Click(object sender, EventArgs e)
        {
            gold -= 100;
            morality += 10;
            outputLabel.Text = "Thank you sire";
            Display();
            
        }        
        private void Form1_Load(object sender, EventArgs e)
        {
            currentCharacter = names[0];
            outputLabel.Text = "I " + currentCharacter +  " ask for 100 gold to buy new crops for my farm to feed the kindom next year.";
        }
        private void Display()
        {
            statLabel.Text = "Gold: " + gold + "\nMorality: " + morality;
            switch (name)
            {
                case 0:
                    outputLabel.Text = "Our city is hosting a rock, paper, scissors tournament next week and we need 100 gold to rent the ";
                    name += 1;
                    break;
                case 1:
                    kindkingPictureBox.Visible = false;
                    outputLabel.Text = "My kingdom is under attack and we need gold to fund our army. How much Gold can you give us? ";                    
                    name += 1;
                    break;
                case 2:
                    name += 1;
                    break;
                case 3:
                    name += 1;
                    break;
                case 4:
                    name += 1;
                    break;
                case 5:
                    ganonPictureBox.Visible = true;
                    name += 1;
                    break;
                case 6:
                    linkPictureBox.Visible = true;
                    name += 1;
                    break;
                case 7:
                    zeldaPictureBox.Visible = true;
                    break;

            }
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

        private void subtractButton_Click(object sender, EventArgs e)
        {            
            gold -= 1; 
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
