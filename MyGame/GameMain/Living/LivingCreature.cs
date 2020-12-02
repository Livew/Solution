using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.GameMain.Living
{
    public class LivingCreature
    {
        public int maxHp { get; set; }
        public int currentHp { get; set; }
        public int minAtk { get; set; }
        public int maxAtk { get; set; }

        public bool isAlive()
        {
            if (this.currentHp > 0) return true;

            return false;
        }
    }
}
