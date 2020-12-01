using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.GameMain.Living.Monster
{
    class BigRat : Monster
    {
        public BigRat()
        {
            this.name = "Big Rat";
            this.maxHp = 15;
            this.currentHp = 15;
            this.minAtk = 2;
            this.maxAtk = 3;
        }
    }
}
