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
    public partial class frmStart : Form
    {

        public frmStart()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRPS f2 = new frmRPS();
            f2.ShowDialog();
            this.Close();
        }

        private void btnInstruct_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInst f1 = new frmInst();
            f1.ShowDialog();
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
