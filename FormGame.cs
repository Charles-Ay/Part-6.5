using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_6._5
{
    public partial class frmRPS : Form
    {
        public frmRPS()
        {
            InitializeComponent();
        }
        int Win = 0;
        int Loss = 0;
        int Tie = 0;
        //1 = Rock
        //2 = Paper
        //3 = Scissor

        private void lblYourChoice_Click(object sender, EventArgs e)
        {

        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            Random gen = new Random();
            int comp;

            comp = gen.Next(1, 4);
            imgPlayer.Image = Properties.Resources.rock_2 ;
            imgPlayer.BackColor = Color.White;
            if (comp == 1)
            {
                lblYourChoice.Text = "You chose: Rock";
                lblComp.Text = "Computer chose: Rock";
                lblResult.Text = "You Tie";
                Tie += 1;
                lblTie.Text = $"Ties: {Tie}";
                imgComp.Image = Properties.Resources.rock_2;
                imgSymbol.Image = Properties.Resources.equal_symbol;
            }
            else if (comp == 2)
            {
                lblYourChoice.Text = "You chose: Rock";
                lblComp.Text = "Computer chose: Paper";
                lblResult.Text = "You Lose";
                Loss += 1;
                lblLoss.Text = $"Loss: {Loss}";
                imgComp.Image = Properties.Resources.paper;
                imgSymbol.Image = Properties.Resources.less_than;
            }
            else
            {
                lblYourChoice.Text = "You chose: Rock";
                lblComp.Text = "Computer chose: Scissor";
                lblResult.Text = "You Win";
                Win += 1;
                lblWin.Text = $"Wins: {Win}";
                imgComp.Image = Properties.Resources.scissor;
                imgSymbol.Image = Properties.Resources.greater_than;

            }

        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.paper;
            Random gen = new Random();
            int comp;

            comp = gen.Next(1, 4);

            if (comp == 1)
            {
                lblYourChoice.Text = "You chose: Paper";
                lblComp.Text = "Computer chose: Rock";
                lblResult.Text = "You Win";
                Win += 1;
                lblWin.Text = $"Wins: {Win}";
                imgComp.Image = Properties.Resources.rock_2;
                imgSymbol.Image = Properties.Resources.greater_than;
            }
            else if (comp == 2)
            {
                lblYourChoice.Text = "You chose: Paper";
                lblComp.Text = "Computer chose: Paper";
                lblResult.Text = "You Tie";
                Tie += 1;
                lblTie.Text = $"Ties: {Tie}";
                imgComp.Image = Properties.Resources.paper;
                imgSymbol.Image = Properties.Resources.equal_symbol;
            }
            else
            {
                lblYourChoice.Text = "You chose: Paper";
                lblComp.Text = "Computer chose: Scissor";
                lblResult.Text = "You Lose";
                Loss += 1;
                lblLoss.Text = $"Losses: {Loss}";
                imgComp.Image = Properties.Resources.scissor;
                imgSymbol.Image = Properties.Resources.less_than;
            }

        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.scissor;
            Random gen = new Random();
            int comp;

            comp = gen.Next(1, 4);

            if (comp == 1)
            {
                lblYourChoice.Text = "You chose: Scissor";
                lblComp.Text = "Computer chose: Rock";
                lblResult.Text = "You Lose";
                Loss += 1;
                lblLoss.Text = $"Losses: {Loss}";
                imgComp.Image = Properties.Resources.rock_2;
                imgSymbol.Image = Properties.Resources.less_than;

            }
            else if (comp == 2)
            {
                lblYourChoice.Text = "You chose: Scissor";
                lblComp.Text = "Computer chose: Paper";
                lblResult.Text = "You Win";
                Win += 1;
                lblWin.Text = $"Wins: {Win}";
                imgComp.Image = Properties.Resources.paper;
                imgSymbol.Image = Properties.Resources.greater_than;
            }
            else
            {
                lblYourChoice.Text = "You chose: Scissor";
                lblComp.Text = "Computer chose: Scissor";
                lblResult.Text = "You Tie";
                Tie += 1;
                lblTie.Text = $"Ties: {Tie}";
                imgComp.Image = Properties.Resources.scissor;
                imgSymbol.Image = Properties.Resources.equal_symbol;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.Game;
            Win = 0;
            Loss = 0;
            Tie = 0;
            lblYourChoice.Text = "You chose:";
            lblComp.Text = "Computer chose:";
            lblResult.Text = "";
            lblTie.Text = "Ties:";
            lblWin.Text = "Wins:";
            lblLoss.Text = "Losses";

        }

        private void frmRPS_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStart f2 = new frmStart();
            f2.ShowDialog();
            this.Close();
        }

        private void imgComp_Click(object sender, EventArgs e)
        {

        }
    }
}
