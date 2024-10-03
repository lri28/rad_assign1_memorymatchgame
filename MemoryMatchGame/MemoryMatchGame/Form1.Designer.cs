using System.Numerics;

namespace MemoryMatch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlGameBoard = new Panel();
            btnCard20 = new Button();
            btnCard19 = new Button();
            btnCard18 = new Button();
            btnCard17 = new Button();
            btnCard16 = new Button();
            btnCard15 = new Button();
            btnCard14 = new Button();
            btnCard13 = new Button();
            btnCard12 = new Button();
            btnCard11 = new Button();
            btnCard10 = new Button();
            btnCard9 = new Button();
            btnCard8 = new Button();
            btnCard7 = new Button();
            btnCard6 = new Button();
            btnCard5 = new Button();
            btnCard4 = new Button();
            btnCard3 = new Button();
            btnCard2 = new Button();
            btnCard1 = new Button();
            lblScore = new Label();
            lblcurPlayer = new Label();
            lblTotalMatches1 = new Label();
            //lblEndGameMessage = new Label();
            btnRestart = new Button();
            lblPlayer1Score = new Label();
            lblPlayer2Score = new Label();
            lblTotalMatches2 = new Label();
            label1 = new Label();
            label2 = new Label();
            lblCurPlay = new Label();
            pnlGameBoard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlGameBoard
            // 
            pnlGameBoard.BackColor = Color.Transparent;
            pnlGameBoard.Controls.Add(btnCard20);
            pnlGameBoard.Controls.Add(btnCard19);
            pnlGameBoard.Controls.Add(btnCard18);
            pnlGameBoard.Controls.Add(btnCard17);
            pnlGameBoard.Controls.Add(btnCard16);
            pnlGameBoard.Controls.Add(btnCard15);
            pnlGameBoard.Controls.Add(btnCard14);
            pnlGameBoard.Controls.Add(btnCard13);
            pnlGameBoard.Controls.Add(btnCard12);
            pnlGameBoard.Controls.Add(btnCard11);
            pnlGameBoard.Controls.Add(btnCard10);
            pnlGameBoard.Controls.Add(btnCard9);
            pnlGameBoard.Controls.Add(btnCard8);
            pnlGameBoard.Controls.Add(btnCard7);
            pnlGameBoard.Controls.Add(btnCard6);
            pnlGameBoard.Controls.Add(btnCard5);
            pnlGameBoard.Controls.Add(btnCard4);
            pnlGameBoard.Controls.Add(btnCard3);
            pnlGameBoard.Controls.Add(btnCard2);
            pnlGameBoard.Controls.Add(btnCard1);
            pnlGameBoard.Location = new Point(56, 146);
            pnlGameBoard.Name = "pnlGameBoard";
            pnlGameBoard.Size = new Size(867, 723);
            pnlGameBoard.TabIndex = 0;
            // 
            // btnCard20
            // 
            btnCard20.BackgroundImage = (Image)resources.GetObject("btnCard20.BackgroundImage");
            btnCard20.BackgroundImageLayout = ImageLayout.Stretch;
            btnCard20.Font = new Font("Segoe UI", 12F);
            btnCard20.Location = new Point(696, 531);
            btnCard20.Name = "btnCard20";
            btnCard20.Size = new Size(150, 150);
            btnCard20.TabIndex = 19;
            btnCard20.UseVisualStyleBackColor = true;
            // 
            // btnCard19
            // 
            btnCard19.BackgroundImage = (Image)resources.GetObject("btnCard19.BackgroundImage");
            btnCard19.BackgroundImageLayout = ImageLayout.Stretch;
            btnCard19.Font = new Font("Segoe UI", 12F);
            btnCard19.Location = new Point(528, 531);
            btnCard19.Name = "btnCard19";
            btnCard19.Size = new Size(150, 150);
            btnCard19.TabIndex = 18;
            btnCard19.UseVisualStyleBackColor = true;
            // 
            // btnCard18
            // 
            btnCard18.BackgroundImage = (Image)resources.GetObject("btnCard18.BackgroundImage");
            btnCard18.BackgroundImageLayout = ImageLayout.Stretch;
            btnCard18.Font = new Font("Segoe UI", 12F);
            btnCard18.Location = new Point(190, 531);
            btnCard18.Name = "btnCard18";
            btnCard18.Size = new Size(150, 150);
            btnCard18.TabIndex = 17;
            btnCard18.UseVisualStyleBackColor = true;
            // 
            // btnCard17
            // 
            btnCard17.BackgroundImage = (Image)resources.GetObject("btnCard17.BackgroundImage");
            btnCard17.BackgroundImageLayout = ImageLayout.Stretch;
            btnCard17.Font = new Font("Segoe UI", 12F);
            btnCard17.Location = new Point(17, 531);
            btnCard17.Name = "btnCard17";
            btnCard17.Size = new Size(150, 150);
            btnCard17.TabIndex = 16;
            btnCard17.UseVisualStyleBackColor = true;
            // 
            // btnCard16
            // 
            btnCard16.BackgroundImage = (Image)resources.GetObject("btnCard16.BackgroundImage");
            btnCard16.BackgroundImageLayout = ImageLayout.Stretch;
            btnCard16.Font = new Font("Segoe UI", 12F);
            btnCard16.Location = new Point(361, 358);
            btnCard16.Name = "btnCard16";
            btnCard16.Size = new Size(150, 150);
            btnCard16.TabIndex = 15;
            btnCard16.UseVisualStyleBackColor = true;
            btnCard16.Click += Card_Click;
            // 
            // btnCard15
            // 
            btnCard15.BackgroundImage = (Image)resources.GetObject("btnCard15.BackgroundImage");
            btnCard15.BackgroundImageLayout = ImageLayout.Stretch;
            btnCard15.Font = new Font("Segoe UI", 12F);
            btnCard15.Location = new Point(696, 358);
            btnCard15.Name = "btnCard15";
            btnCard15.Size = new Size(150, 150);
            btnCard15.TabIndex = 14;
            btnCard15.UseVisualStyleBackColor = true;
            btnCard15.Click += Card_Click;
            // 
            // btnCard14
            // 
            btnCard14.BackgroundImage = (Image)resources.GetObject("btnCard14.BackgroundImage");
            btnCard14.BackgroundImageLayout = ImageLayout.Stretch;
            btnCard14.Font = new Font("Segoe UI", 12F);
            btnCard14.Location = new Point(361, 531);
            btnCard14.Name = "btnCard14";
            btnCard14.Size = new Size(150, 150);
            btnCard14.TabIndex = 13;
            btnCard14.UseVisualStyleBackColor = true;
            btnCard14.Click += Card_Click;
            // 
            // btnCard13
            // 
            btnCard13.BackgroundImage = (Image)resources.GetObject("btnCard13.BackgroundImage");
            btnCard13.BackgroundImageLayout = ImageLayout.Stretch;
            btnCard13.Font = new Font("Segoe UI", 12F);
            btnCard13.Location = new Point(190, 359);
            btnCard13.Name = "btnCard13";
            btnCard13.Size = new Size(150, 150);
            btnCard13.TabIndex = 12;
            btnCard13.UseVisualStyleBackColor = true;
            btnCard13.Click += Card_Click;
            // 
            // btnCard12
            // 
            btnCard12.BackgroundImage = (Image)resources.GetObject("btnCard12.BackgroundImage");
            btnCard12.BackgroundImageLayout = ImageLayout.Stretch;
            btnCard12.Font = new Font("Segoe UI", 12F);
            btnCard12.Location = new Point(190, 195);
            btnCard12.Name = "btnCard12";
            btnCard12.Size = new Size(150, 150);
            btnCard12.TabIndex = 11;
            btnCard12.UseVisualStyleBackColor = true;
            btnCard12.Click += Card_Click;
            // 
            // btnCard11
            // 
            btnCard11.BackgroundImage = (Image)resources.GetObject("btnCard11.BackgroundImage");
            btnCard11.BackgroundImageLayout = ImageLayout.Stretch;
            btnCard11.Font = new Font("Segoe UI", 12F);
            btnCard11.Location = new Point(17, 358);
            btnCard11.Name = "btnCard11";
            btnCard11.Size = new Size(150, 150);
            btnCard11.TabIndex = 10;
            btnCard11.UseVisualStyleBackColor = true;
            btnCard11.Click += Card_Click;
            // 
            // btnCard10
            // 
            btnCard10.BackgroundImage = (Image)resources.GetObject("btnCard10.BackgroundImage");
            btnCard10.BackgroundImageLayout = ImageLayout.Stretch;
            btnCard10.Font = new Font("Segoe UI", 12F);
            btnCard10.Location = new Point(528, 195);
            btnCard10.Name = "btnCard10";
            btnCard10.Size = new Size(150, 150);
            btnCard10.TabIndex = 9;
            btnCard10.UseVisualStyleBackColor = true;
            btnCard10.Click += Card_Click;
            // 
            // btnCard9
            // 
            btnCard9.BackgroundImage = (Image)resources.GetObject("btnCard9.BackgroundImage");
            btnCard9.BackgroundImageLayout = ImageLayout.Stretch;
            btnCard9.Font = new Font("Segoe UI", 12F);
            btnCard9.Location = new Point(696, 195);
            btnCard9.Name = "btnCard9";
            btnCard9.Size = new Size(150, 150);
            btnCard9.TabIndex = 8;
            btnCard9.UseVisualStyleBackColor = true;
            btnCard9.Click += Card_Click;
            // 
            // btnCard8
            // 
            btnCard8.BackgroundImage = (Image)resources.GetObject("btnCard8.BackgroundImage");
            btnCard8.BackgroundImageLayout = ImageLayout.Stretch;
            btnCard8.Font = new Font("Segoe UI", 12F);
            btnCard8.Location = new Point(361, 195);
            btnCard8.Name = "btnCard8";
            btnCard8.Size = new Size(150, 150);
            btnCard8.TabIndex = 7;
            btnCard8.UseVisualStyleBackColor = true;
            btnCard8.Click += Card_Click;
            // 
            // btnCard7
            // 
            btnCard7.BackgroundImage = (Image)resources.GetObject("btnCard7.BackgroundImage");
            btnCard7.BackgroundImageLayout = ImageLayout.Stretch;
            btnCard7.Font = new Font("Segoe UI", 12F);
            btnCard7.Location = new Point(17, 29);
            btnCard7.Name = "btnCard7";
            btnCard7.Size = new Size(150, 150);
            btnCard7.TabIndex = 6;
            btnCard7.UseVisualStyleBackColor = true;
            btnCard7.Click += Card_Click;
            // 
            // btnCard6
            // 
            btnCard6.BackgroundImage = (Image)resources.GetObject("btnCard6.BackgroundImage");
            btnCard6.BackgroundImageLayout = ImageLayout.Stretch;
            btnCard6.Font = new Font("Segoe UI", 12F);
            btnCard6.Location = new Point(17, 195);
            btnCard6.Name = "btnCard6";
            btnCard6.Size = new Size(150, 150);
            btnCard6.TabIndex = 5;
            btnCard6.UseVisualStyleBackColor = true;
            btnCard6.Click += Card_Click;
            // 
            // btnCard5
            // 
            btnCard5.BackgroundImage = (Image)resources.GetObject("btnCard5.BackgroundImage");
            btnCard5.BackgroundImageLayout = ImageLayout.Stretch;
            btnCard5.Font = new Font("Segoe UI", 12F);
            btnCard5.Location = new Point(696, 29);
            btnCard5.Name = "btnCard5";
            btnCard5.Size = new Size(150, 150);
            btnCard5.TabIndex = 4;
            btnCard5.UseVisualStyleBackColor = true;
            btnCard5.Click += Card_Click;
            // 
            // btnCard4
            // 
            btnCard4.BackgroundImage = (Image)resources.GetObject("btnCard4.BackgroundImage");
            btnCard4.BackgroundImageLayout = ImageLayout.Stretch;
            btnCard4.Font = new Font("Segoe UI", 12F);
            btnCard4.Location = new Point(528, 29);
            btnCard4.Name = "btnCard4";
            btnCard4.Size = new Size(150, 150);
            btnCard4.TabIndex = 3;
            btnCard4.UseVisualStyleBackColor = true;
            btnCard4.Click += Card_Click;
            // 
            // btnCard3
            // 
            btnCard3.BackgroundImage = (Image)resources.GetObject("btnCard3.BackgroundImage");
            btnCard3.BackgroundImageLayout = ImageLayout.Stretch;
            btnCard3.Font = new Font("Segoe UI", 12F);
            btnCard3.Location = new Point(361, 29);
            btnCard3.Name = "btnCard3";
            btnCard3.Size = new Size(150, 150);
            btnCard3.TabIndex = 2;
            btnCard3.UseVisualStyleBackColor = true;
            btnCard3.Click += Card_Click;
            // 
            // btnCard2
            // 
            btnCard2.BackgroundImage = (Image)resources.GetObject("btnCard2.BackgroundImage");
            btnCard2.BackgroundImageLayout = ImageLayout.Stretch;
            btnCard2.Font = new Font("Segoe UI", 12F);
            btnCard2.Location = new Point(528, 358);
            btnCard2.Name = "btnCard2";
            btnCard2.Size = new Size(150, 150);
            btnCard2.TabIndex = 1;
            btnCard2.UseVisualStyleBackColor = true;
            btnCard2.Click += Card_Click;
            // 
            // btnCard1
            // 
            btnCard1.BackgroundImage = (Image)resources.GetObject("btnCard1.BackgroundImage");
            btnCard1.BackgroundImageLayout = ImageLayout.Stretch;
            btnCard1.Font = new Font("Segoe UI", 12F);
            btnCard1.Location = new Point(190, 29);
            btnCard1.Name = "btnCard1";
            btnCard1.Size = new Size(150, 150);
            btnCard1.TabIndex = 0;
            btnCard1.UseVisualStyleBackColor = true;
            btnCard1.Click += Card_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Stencil", 18F, FontStyle.Bold);
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(76, 21);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(183, 43);
            lblScore.TabIndex = 1;
            lblScore.Text = "Turns: 0";
            // 
            // lblcurPlayer
            // 
            lblcurPlayer.BackColor = Color.Transparent;
            lblcurPlayer.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcurPlayer.ForeColor = Color.Red;
            lblcurPlayer.Location = new Point(388, 82);
            lblcurPlayer.Name = "lblcurPlayer";
            lblcurPlayer.Size = new Size(181, 54);
            lblcurPlayer.TabIndex = 2;
            lblcurPlayer.Text = "Player";
            // 
            // lblTotalMatches1
            // 
            lblTotalMatches1.AutoSize = true;
            lblTotalMatches1.BackColor = Color.FromArgb(255, 255, 192);
            lblTotalMatches1.Font = new Font("Stencil", 16F, FontStyle.Bold);
            lblTotalMatches1.ForeColor = Color.DimGray;
            lblTotalMatches1.Location = new Point(704, 98);
            lblTotalMatches1.Name = "lblTotalMatches1";
            lblTotalMatches1.Size = new Size(207, 38);
            lblTotalMatches1.TabIndex = 3;
            lblTotalMatches1.Text = "Matches: 0";
            // 
            // lblEndGameMessage
            // 
            //lblEndGameMessage.AutoSize = true;
            //lblEndGameMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            //lblEndGameMessage.ForeColor = Color.Red;
            //lblEndGameMessage.Location = new Point(89, 21);
            //lblEndGameMessage.Name = "lblEndGameMessage";
            //lblEndGameMessage.Size = new Size(0, 32);
            //lblEndGameMessage.TabIndex = 4;
            //lblEndGameMessage.Visible = false;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.Gold;
            btnRestart.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestart.ForeColor = Color.FromArgb(0, 0, 192);
            btnRestart.Location = new Point(1089, 716);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(243, 70);
            btnRestart.TabIndex = 5;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // lblPlayer1Score
            // 
            lblPlayer1Score.AutoSize = true;
            lblPlayer1Score.BackColor = Color.FromArgb(255, 255, 192);
            lblPlayer1Score.Font = new Font("Stencil", 16F, FontStyle.Bold);
            lblPlayer1Score.ForeColor = Color.DimGray;
            lblPlayer1Score.Location = new Point(704, 60);
            lblPlayer1Score.Name = "lblPlayer1Score";
            lblPlayer1Score.Size = new Size(159, 38);
            lblPlayer1Score.TabIndex = 6;
            lblPlayer1Score.Text = "Score: 0";
            // 
            // lblPlayer2Score
            // 
            lblPlayer2Score.AutoSize = true;
            lblPlayer2Score.BackColor = Color.FromArgb(255, 255, 192);
            lblPlayer2Score.Font = new Font("Stencil", 16F, FontStyle.Bold);
            lblPlayer2Score.ForeColor = Color.DimGray;
            lblPlayer2Score.Location = new Point(932, 60);
            lblPlayer2Score.Name = "lblPlayer2Score";
            lblPlayer2Score.Size = new Size(159, 38);
            lblPlayer2Score.TabIndex = 7;
            lblPlayer2Score.Text = "Score: 0";
            // 
            // lblTotalMatches2
            // 
            lblTotalMatches2.AutoSize = true;
            lblTotalMatches2.BackColor = Color.FromArgb(255, 255, 192);
            lblTotalMatches2.Font = new Font("Stencil", 16F, FontStyle.Bold);
            lblTotalMatches2.ForeColor = Color.DimGray;
            lblTotalMatches2.Location = new Point(932, 96);
            lblTotalMatches2.Name = "lblTotalMatches2";
            lblTotalMatches2.Size = new Size(207, 38);
            lblTotalMatches2.TabIndex = 8;
            lblTotalMatches2.Text = "Matches: 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Font = new Font("Stencil", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(903, 21);
            label1.Name = "label1";
            label1.Size = new Size(188, 43);
            label1.TabIndex = 9;
            label1.Text = "Player 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Font = new Font("Stencil", 18F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(675, 21);
            label2.Name = "label2";
            label2.Size = new Size(188, 43);
            label2.TabIndex = 10;
            label2.Text = "Player 1";
            // 
            // lblCurPlay
            // 
            lblCurPlay.AutoSize = true;
            lblCurPlay.BackColor = Color.Transparent;
            lblCurPlay.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurPlay.ForeColor = Color.Transparent;
            lblCurPlay.Location = new Point(76, 82);
            lblCurPlay.Name = "lblCurPlay";
            lblCurPlay.Size = new Size(319, 54);
            lblCurPlay.TabIndex = 11;
            lblCurPlay.Text = "Current Player: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1500, 900);
            Controls.Add(lblCurPlay);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTotalMatches2);
            Controls.Add(lblPlayer2Score);
            Controls.Add(lblPlayer1Score);
            Controls.Add(btnRestart);
            //Controls.Add(lblEndGameMessage);
            Controls.Add(lblTotalMatches1);
            Controls.Add(lblcurPlayer);
            Controls.Add(lblScore);
            Controls.Add(pnlGameBoard);
            DoubleBuffered = true;
            ForeColor = Color.Red;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Memory Match Game";
            pnlGameBoard.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlGameBoard;
        private Button btnCard1;
        private Button btnCard16;
        private Button btnCard15;
        private Button btnCard14;
        private Button btnCard13;
        private Button btnCard12;
        private Button btnCard11;
        private Button btnCard10;
        private Button btnCard9;
        private Button btnCard8;
        private Button btnCard7;
        private Button btnCard6;
        private Button btnCard5;
        private Button btnCard4;
        private Button btnCard3;
        private Button btnCard2;
        private Label lblScore;
        private Label lblcurPlayer;
        private Label lblTotalMatches1;
        //private Label lblEndGameMessage;
        private Button btnRestart;
        private Button btnCard20;
        private Button btnCard19;
        private Button btnCard18;
        private Button btnCard17;
        private Label lblPlayer1Score;
        private Label lblPlayer2Score;
        private Label lblTotalMatches2;
        private Label label1;
        private Label label2;
        private Label lblCurPlay;
    }
}
