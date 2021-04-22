using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tictoc
{
    enum CurrentPlayer
    {
        Cross;
        Circle;
    }
    public partial class Form1 : Form
    {
        CurrentPlayer currentPlayer;
        public Form1()
        {
            InitializeComponent();
            currentPlayer = CurrentPlayer.Cross;
            changeLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Mark(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if(currentPlayer == CurrentPlayer.Cross)
            {
                senderButton.Text = "O";
                currentPlayer = CurrentPlayer.Circle;
            }
            else
            {
                senderButton.Text = "X";
                currentPlayer = CurrentPlayer.Cross;
            }
        }
        public void changeLabel()
        {
            if(currentPlayer == CurrentPlayer.Cross)
            {
                player.Text = "Krzyżyk";
            }
            else
            {
                player.Text = "Kółko";
            }
        }
    }
}
