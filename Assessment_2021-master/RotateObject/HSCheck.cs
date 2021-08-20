using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotateObject
{
    public partial class HSCheck : Form
    {
        public HSCheck()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            FrmHighScores FrmHighScore2 = new FrmHighScores(TxtName.Text, TxtScore.Text);
            Hide();
            FrmHighScore2.ShowDialog();
        }
    }
}
