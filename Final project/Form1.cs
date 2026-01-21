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
        int amountg = 0;
        int amountm = 0; 
        Boolean safe = false;
        Boolean attack = false;
        Boolean ganon = false;
        Boolean link = false;
        Boolean zelda = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void keepButton_Click(object sender, EventArgs e)
        {
            morality -= 10;
            textLabel.Text = "I see. I suppose we will go without";
            tally += 1;
            zelda = false;
            link = false;
            ganon = false;
            Display();

        }

        private void giveButton_Click(object sender, EventArgs e)
        {
            gold -= 100;
            morality += 10;
            textLabel.Text = "Thank you sire";            
            tally += 1;
            if (ganon == true)
            {
                attack = true;
                gold -= 500;

            }
            if (link == true )
            {
                safe = true;
            }
            zelda = false;
            link = false;
            ganon = false;
            if (name == 2)
            {
                gold -= amountg;
                morality += amountm;
            }
            else
            {
                gold -= 100;
                morality += 10;
                textLabel.Text = "Thank you sire";
            }
            Display();
        }        
        private void Form1_Load(object sender, EventArgs e)
        {
            currentCharacter = names[0];
            textLabel.Text = "I " + currentCharacter +  " ask for 100 gold to buy new crops for my farm to feed the kindom next year.";
        }
        private void Display()
        {
            statLabel.Text = "Gold: " + gold + "\nMorality: " + morality;
            switch (name)
            {
                case 0:
                    characterPictureBox.Visible = false;
                    rockPaperScissors.Visible = true;
                    textLabel.Text = "Our city is hosting a rock, paper, scissors tournament next week and we need 100 gold to rent the ";
                    name += 1;
                    break;
                case 1:
                    rockPaperScissors.Visible = false;
                    kindkingPictureBox.Visible = true;
                    textLabel.Text = "My kingdom is under attack and we need gold to fund our army. How much Gold can you give us? ";
                    addButton.Visible = true;
                    subtractButton.Visible = true; 
                    name += 1;
                    break;
                case 2:
                    kindkingPictureBox.Visible = false;
                    ganonPictureBox.Visible = true;
                    ganon = true;
                    textLabel.Text = "Give me 500 gold to help me destroy your kindom and I shall spare you.";
                    addButton.Visible = false;
                    subtractButton.Visible = false;
                    name += 1;
                    break;                
                case 3:
                    ganonPictureBox.Visible = false;
                    linkPictureBox.Visible = true;
                    link = true;
                    if (attack == true)
                    {
                        textLabel.Text = "Please sire I only need 100 gold to stop Ganon from invading";
                        name += 1;
                    }
                    else
                    {
                        textLabel.Text = "I only need 100 gold to defeat Ganon forever";
                    }
                    break;
                case 4:
                    linkPictureBox.Visible = false;
                    zeldaPictureBox.Visible = true;
                    zelda = true;
                    if (safe == true || attack == false)
                    {
                        textLabel.Text = "Please father I only need 500 gold to vanquish Ganon forever";
                    }

                    name += 1;
                    break;
                case 5:
                    Check();
                    break;
            }
        }     
        private void Check()
        {
           
            
                if (safe == true & attack == true)
                {
                     
                }
                else if (safe == true)
                {

                }
                else if (attack == true)
                {
                    
                }
                else if (morality <= 0)
                {

                }
                else if (morality >0 & gold > 0)
                {

                }
                else if (gold <= 0 & morality > 0)
                {
                    KindKing();
                }
            
        }
        private void KindKing()
        {
            kindkingPictureBox.Visible = true;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            if (amountg >=0 )
            {
                amountg -= 10;
                amountm = amountm / 2;
            }
            else 
            {

            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            amountg += 10;
            amountm += amountm;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
