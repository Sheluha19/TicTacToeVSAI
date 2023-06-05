using System.ComponentModel;

namespace _123
{
    public partial class Form1 : Form
    {

        bool turn = false;
        int turn_count = 0;

        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!turn)
            {
                turn = true;
                BotMove();
                
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Ekaterina S122G", "Tic Tac Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        bool versusBot = true;
        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "X";
            b.Enabled = false;
            turn_count++;

            if (turn_count == 9)
            {
                MessageBox.Show("Draw!", "Bummer!");
            }
            else
            {
                System.Threading.Thread.Sleep(1000);
                BotMove();
                checkForWinner();
            }

        }


        private void checkForWinner()
        {
            bool there_is_a_winner = false;
            string winner = "";

            if ((button1.Text == button2.Text && button2.Text == button3.Text && !button1.Enabled) ||
                (button4.Text == button5.Text && button5.Text == button8.Text && !button4.Enabled) ||
                (button6.Text == button7.Text && button7.Text == button9.Text && !button6.Enabled) ||
                (button1.Text == button4.Text && button4.Text == button6.Text && !button1.Enabled) ||
                (button2.Text == button5.Text && button5.Text == button7.Text && !button2.Enabled) ||
                (button3.Text == button8.Text && button8.Text == button9.Text && !button3.Enabled) ||
                (button1.Text == button5.Text && button5.Text == button9.Text && !button1.Enabled) ||
                (button3.Text == button5.Text && button5.Text == button6.Text && !button3.Enabled))
            {
                there_is_a_winner = true;
                if (turn)
                    winner = "X";
                else
                    winner = "O";
            }

            if (there_is_a_winner)
            {
                disableButtons();
                MessageBox.Show(winner + " Wins!", "Yay!");
            }
            else if (turn_count == 9)
            {
                MessageBox.Show("Draw!", "Bummer!");
            }
        }


        private void disableButtons()
        {
            foreach (Control c in Controls)
            {
                if (c is Button b)
                {
                    b.Enabled = false;
                }
            }
        }


        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void RestartGame()
        {
            turn = false;
            turn_count = 0;

            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = true;
                    button.Text = "";
                }
            }

            if (!turn)
            {
                BotMove();
                turn = true;
            }
        }

        private async void BotMove()
        {
            await Task.Delay(1000);
            List<Button> availableButtons = new List<Button>();

            foreach (Control c in Controls)
            {
                if (c is Button && c.Enabled)
                    availableButtons.Add((Button)c);
            }

            if (availableButtons.Count == 0)
            {
                MessageBox.Show("Draw!", "Bummer!");
                return;
            }

            bool hasPlayerWinningMove = false;
            Button playerWinningMoveButton = null;

            foreach (Button button in availableButtons)
            {
                button.Text = "X";
                if (CheckIfWinningMove("X"))
                {
                    hasPlayerWinningMove = true;
                    playerWinningMoveButton = button;
                    break;
                }
                else
                {
                    button.Text = "";
                }
            }

            if (hasPlayerWinningMove)
            {
                playerWinningMoveButton.Text = "O";
                playerWinningMoveButton.Enabled = false;
                turn_count++;
                checkForWinner();
                return;
            }

            bool hasBotWinningMove = false;
            Button botWinningMoveButton = null;

            foreach (Button button in availableButtons)
            {
                button.Text = "O";
                if (CheckIfWinningMove("O"))
                {
                    hasBotWinningMove = true;
                    botWinningMoveButton = button;
                    break;
                }
                else
                {
                    button.Text = "";
                }
            }

            if (hasBotWinningMove)
            {
                botWinningMoveButton.Text = "O";
                botWinningMoveButton.Enabled = false;
                turn_count++;
                checkForWinner();
                return;
            }

            int index = random.Next(availableButtons.Count);
            Button randomButton = availableButtons[index];
            randomButton.Text = "O";
            randomButton.Enabled = false;
            turn_count++;

            checkForWinner();

            if (turn_count == 9)
            {
                MessageBox.Show("Draw!", "Bummer!");
            }
        }

        private bool CheckIfWinningMove(string symbol)
        {

            if ((button1.Text == symbol && button2.Text == symbol && button3.Text == symbol && (!button1.Enabled || !button2.Enabled || !button3.Enabled)) ||
                (button4.Text == symbol && button5.Text == symbol && button8.Text == symbol && (!button4.Enabled || !button5.Enabled || !button8.Enabled)) ||
                (button6.Text == symbol && button7.Text == symbol && button9.Text == symbol && (!button6.Enabled || !button7.Enabled || !button9.Enabled)) ||
                (button1.Text == symbol && button4.Text == symbol && button6.Text == symbol && (!button1.Enabled || !button4.Enabled || !button6.Enabled)) ||
                (button2.Text == symbol && button5.Text == symbol && button7.Text == symbol && (!button2.Enabled || !button5.Enabled || !button7.Enabled)) ||
                (button3.Text == symbol && button8.Text == symbol && button9.Text == symbol && (!button3.Enabled || !button8.Enabled || !button9.Enabled)) ||
                (button1.Text == symbol && button5.Text == symbol && button9.Text == symbol && (!button1.Enabled || !button5.Enabled || !button9.Enabled)) ||
                (button3.Text == symbol && button5.Text == symbol && button6.Text == symbol && (!button3.Enabled || !button5.Enabled || !button6.Enabled)))
            {
                return true;
            }
            return false;



        }

    }

}

