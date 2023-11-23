using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        int playerChoise = 0;
        int computerChoise = 0;
        int statusGame = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private int generateChoise() 
        {
            Random ran = new Random();
            int genericInt = ran.Next(1,4);
            return genericInt;
        }

        private string selectWinner() 
        {
            string text = "";
            if (playerChoise == 1 && computerChoise == 2) 
            {
                picturePaint();
                text = "You won a game";
                computerChoise = 0;
            }
            if (playerChoise == 1 && computerChoise == 3)
            {
                picturePaint();
                text = "You loose";
                computerChoise = 0;
            }
            if (playerChoise == 2 && computerChoise == 1)
            {
                picturePaint();
                text = "You loose";
                computerChoise = 0;
            }
            if (playerChoise == 2 && computerChoise == 3)
            {
                picturePaint();
                text = "You won a game";
                computerChoise = 0;
            }
            if (playerChoise == 3 && computerChoise == 1)
            {
                picturePaint();
                text = "You won a game";
                computerChoise = 0;
            }
            if (playerChoise == 3 && computerChoise == 2)
            {
                picturePaint();
                text = "You loose";
                computerChoise = 0;
            }
            if (playerChoise == 1 && computerChoise == 1)
            {
                picturePaint();
                text = "A draw. Press start button for a new round";
                computerChoise = 0;
            }
            if (playerChoise == 2 && computerChoise == 2)
            {
                picturePaint();
                text = "A draw. Press start button for a new round";
                computerChoise = 0;
            }
            if (playerChoise == 3 && computerChoise == 3)
            {
                picturePaint();
                text = "A draw. Press start button for a new round";
                computerChoise = 0;
            }
            return text;
        }

        private void picturePaint()
        {
            if (computerChoise == 1)
            {
                using (Graphics g = this.CreateGraphics())
                {
                    g.DrawRectangle(new Pen(Color.Red, 6), pictureBox4.Bounds);
                }
            }
            else if (computerChoise == 2)
            {
                using (Graphics g = this.CreateGraphics())
                {
                    g.DrawRectangle(new Pen(Color.Red, 6), pictureBox5.Bounds);
                }
            }
            else if (computerChoise == 3) 
            {
                using (Graphics g = this.CreateGraphics())
                {
                    g.DrawRectangle(new Pen(Color.Red, 6), pictureBox6.Bounds);
                }
            }
            
        }

        private void clearComputerChoise() 
        {
            using (Graphics g = this.CreateGraphics())
            {
                g.DrawRectangle(new Pen(Color.White, 6), pictureBox4.Bounds);
            }
            using (Graphics g = this.CreateGraphics())
            {
                g.DrawRectangle(new Pen(Color.White, 6), pictureBox5.Bounds);
            }
            using (Graphics g = this.CreateGraphics())
            {
                g.DrawRectangle(new Pen(Color.White, 6), pictureBox6.Bounds);
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            clearComputerChoise();
            computerChoise = generateChoise();
            statusGame = 1;
            label1.Text = computerChoise.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (statusGame < 1) {
                MessageBox.Show("Please click 'start' button to begin a game");
                return;
            }
            playerChoise = 1;
            label1.Text = selectWinner();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (statusGame < 1)
            {
                MessageBox.Show("Please click 'start' button to begin a game");
                return;
            }
            playerChoise = 2;
            label1.Text = selectWinner();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (statusGame < 1)
            {
                MessageBox.Show("Please click 'start' button to begin a game");
                return;
            }
            playerChoise = 3;
            label1.Text = selectWinner();
        }
    }
}
