namespace Part_6._5
{
    partial class frmRPS
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
            this.btnRock = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.lblYourChoice = new System.Windows.Forms.Label();
            this.lblComp = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLoss = new System.Windows.Forms.Label();
            this.lblTie = new System.Windows.Forms.Label();
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.imgComp = new System.Windows.Forms.PictureBox();
            this.imgSymbol = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSymbol)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRock.Location = new System.Drawing.Point(12, 12);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(127, 65);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScissors.Location = new System.Drawing.Point(80, 83);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(127, 65);
            this.btnScissors.TabIndex = 1;
            this.btnScissors.Text = "Scissor";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaper.Location = new System.Drawing.Point(145, 12);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(127, 65);
            this.btnPaper.TabIndex = 2;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // lblYourChoice
            // 
            this.lblYourChoice.AutoSize = true;
            this.lblYourChoice.BackColor = System.Drawing.Color.Transparent;
            this.lblYourChoice.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourChoice.Location = new System.Drawing.Point(12, 163);
            this.lblYourChoice.Name = "lblYourChoice";
            this.lblYourChoice.Size = new System.Drawing.Size(136, 19);
            this.lblYourChoice.TabIndex = 3;
            this.lblYourChoice.Text = "You chose: ";
            this.lblYourChoice.Click += new System.EventHandler(this.lblYourChoice_Click);
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.BackColor = System.Drawing.Color.Transparent;
            this.lblComp.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComp.Location = new System.Drawing.Point(9, 200);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(204, 19);
            this.lblComp.TabIndex = 4;
            this.lblComp.Text = "Computer chose:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(9, 240);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 19);
            this.lblResult.TabIndex = 5;
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.BackColor = System.Drawing.Color.Transparent;
            this.lblWin.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(8, 275);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(67, 19);
            this.lblWin.TabIndex = 6;
            this.lblWin.Text = "Wins: ";
            // 
            // lblLoss
            // 
            this.lblLoss.AutoSize = true;
            this.lblLoss.BackColor = System.Drawing.Color.Transparent;
            this.lblLoss.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoss.Location = new System.Drawing.Point(8, 306);
            this.lblLoss.Name = "lblLoss";
            this.lblLoss.Size = new System.Drawing.Size(96, 19);
            this.lblLoss.TabIndex = 7;
            this.lblLoss.Text = "Losses:";
            // 
            // lblTie
            // 
            this.lblTie.AutoSize = true;
            this.lblTie.BackColor = System.Drawing.Color.Transparent;
            this.lblTie.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTie.Location = new System.Drawing.Point(8, 338);
            this.lblTie.Name = "lblTie";
            this.lblTie.Size = new System.Drawing.Size(62, 19);
            this.lblTie.TabIndex = 8;
            this.lblTie.Text = "Ties:";
            // 
            // imgPlayer
            // 
            this.imgPlayer.BackColor = System.Drawing.Color.Transparent;
            this.imgPlayer.Location = new System.Drawing.Point(308, 130);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(116, 113);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPlayer.TabIndex = 9;
            this.imgPlayer.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(335, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(127, 65);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.Text = "Reset";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(582, 308);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 59);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // imgComp
            // 
            this.imgComp.BackColor = System.Drawing.Color.Transparent;
            this.imgComp.Location = new System.Drawing.Point(553, 130);
            this.imgComp.Name = "imgComp";
            this.imgComp.Size = new System.Drawing.Size(116, 113);
            this.imgComp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgComp.TabIndex = 12;
            this.imgComp.TabStop = false;
            this.imgComp.Click += new System.EventHandler(this.imgComp_Click);
            // 
            // imgSymbol
            // 
            this.imgSymbol.BackColor = System.Drawing.Color.Transparent;
            this.imgSymbol.Location = new System.Drawing.Point(431, 130);
            this.imgSymbol.Name = "imgSymbol";
            this.imgSymbol.Size = new System.Drawing.Size(116, 113);
            this.imgSymbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSymbol.TabIndex = 13;
            this.imgSymbol.TabStop = false;
            // 
            // frmRPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Part_6._5.Properties.Resources.RPS;
            this.ClientSize = new System.Drawing.Size(681, 379);
            this.Controls.Add(this.imgSymbol);
            this.Controls.Add(this.imgComp);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.imgPlayer);
            this.Controls.Add(this.lblTie);
            this.Controls.Add(this.lblLoss);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblComp);
            this.Controls.Add(this.lblYourChoice);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnRock);
            this.Name = "frmRPS";
            this.Text = "Rock, Paper, Scissors Game";
            this.Load += new System.EventHandler(this.frmRPS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSymbol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Label lblYourChoice;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblLoss;
        private System.Windows.Forms.Label lblTie;
        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox imgComp;
        private System.Windows.Forms.PictureBox imgSymbol;
    }
}

