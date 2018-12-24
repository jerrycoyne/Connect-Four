namespace Connect4Markup
{
    partial class frmConnectFour
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.btnOKP1 = new System.Windows.Forms.Button();
            this.btnOKP2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCompleteTurn = new System.Windows.Forms.Button();
            this.txtCurrentPlayer = new System.Windows.Forms.TextBox();
            this.lblPlayerTurn = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.txtWinner = new System.Windows.Forms.TextBox();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.btnReplay = new System.Windows.Forms.Button();
            this.btnCol2 = new System.Windows.Forms.Button();
            this.btnCol3 = new System.Windows.Forms.Button();
            this.btnCol4 = new System.Windows.Forms.Button();
            this.btnCol5 = new System.Windows.Forms.Button();
            this.btnCol6 = new System.Windows.Forms.Button();
            this.btnCol7 = new System.Windows.Forms.Button();
            this.btnCol1 = new System.Windows.Forms.Button();
            this.pnlBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWelcome.Font = new System.Drawing.Font("Bauhaus 93", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(313, 18);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(544, 51);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome To Connect Four!";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(345, 93);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(201, 23);
            this.lblPlayer1.TabIndex = 1;
            this.lblPlayer1.Text = "Player 1 Enter Name: ";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(345, 135);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(201, 23);
            this.lblPlayer2.TabIndex = 2;
            this.lblPlayer2.Text = "Player 2 Enter Name: ";
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(562, 93);
            this.txtPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(100, 22);
            this.txtPlayer1.TabIndex = 0;
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Enabled = false;
            this.txtPlayer2.Location = new System.Drawing.Point(562, 137);
            this.txtPlayer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.ReadOnly = true;
            this.txtPlayer2.Size = new System.Drawing.Size(100, 22);
            this.txtPlayer2.TabIndex = 2;
            // 
            // btnOKP1
            // 
            this.btnOKP1.Font = new System.Drawing.Font("Bauhaus 93", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOKP1.Location = new System.Drawing.Point(699, 93);
            this.btnOKP1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOKP1.Name = "btnOKP1";
            this.btnOKP1.Size = new System.Drawing.Size(75, 23);
            this.btnOKP1.TabIndex = 1;
            this.btnOKP1.Text = "OK";
            this.btnOKP1.UseVisualStyleBackColor = true;
            this.btnOKP1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOKP2
            // 
            this.btnOKP2.Enabled = false;
            this.btnOKP2.Font = new System.Drawing.Font("Bauhaus 93", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOKP2.Location = new System.Drawing.Point(699, 137);
            this.btnOKP2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOKP2.Name = "btnOKP2";
            this.btnOKP2.Size = new System.Drawing.Size(75, 23);
            this.btnOKP2.TabIndex = 3;
            this.btnOKP2.Text = "OK";
            this.btnOKP2.UseVisualStyleBackColor = true;
            this.btnOKP2.Click += new System.EventHandler(this.btnOKP2_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(857, 374);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 37);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCompleteTurn
            // 
            this.btnCompleteTurn.BackColor = System.Drawing.Color.Lime;
            this.btnCompleteTurn.Location = new System.Drawing.Point(859, 151);
            this.btnCompleteTurn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompleteTurn.Name = "btnCompleteTurn";
            this.btnCompleteTurn.Size = new System.Drawing.Size(123, 39);
            this.btnCompleteTurn.TabIndex = 8;
            this.btnCompleteTurn.Text = "Complete Turn";
            this.btnCompleteTurn.UseVisualStyleBackColor = false;
            this.btnCompleteTurn.Visible = false;
            this.btnCompleteTurn.Click += new System.EventHandler(this.btnCompleteTurn_Click);
            // 
            // txtCurrentPlayer
            // 
            this.txtCurrentPlayer.Location = new System.Drawing.Point(859, 78);
            this.txtCurrentPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCurrentPlayer.Name = "txtCurrentPlayer";
            this.txtCurrentPlayer.ReadOnly = true;
            this.txtCurrentPlayer.Size = new System.Drawing.Size(121, 22);
            this.txtCurrentPlayer.TabIndex = 7;
            this.txtCurrentPlayer.Visible = false;
            // 
            // lblPlayerTurn
            // 
            this.lblPlayerTurn.AutoSize = true;
            this.lblPlayerTurn.Location = new System.Drawing.Point(855, 59);
            this.lblPlayerTurn.Name = "lblPlayerTurn";
            this.lblPlayerTurn.Size = new System.Drawing.Size(86, 17);
            this.lblPlayerTurn.TabIndex = 58;
            this.lblPlayerTurn.Text = "Player Turn:";
            this.lblPlayerTurn.Visible = false;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(855, 233);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(53, 17);
            this.lblWinner.TabIndex = 59;
            this.lblWinner.Text = "Winner";
            this.lblWinner.Visible = false;
            // 
            // txtWinner
            // 
            this.txtWinner.Location = new System.Drawing.Point(859, 262);
            this.txtWinner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWinner.Name = "txtWinner";
            this.txtWinner.ReadOnly = true;
            this.txtWinner.Size = new System.Drawing.Size(121, 22);
            this.txtWinner.TabIndex = 60;
            this.txtWinner.Visible = false;
            // 
            // pnlBoard
            // 
            this.pnlBoard.BackColor = System.Drawing.Color.Yellow;
            this.pnlBoard.Controls.Add(this.btnReplay);
            this.pnlBoard.Controls.Add(this.btnCol2);
            this.pnlBoard.Controls.Add(this.btnExit);
            this.pnlBoard.Controls.Add(this.txtWinner);
            this.pnlBoard.Controls.Add(this.btnCol3);
            this.pnlBoard.Controls.Add(this.lblWinner);
            this.pnlBoard.Controls.Add(this.btnCol4);
            this.pnlBoard.Controls.Add(this.btnCompleteTurn);
            this.pnlBoard.Controls.Add(this.lblPlayerTurn);
            this.pnlBoard.Controls.Add(this.btnCol5);
            this.pnlBoard.Controls.Add(this.txtCurrentPlayer);
            this.pnlBoard.Controls.Add(this.btnCol6);
            this.pnlBoard.Controls.Add(this.btnCol7);
            this.pnlBoard.Controls.Add(this.btnCol1);
            this.pnlBoard.Location = new System.Drawing.Point(81, 191);
            this.pnlBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(1010, 616);
            this.pnlBoard.TabIndex = 61;
            this.pnlBoard.Visible = false;
            // 
            // btnReplay
            // 
            this.btnReplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReplay.Location = new System.Drawing.Point(858, 314);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(122, 29);
            this.btnReplay.TabIndex = 61;
            this.btnReplay.Text = "Replay";
            this.btnReplay.UseVisualStyleBackColor = false;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // btnCol2
            // 
            this.btnCol2.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCol2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCol2.Location = new System.Drawing.Point(123, 16);
            this.btnCol2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCol2.Name = "btnCol2";
            this.btnCol2.Size = new System.Drawing.Size(80, 37);
            this.btnCol2.TabIndex = 1;
            this.btnCol2.Text = "Column 2";
            this.btnCol2.UseVisualStyleBackColor = false;
            this.btnCol2.Click += new System.EventHandler(this.btnCol2_Click);
            // 
            // btnCol3
            // 
            this.btnCol3.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCol3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCol3.Location = new System.Drawing.Point(245, 16);
            this.btnCol3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCol3.Name = "btnCol3";
            this.btnCol3.Size = new System.Drawing.Size(80, 37);
            this.btnCol3.TabIndex = 2;
            this.btnCol3.Text = "Column 3";
            this.btnCol3.UseVisualStyleBackColor = false;
            this.btnCol3.Click += new System.EventHandler(this.btnCol3_Click);
            // 
            // btnCol4
            // 
            this.btnCol4.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCol4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCol4.Location = new System.Drawing.Point(365, 16);
            this.btnCol4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCol4.Name = "btnCol4";
            this.btnCol4.Size = new System.Drawing.Size(80, 37);
            this.btnCol4.TabIndex = 3;
            this.btnCol4.Text = "Column 4";
            this.btnCol4.UseVisualStyleBackColor = false;
            this.btnCol4.Click += new System.EventHandler(this.btnCol4_Click);
            // 
            // btnCol5
            // 
            this.btnCol5.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCol5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCol5.Location = new System.Drawing.Point(481, 16);
            this.btnCol5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCol5.Name = "btnCol5";
            this.btnCol5.Size = new System.Drawing.Size(80, 37);
            this.btnCol5.TabIndex = 4;
            this.btnCol5.Text = "Column 5";
            this.btnCol5.UseVisualStyleBackColor = false;
            this.btnCol5.Click += new System.EventHandler(this.btnCol5_Click);
            // 
            // btnCol6
            // 
            this.btnCol6.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCol6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCol6.Location = new System.Drawing.Point(602, 16);
            this.btnCol6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCol6.Name = "btnCol6";
            this.btnCol6.Size = new System.Drawing.Size(80, 37);
            this.btnCol6.TabIndex = 5;
            this.btnCol6.Text = "Column 6";
            this.btnCol6.UseVisualStyleBackColor = false;
            this.btnCol6.Click += new System.EventHandler(this.btnCol6_Click);
            // 
            // btnCol7
            // 
            this.btnCol7.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCol7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCol7.Location = new System.Drawing.Point(724, 16);
            this.btnCol7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCol7.Name = "btnCol7";
            this.btnCol7.Size = new System.Drawing.Size(80, 37);
            this.btnCol7.TabIndex = 6;
            this.btnCol7.Text = "Column 7";
            this.btnCol7.UseVisualStyleBackColor = false;
            this.btnCol7.Click += new System.EventHandler(this.btnCol7_Click);
            // 
            // btnCol1
            // 
            this.btnCol1.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCol1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCol1.Location = new System.Drawing.Point(3, 16);
            this.btnCol1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCol1.Name = "btnCol1";
            this.btnCol1.Size = new System.Drawing.Size(80, 37);
            this.btnCol1.TabIndex = 0;
            this.btnCol1.Text = "Column 1";
            this.btnCol1.UseVisualStyleBackColor = false;
            this.btnCol1.Click += new System.EventHandler(this.btnCol1_Click);
            // 
            // frmConnectFour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1158, 830);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.btnOKP2);
            this.Controls.Add(this.btnOKP1);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmConnectFour";
            this.Text = "Connect Four";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlBoard.ResumeLayout(false);
            this.pnlBoard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.Button btnOKP1;
        private System.Windows.Forms.Button btnOKP2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCompleteTurn;
        private System.Windows.Forms.TextBox txtCurrentPlayer;
        private System.Windows.Forms.Label lblPlayerTurn;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.TextBox txtWinner;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Button btnCol2;
        private System.Windows.Forms.Button btnCol3;
        private System.Windows.Forms.Button btnCol4;
        private System.Windows.Forms.Button btnCol5;
        private System.Windows.Forms.Button btnCol6;
        private System.Windows.Forms.Button btnCol7;
        private System.Windows.Forms.Button btnCol1;
        private System.Windows.Forms.Button btnReplay;
    }
}

