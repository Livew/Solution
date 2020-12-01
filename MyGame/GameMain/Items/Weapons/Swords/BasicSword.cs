using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGame.GameMain.Items.Enums;

namespace MyGame.GameMain.Items.Weapons.Swords
{
    class BasicSword : Weapon
    {
        public BasicSword()
        {
            this.levelRequirement = 1;
            this.minAtk = 2;
            this.maxAtK = 4;
            this.name = "Basic Sword";
            this.goldPrice = 100;
            this.cashPrice = 5;
            this.itemType = ItemTypes.ItemType.Weapon;
        }
    }
}
