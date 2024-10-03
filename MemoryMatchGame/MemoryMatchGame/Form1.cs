using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MemoryMatch
{
    public partial class Form1 : Form
    {
        private List<Button> cardButtons = new List<Button>();
        private List<string> cardTags = new List<string>();
        private Button? firstClicked; 
        private Button? secondClicked; 
        private int turns;
        private int totalMatches;
        private int player1Matches;
        private int player2Matches;
        private int currentPlayer; 
        private Image faceDownImage;

        public Form1()
        {
            InitializeComponent();
            LoadFaceDownImage(); 
            InitializeGame();
        }

        private void LoadFaceDownImage()
        {
            
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "facedown.jpg");

                faceDownImage = Image.FromFile(imagePath);

        }

        private void InitializeGame()
        {
            
            cardButtons = new List<Button>
            {
                btnCard1, btnCard2, btnCard3, btnCard4,
                btnCard5, btnCard6, btnCard7, btnCard8,
                btnCard9, btnCard10, btnCard11, btnCard12,
                btnCard13, btnCard14, btnCard15, btnCard16,
                btnCard17, btnCard18, btnCard19, btnCard20
            };

            // List of image names corresponding to the pairs of cards
            string[] images = { "pikachu", "pikachu", "meowth", "meowth",
                                "jigglypuff", "jigglypuff", "charmander", "charmander",
                                "bulbasaur", "bulbasaur", "squirtle", "squirtle",
                                "snorlax", "snorlax", "gengar", "gengar",
                                "eevee", "eevee", "swablu", "swablu" };

            Random random = new Random();
            cardTags = images.OrderBy(x => random.Next()).ToList();

            
            for (int i = 0; i < cardButtons.Count; i++)
            {
                Button button = cardButtons[i];
                button.Tag = cardTags[i];
                button.Click += Card_Click;
                button.BackgroundImage = faceDownImage; // Set initial face-down image
                button.BackgroundImageLayout = ImageLayout.Stretch;
                button.Enabled = true;
            }

            turns = 0;
            totalMatches = 0;
            player1Matches = 0;
            player2Matches = 0;
            currentPlayer = 1; // Start with Player 1
            lblScore.Text = "Turns: 0";
            lblTotalMatches1.Text = "Matches: 0"; 
            lblTotalMatches2.Text = "Matches: 0"; 
            lblcurPlayer.Text = "Player 1"; // Display current player
            lblcurPlayer.ForeColor = Color.Red; // Set text color to red for Player 1
            //lblEndGameMessage.Visible = false;
        }

        private void Card_Click(object? sender, EventArgs e)
        {
            if (firstClicked != null && secondClicked != null)
                return;

            Button? clickedButton = sender as Button;

            if (clickedButton == null || clickedButton.BackgroundImage != faceDownImage)
                return;

            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", $"{clickedButton.Tag}.png");

            // Load and display the image for the clicked card
                clickedButton.BackgroundImage = Image.FromFile(imagePath);


            if (firstClicked == null)
            {
                firstClicked = clickedButton; // Store first card clicked
                return;
            }

            secondClicked = clickedButton; // Store second card clicked
            turns++;
            lblScore.Text = $"Turns: {turns}";

            CheckForMatch();
        }

        private void CheckForMatch()
        {
            if (firstClicked == null || secondClicked == null) return;

            if (firstClicked.Tag.ToString() == secondClicked.Tag.ToString())
            {
                totalMatches++;

                
                if (currentPlayer == 1)
                {
                    player1Matches++;
                    lblTotalMatches1.Text = $"Matches: {player1Matches}";
                }
                else
                {
                    player2Matches++;
                    lblTotalMatches2.Text = $"Matches: {player2Matches}";
                }

                // Disable matched cards
                firstClicked.Enabled = false;
                secondClicked.Enabled = false;

                // Reset card selection
                ResetCardSelection();
                CheckForWin();
            }
            else
            {
                // Cards do not match; delay to show cards before resetting
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000; 
                timer.Tick += (s, e) =>
                {
                    firstClicked.BackgroundImage = faceDownImage; // Reset to face-down
                    secondClicked.BackgroundImage = faceDownImage; // Reset to face-down
                    ResetCardSelection();
                    SwitchPlayer(); // Switch players after a mismatch
                    timer.Stop();
                };
                timer.Start();
            }
        }

        private void ResetCardSelection()
        {
            firstClicked = null;
            secondClicked = null;
        }

        private void SwitchPlayer()
        {
            // Switch to the next player
            currentPlayer = (currentPlayer == 1) ? 2 : 1;
            lblcurPlayer.Text = $"Player {currentPlayer}";
            lblcurPlayer.ForeColor = currentPlayer == 1 ? Color.Red : Color.Orange; // Red for Player 1, Orange for Player 2
        }

        private void CheckForWin()
        {
            if (totalMatches == 10) 
            {
                string winner = player1Matches > player2Matches ? "Player 1" : "Player 2";
                MessageBox.Show($"{winner} wins! Total turns: {turns}", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //lblEndGameMessage.Text = $"{winner} wins! Total turns: {turns}";
                //lblEndGameMessage.Visible = true;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            InitializeGame(); // Restart the game
            //lblEndGameMessage.Visible = false; 
        }
    }
}

