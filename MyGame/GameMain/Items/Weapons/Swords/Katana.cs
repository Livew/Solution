using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.GameMain.Items.Weapons.Swords
{
    class Katana : Weapon
    {
        public Katana()
        {
            this.levelRequirement = 3;
            this.minAtk = 3;
            this.maxAtK = 5;
            this.name = "Katana";
        }
    }
}
