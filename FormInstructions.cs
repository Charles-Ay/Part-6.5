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
    public partial class frmInst : Form
    {
        public frmInst()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStart f2 = new frmStart();
            f2.ShowDialog();
            this.Close();
        }

        private void lblIns_Click(object sender, EventArgs e)
        {

        }
    }
}
