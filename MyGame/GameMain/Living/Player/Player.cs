using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.GameMain.Living.Player
{
    class Player
    {
        public int maxHp { get; set; }
        public int currentHp { get; set; }
        public int minAtk { get; set; }
        public int maxAtk { get; set; }
        public int exp { get; set; }
        public int level { get; set; }

        public Player(int maxHp, int currentHp, int minAtk, int maxAtk, int exp, int level)
        {
            this.maxHp = maxHp;
            this.currentHp = currentHp;
            this.minAtk = minAtk;
            this.maxAtk = maxAtk;
            this.exp = exp;
            this.level = level;
        }
    }
}
