using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PapirKamenŠkarje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Game igra = new Game();
        private void igrajButton_Click(object sender, EventArgs e)
        {
            int player = igra.Play();
            if (igra.Player1State == 0)
            {
                igralec1PictureBox.Image=Properties.Resources.paper; 
            }
            else if (igra.Player1State == 1)
            {
                igralec1PictureBox.Image = Properties.Resources.rock;
            }
            else
            {
                igralec1PictureBox.Image = Properties.Resources.scissors;
            }
            if (igra.Player2State == 0)
            {
                igralec2PictureBox.Image = Properties.Resources.paper;
            }
            else if (igra.Player2State == 1)
            {
                igralec2PictureBox.Image = Properties.Resources.rock;
            }
            else { igralec2PictureBox.Image = Properties.Resources.scissors; }

            if (player == 1) MessageBox.Show("Igralec 1 je zmagal!");
            else if (player == 2) MessageBox.Show("Igralec 2 je zmagal!");
            igralec1Label.Text = "Igralec 1: " + igra.Player1Score;
            igralec1highLabel.Text = "Igralec 1 Highscore: " + Game.Player1Highscore;
            igralec2Label.Text = "Igralec 2: " + igra.Player2Score;
            igralec2highLabel.Text = "Igralec 2: " + Game.Player2Highscore;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            igra.Player1Score = 0;
            igra.Player2Score = 0;
            igralec1Label.Text = "Igralec 1: " + igra.Player1Score;
            igralec2Label.Text = "Igralec 2: " + igra.Player2Score;
        }
    }
    public class HelperClass
    {
        public static Random rand = new Random();
        public HelperClass() { }
        public static int GetState()
        {
            return rand.Next(0, 3);
        }
    }
    public class Game
    {
        private int p1st, p2st;
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }
        public int Player1State { get { return p1st; } set { if (value >= 0 && value <= 2) p1st = value; } }
        public int Player2State { get { return p2st; } set { if (value >= 0 && value <= 2) p2st = value; } }
        public static int Player1Highscore { get; set; }
        public static int Player2Highscore { get; set; }
        public Game() { }
        public int Play()
        {
            int zmag;
            Player1State = HelperClass.GetState();
            Player2State = HelperClass.GetState();
            #region randState
            if (Player1State == Player2State)
            {
                zmag = 0;
            }
            else if(Player1State==0 && Player2State == 1)
            {
                zmag = 1;
                Player1Score++;
                if (Player1Score > Player1Highscore) Player1Highscore = Player1Score;
            }
            else if(Player2State == 0 && Player1State == 1)
            {
                zmag = 2;
                Player2Score++;
                if (Player2Score > Player2Highscore) Player2Highscore = Player2Score;
            }
            else if(Player1State==0 && Player2State == 2)
            {
                zmag = 2;
                Player2Score++;
                if (Player2Score > Player2Highscore) Player2Highscore = Player2Score;
            }
            else if(Player2State==0 && Player1State == 2)
            {
                zmag = 1;
                Player1Score++;
                if (Player1Score > Player1Highscore) Player1Highscore = Player1Score;
            }
            else if(Player1State==1 && Player2State == 2)
            {
                zmag = 1;
                Player1Score++;
                if (Player1Score > Player1Highscore) Player1Highscore = Player1Score;
            }
            else
            {
                zmag = 2;
                Player2Score++;
                if (Player2Score > Player2Highscore) Player2Highscore = Player2Score;
            }
#endregion
            
            
            return zmag;
        }
    }
}
