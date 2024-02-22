using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class FormSelectcharacter : Form
    {
        Logic _logic = new Logic();
        public FormSelectcharacter()
        {
            InitializeComponent();
        }

        private void bRandom_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _logic.choosePlayer(2, this);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            _logic.choosePlayer(4, this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pbchooseStreetFighter_Click(object sender, EventArgs e)
        {
            _logic.choosePlayer(1, this);
        }

        private void pbChoosePatrick_Click(object sender, EventArgs e)
        {
            _logic.choosePlayer(3, this);
        }
    }
}
