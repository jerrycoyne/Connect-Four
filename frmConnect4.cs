/*Jerald Coyne-Ayanna Woodlin
 * Last Updated: 11/12/2018
 * CIS 3309
 * This class is the View class
 * that ties together our player
 * and board class
 */
using Connect4Markup.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Connect4Markup
{
    public partial class frmConnectFour : Form
    {
        public frmConnectFour()
        {
            InitializeComponent();
        }

        //class variables
        int playerID;
        int checkID;
        List<Player> players = new List<Player>(2);
        Player currentPlayer;
        Player player1;
        Player player2;
        Board gameBoard = new Board();
        Boolean winner = false;
        
        //Counters for decrementing up the column
        int rowMax0 = 4;
        int rowMax1 = 4;
        int rowMax2 = 4;
        int rowMax3 = 4;
        int rowMax4 = 4;
        int rowMax5 = 4;
        int rowMax6 = 4;
        public Button[,] newButtons;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Message box that shows immediately when the program runs. It is to give the player a better understadning
            //on how th game is supposed to be played. 
            MessageBox.Show("Welcome to the Game of Connect Four! To play, input Player 1's name and select OK. " +
                "Player 1'a tokens will be red. Player 2 must then input their name and select OK. Player 2's token will be blue. " +
                "Player 1 Will then select the column they wish to drop their token in. After Player 1 makes their selection, they must " +
                "select the Player Turn Complete button. After this player 2 Repeats the steps Player 1 performed. A winner is selected when " +
                "either Player 1 or Player 2 has a combination of 4 successive tokens in their color horizontally, diagnally, or vertically.");
        }

        //input player 1 name
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPlayer1.Text == "")
            {
                MessageBox.Show("Name cannot be blank");
                txtPlayer1.Focus();
            }
            else
            {
                playerID = 1;
                player1 = new Player(txtPlayer1.Text, playerID);
                txtPlayer2.ReadOnly = false;
                txtPlayer2.Enabled = true;
                btnOKP2.Enabled = true;

                players.Add(player1);
                currentPlayer = player1;
                txtPlayer2.Focus();
            }
        }

        //input player 2 name
        private void btnOKP2_Click(object sender, EventArgs e)
        {
            if (txtPlayer2.Text == "")
            {
                MessageBox.Show("Name cannot be blank");
                txtPlayer2.Focus();
            }
            else
            {
                playerID = 2;
                player2 = new Player(txtPlayer2.Text, playerID);
                players.Add(player2);
                createBoard();
                txtCurrentPlayer.Text = currentPlayer.getName();
            }
        }


        //creates the board after player 2 inputs name
        private void createBoard()
        {
            makeGameControlsVisible();
            int maxRows = gameBoard.getRows();
            int maxCols = gameBoard.getCols();
            newButtons = new Button[maxRows, maxCols];

            Size size = new Size(50, 50);
            Point loc = new Point(0, 0);
            int padding = 40;
            int topMargin = 70;

            for (int row = 0; row < maxRows; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);

                int extraLeftPadding = 10;

                for (int col = 0; col < maxCols; col++)
                {
                    newButtons[row, col] = new System.Windows.Forms.Button();
                    newButtons[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding), loc.Y);
                    newButtons[row, col].Size = size;
                    newButtons[row, col].Text = "";
                    newButtons[row, col].BackColor = Color.White;
                    newButtons[row, col].Enabled = false;
                    newButtons[row, col].Visible = true;
                    newButtons[row, col].Name = "btn" + row + col;
                    pnlBoard.Controls.Add(newButtons[row, col]);
                }
            }
        }  

        private void makeGameControlsVisible()
        {
            pnlBoard.Visible = true;
            lblPlayerTurn.Visible = true;
            txtCurrentPlayer.Visible = true;
            lblWinner.Visible = true;
            txtWinner.Visible = true;
            btnCompleteTurn.Visible = true;
            btnExit.Visible = true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*---------------------------------------------------------COLUMN BUTTONS---------------------------------------------*/
        //each column button has its own counter which is why these buttons aren't refactored into smaller code chunks.
        //We also moved the recording method of the turn from the "turn complete" button to the column button that was selected
        //because it was the simplest way to pass the location parameters to the method

        private void btnCol1_Click(object sender, EventArgs e)
        {
            disableColButtons();
            if(rowMax0 < 0)
            {
                MessageBox.Show("Column is full. Please select new column.");
                enableColButtons();
                
            }
            checkID = currentPlayer.getPlayerID();
            if (rowMax0 >= 0)
            {
                if (checkID == 1)
                {
                    newButtons[rowMax0, 0].BackColor = Color.Red;
                    gameBoard.recordMove(rowMax0,0,1);
                    rowMax0--;
                }
                if (checkID == 2)
                {
                    newButtons[rowMax0, 0].BackColor = Color.Blue;
                    gameBoard.recordMove(rowMax0, 0, 2);
                    rowMax0--;
                }
            }
        }

        private void btnCol2_Click(object sender, EventArgs e)
        {
            disableColButtons();
            if (rowMax1 < 0)
            {
                MessageBox.Show("Column is full. Please select new column.");
                enableColButtons();
            }

            checkID = currentPlayer.getPlayerID();
            if (rowMax1 >= 0)
            {
                if (checkID == 1)
                {
                    newButtons[rowMax1, 1].BackColor = Color.Red;
                    gameBoard.recordMove(rowMax1, 1, 1);
                    rowMax1--;
                }
                if (checkID == 2)
                {
                    newButtons[rowMax1, 1].BackColor = Color.Blue;
                    gameBoard.recordMove(rowMax1, 1, 2);
                    rowMax1--;
                }
            }

        }

        private void btnCol3_Click(object sender, EventArgs e)
        {
            disableColButtons();
            if (rowMax2 < 0)
            {
                MessageBox.Show("Column is full. Please select new column.");
                enableColButtons();
            }

            checkID = currentPlayer.getPlayerID();
            if (rowMax2 >= 0)
            {
                if (checkID == 1)
                {
                    newButtons[rowMax2, 2].BackColor = Color.Red;
                    gameBoard.recordMove(rowMax2, 2, 1);
                    rowMax2--;
                }
                if (checkID == 2)
                {
                    newButtons[rowMax2, 2].BackColor = Color.Blue;
                    gameBoard.recordMove(rowMax2, 2, 2);
                    rowMax2--;
                }
            }

        }

        private void btnCol4_Click(object sender, EventArgs e)
        {
            disableColButtons();
            if (rowMax3 < 0)
            {
                MessageBox.Show("Column is full. Please select new column.");
                enableColButtons();
            }

            checkID = currentPlayer.getPlayerID();
            if (rowMax3 >= 0)
            {
                if (checkID == 1)
                {
                    newButtons[rowMax3, 3].BackColor = Color.Red;
                    gameBoard.recordMove(rowMax3, 3, 1);
                    rowMax3--;
                }
                if (checkID == 2)
                {
                    newButtons[rowMax3, 3].BackColor = Color.Blue;
                    gameBoard.recordMove(rowMax3, 3, 2);
                    rowMax3--;
                }
            }

        }

        private void btnCol5_Click(object sender, EventArgs e)
        {
            disableColButtons();
            if (rowMax4 < 0)
            {
                MessageBox.Show("Column is full. Please select new column.");
                enableColButtons();
            }

            checkID = currentPlayer.getPlayerID();
            if (rowMax4 >= 0)
            {
                if (checkID == 1)
                {
                    newButtons[rowMax4, 4].BackColor = Color.Red;
                    gameBoard.recordMove(rowMax4, 4, 1);
                    rowMax4--;
                }
                if (checkID == 2)
                {
                    newButtons[rowMax4, 4].BackColor = Color.Blue;
                    gameBoard.recordMove(rowMax4, 4, 2);
                    rowMax4--;
                }
            }

        }

        private void btnCol6_Click(object sender, EventArgs e)
        {
            if (rowMax5 < 0)
            {
                MessageBox.Show("Column is full. Please select new column.");
                enableColButtons();
            }
            disableColButtons();

            checkID = currentPlayer.getPlayerID();
            if (rowMax5 >= 0)
            {
                if (checkID == 1)
                {
                    newButtons[rowMax5, 5].BackColor = Color.Red;
                    gameBoard.recordMove(rowMax5, 5, 1);
                    rowMax5--;
                }
                if (checkID == 2)
                {
                    newButtons[rowMax5, 5].BackColor = Color.Blue;
                    gameBoard.recordMove(rowMax5, 5, 2);
                    rowMax5--;
                }
            }

        }

        private void btnCol7_Click(object sender, EventArgs e)
        {
            disableColButtons();
            if (rowMax6 < 0)
            {
                MessageBox.Show("Column is full. Please select new column.");
                enableColButtons();
            }

            checkID = currentPlayer.getPlayerID();
            if (rowMax6 >= 0)
            {
                if (checkID == 1)
                {
                    newButtons[rowMax6, 6].BackColor = Color.Red;
                    gameBoard.recordMove(rowMax6, 6, 1);
                    rowMax6--;
                }
                if (checkID == 2)
                {
                    newButtons[rowMax6, 6].BackColor = Color.Blue;
                    gameBoard.recordMove(rowMax6, 6, 2);
                    rowMax6--;
                }
            }

        }

        /*------------------------------------------------------------------END BUTTON COLUMN BUTTONS ------------------------------------------------*/
        private void btnCompleteTurn_Click(object sender, EventArgs e)
        {
            winner = gameBoard.isAWinner();
            if (winner == true)
            {
                MessageBox.Show(currentPlayer.getName() + " Won! The Game is Over. Click Replay to start over.");
                txtWinner.Text = currentPlayer.getName();
                disableColButtons();
                btnCompleteTurn.Enabled = false;
            }
            else
            {
                if (checkID == 1)
                {
                    currentPlayer = player2;
                }
                if (checkID == 2)
                {
                    currentPlayer = player1;
                }

                txtCurrentPlayer.Text = currentPlayer.getName();
                enableColButtons();//put at end of method
            }
        }

        //refactored methods that disable and enable column buttons 
        private void disableColButtons()
        {
            btnCol1.Enabled = false;
            btnCol2.Enabled = false;
            btnCol3.Enabled = false;
            btnCol4.Enabled = false;
            btnCol5.Enabled = false;
            btnCol6.Enabled = false;
            btnCol7.Enabled = false;
        }

        private void enableColButtons()
        {
            btnCol1.Enabled = true;
            btnCol2.Enabled = true;
            btnCol3.Enabled = true;
            btnCol4.Enabled = true;
            btnCol5.Enabled = true;
            btnCol6.Enabled = true;
            btnCol7.Enabled = true;
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            while (Controls.Count > 0)
            {
                Controls[0].Dispose();
            }
            InitializeComponent();
        }
    }   
}
