using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.GameMain.Items.Weapons
{
    class Weapon : Item
    {
        public int levelRequirement { get; set; }
        public int minAtk { get; set; }
        public int maxAtK { get; set; }
        public string name { get; set; }

    }
}
