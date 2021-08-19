using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RotateObject
{
    public partial class EnterName : Form
    {
        string playerName;

        public EnterName()
        {
            InitializeComponent();
        }

        private void EnterName_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            playerName = txtName.Text;


            if (Regex.IsMatch(playerName, @"^[a-zA-Z]+$"))//checks playerName for letters
            {
                //if playerName valid (only letters) 
                MessageBox.Show("Starting");

                DTJS1 newform = new DTJS1();
                this.Hide();
                newform.ShowDialog();
                this.Show();

            }
            else
            {
                //invalid playerName, clear txtName and focus on it to try again
                MessageBox.Show("please enter a name using letters only!");
                txtName.Clear();

                txtName.Focus();
            }

        }
    }
}
