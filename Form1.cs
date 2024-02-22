using Krypton.Toolkit;
using System.Security.Cryptography.X509Certificates;

namespace Game
{
    public partial class Form1 : Form
    {
        Logic _logic = new();
        public int currPlayer = 1;
        PictureBox[] pbArray1 = new PictureBox[4];
        PictureBox[] pbArray2 = new PictureBox[4];

        //{ pbStreetFighterLeft, pbMagierLeft, pbPatrikLeft, pbGoku };
        //{ pbStreetFighterRight, pbMagierRight, pbPatrikRight, pbGokuRight };
        public Form1()
        {
            InitializeComponent();
            pbStreetFighterLeft.Visible = false;
            pbMagierLeft.Visible = false;
            pbPatrikLeft.Visible = false;
            pbGoku.Visible = false;

            pbStreetFighterRight.Visible = false;
            pbMagierRight.Visible = false;
            pbPatrikRight.Visible = false;
            pbGokuRight.Visible = false;

            pbArray1[0] = pbStreetFighterLeft;
            pbArray1[1] = pbMagierLeft;
            pbArray1[2] = pbPatrikLeft;
            pbArray1[3] = pbGoku;

            pbArray2[0] = pbStreetFighterRight;
            pbArray2[1] = pbMagierRight;
            pbArray2[2] = pbPatrikRight;
            pbArray2[3] = pbGokuRight;

            pbArray1[Logic.player1Character - 1].Visible = true;
            pbArray2[Logic.player2Character - 1].Visible = true;
        }

        private void bSurrender_Click(object sender, EventArgs e)
            => _logic.exit();

        private void bAttack_Click(object sender, EventArgs e)
        {
            if (currPlayer == 1)
            {
                _logic.removePoints(kbProgressBarPlayer2, lDamageShowPlayer1);
                currPlayer = 2;
            }
            else
            {
                _logic.removePoints(kbProgressBarPlayer1, lDamageShowPlayer2);
                currPlayer = 1;

            }
        }

    }
}