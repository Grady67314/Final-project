using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Final_project
{
    
    public partial class Form1 : Form
    {
        //array for names
        List<string> names = new List<string> { "Bob", "Jeff", "Jerry", "Jimothy", "Timothy" };
        //global variables
        Random randName = new Random();
        //these two determine the end status
        int gold = 1000;
        int morality = 0;
        //
        int name = 0;
        int stepSize = 30;
        int amountg = 100;
        int amountm = 1; 
        //these two help for the end check
        Boolean safe = false;
        Boolean attack = false;
        //
        Boolean ganon = false;
        Boolean link = false;
        Boolean zelda = false;
        //for drawing and moving the black rectangle
        SolidBrush fillBrush = new SolidBrush(Color.Black);
        Pen drawPen = new Pen(Color.Black, 10);
        int x = 600;
        int y = 0;
        int height = 40;
        int width = 40;
       


        public Form1()
        {
            InitializeComponent();
        }

        private void keepButton_Click(object sender, EventArgs e)
        {
            morality -= 10;
            textLabel.Text = "I see. I suppose we will go without";
            //it is better to keep gold from ganon so you gain morality
            if (ganon == true)
            {
                morality += 50;
            }
            zelda = false;
            link = false;
            ganon = false;
            Display();
            Invalidate();
            
            
        }

        private void giveButton_Click(object sender, EventArgs e)
        {
            gold -= 100;
            morality += 10;          
           //if link ganon or zelda are asking it changes the morality you gain and the money you lose
            if (ganon == true)
            {
                attack = true;
                gold -= 400;
                morality -= 100;

            }
            if (link == true )
            {
                safe = true;
            }
            if (zelda == true)
            {
                gold -= 400;
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
                
            }
            textLabel.Text = "Thank you sire";
            Display();
            Invalidate();
        }        
        private void Form1_Load(object sender, EventArgs e)
        {
            //decides what tyhe first persons name is
            int newName = randName.Next(0, 5);
            string currentCharacter = names[newName];
            textLabel.Text = "I " + currentCharacter +  " ask for 100 gold to buy new crops for my farm to feed the kindom next year.";
            
        }
        private void Display()
        {
            //displays the new amounts of morality and gold
            statLabel.Text = "Gold: " + gold + "\nMorality: " + morality;
            //makes the black rectangle move across the screen
            //idea was to cover up the textbox and picturebox and switch the text and character then to create a smooth transition
            while (x >= -100)
            {
               x = x - stepSize;
                Thread.Sleep(1);
               Refresh();

                
                if (x == 390)
                {
                    switch (name)
                    {
                        //switches to the second character
                        case 0:
                            textLabel.Text = "Our city is hosting a rock, paper, scissors tournament next week and we need 100 gold to rent the building.";
                            //changes which picture box is showing
                            characterPictureBox.Visible = false;
                            rockPaperScissors.Visible = true;
                            //this will make it so that the next display will be different
                            name += 1;
                            break;
                        case 1:
                            rockPaperScissors.Visible = false;
                            kindkingPictureBox.Visible = true;
                            textLabel.Text = "My kingdom is under attack and we ned gold to fund our army. How much Gold can you give us? ";
                            outputLabel.Visible = true;
                            outputLabel.Text = "Gold - " + amountg + "\nMorality + " + amountm;

                            addButton.Visible = true;
                            subtractButton.Visible = true;
                            //this will make it so that the next display will be different
                            name += 1;
                            
                            break;
                        case 2:
                            kindkingPictureBox.Visible = false;
                            ganonPictureBox.Visible = true;
                            ganon = true;
                            textLabel.Text = "Give me 500 gold to help me destroy your kindom and I shall spare you.";
                            addButton.Visible = false;
                            subtractButton.Visible = false;
                            //this will make it so that the next display will be different
                            name += 1;
                            break;
                        case 3:
                            outputLabel.Visible = false;
                            ganonPictureBox.Visible = false;
                            linkPictureBox.Visible = true;
                            link = true;
                            if (attack == true)
                            {
                                textLabel.Text = "Please sire I only need 100 gold to stop Ganon from invading.";
                                
                                
                            }
                            else
                            {
                                textLabel.Text = "I only need 100 gold to defeat Ganon forever";
                            }
                            //this will make it so that the next display will be different
                            name += 1;
                            break;
                        case 4:
                            if (safe == true && attack == true)
                            {
                                linkPictureBox.Visible = false;
                                zeldaPictureBox.Visible = true;
                                zelda = true;
                                textLabel.Text = "Please father I only need 500 gold to vanquish Ganon forever";

                            }
                            else if ( attack == true && safe != true)
                            {
                                linkPictureBox.Visible = false;
                                zeldaPictureBox.Visible = true;
                                zelda = true;
                                outputLabel.Text = " Please father I need 500 gold to stop Ganon from destroying our kingdom";
                            }
                            else
                            {
                                Check();
                            }
                            //this will make it so that the next display will be different
                            name += 1;
                            break;
                        case 5:
                            Check();
                            break;
                    }
                }
            }
           
            x = 600;
       }
        private void Check()
        {
            //stops user from interacting after the game is done
            giveButton.Visible = false;
            keepButton.Visible = false;
            //decides the ending based offf of your gold and decisions around ganons attack
            kindkingPictureBox.Visible = true;
            if (safe == true & attack == true)
            {
                outputLabel.Text = "You stopped the attack that you caused and you have no money for repairs.";
            }
            else if (safe == true)
            {
                textLabel.Text = "You did a good job stopping ganon and not giving in to him. Great job";
            }
            else if (attack == true)
            {
                textLabel.Text = "ganon destroyed your kingdom and you are to blame. Nobody likes you now";
            }
            else if (morality <= 0 && gold < 0 )
            {
               textLabel.Text = "You were a bad person and didn't know how to handle your money. Overall you were a huge failure.";
            }
            else if (morality >0 & gold > 0)
            {
                textLabel.Text = "You were a good king who was able to balance kindness and money. Great job!";
            }
            else if (gold <= 0 & morality > 0)
            {
                textLabel.Text = "You were a good king who chose kindness over money. You may be in debt but there are people who would be happy to help you get back on your feet.";
            }
            
        }
        

        private void subtractButton_Click(object sender, EventArgs e)
        {
            //lowers the amount of gold you will give to save the other kingdom 
            if (amountg > 1 )
            {
                amountg -= 10;
                amountm = amountm / 2;
                outputLabel.Text = "Gold - " + amountg + "\nMorality + " + amountm;
            }
            //stopes them from giving less than zero gold
            else 
            {

            }
        }
        
        private void addButton_Click(object sender, EventArgs e)
        {
            //raises the amount of gold you will give to save the other kingdom 
            amountg += 100;
            amountm += 10;
            outputLabel.Text = "Gold - " + amountg + "\nMorality + " + amountm;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawRectangle(drawPen, x, y, 300, 391);
            g.FillRectangle(fillBrush, x, y, 300, 391);

        }
    }
}
