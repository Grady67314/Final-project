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
        string currentCharacter;
        public Form1()
        {
            InitializeComponent();
        }

        private void keepButton_Click(object sender, EventArgs e)
        {

        }

        private void giveButton_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
    }
}
