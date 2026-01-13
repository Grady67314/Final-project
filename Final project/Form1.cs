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
        public Form1()
        {
            InitializeComponent();
        }

        private void keepButton_Click(object sender, EventArgs e)
        {
            morality -= 10;
            display();
        }

        private void giveButton_Click(object sender, EventArgs e)
        {
            gold -= 100;
            morality += 10;
            display();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Random randName = new Random();
            int character = randName.Next(0, 6);
            switch (character)
            {
                
                
            }
            currentCharacter = names[character];
           
        }
        private void display()
        {
            statLabel.Text = "Gold: " + gold + "\nMorality: " + morality;
        }       
    }
}
