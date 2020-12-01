using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGame.GameMain.Items.Enums;

namespace MyGame.GameMain.Items.Food
{
    class Cheese : Food
    {
        public Cheese()
        {
            this.name = "Cheese";
            this.healAmount = 2;
            this.itemType = ItemTypes.ItemType.Food;
            this.goldPrice = 10;
            this.cashPrice = 0;
            this.dropRate = 20;
        }
    }
}
