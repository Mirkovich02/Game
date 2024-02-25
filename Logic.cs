using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Logic
    {
        public static int player1Character = 0;
        public static int player2Character = 0;
        public void exit()
            =>Application.Exit();

        private int generateZahl(int num)
        {
            Random r = new Random();
            int random = r.Next(0, num);
            return random;
        }
        public void removePoints(KryptonProgressBar kryptonProgressBar, Label label)
        {
            int damage = generateZahl(20);
            if(isPlayerDead(kryptonProgressBar, damage))
            {
                if(kryptonProgressBar.Name == "kbProgressBarPlayer1")
                {
                    MessageBox.Show("Player 2 Wins");
                }
                else if(kryptonProgressBar.Name == "kbProgressBarPlayer2")
                {
                    MessageBox.Show("Player 1 Wins");
                }
                Application.Exit();
            }
            else
            {
                label.Text = damage.ToString();
                kryptonProgressBar.Value = kryptonProgressBar.Value - damage;
            }
            
        }
        public bool isPlayerDead(KryptonProgressBar kryptonProgressBar, int damage)
        {
            if(kryptonProgressBar.Value-damage <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void choosePlayer(int num, FormSelectcharacter fsc)
        {
            if (player1Character != 0)
            {
                player2Character = num;
                var form1 = new Form1();
                form1.Show();
                fsc.Hide();
            }
            else
            {
                player1Character = num;
            }
        }

        public void showPbs(PictureBox[] pbArrayLeft, PictureBox[] pbArrayRight)
        {
            pbArrayLeft[player1Character - 1].Visible = true;
            pbArrayLeft[player2Character - 1].Visible = true;
        }
        }
    }

