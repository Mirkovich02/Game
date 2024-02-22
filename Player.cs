using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Player
    {
        KryptonProgressBar healthBar;
        static int currPlayer = 1;
        
        
        Logic _logic = new();

        Player(KryptonProgressBar healthBar)
        {
            this.healthBar = healthBar;
        }

    }

}
