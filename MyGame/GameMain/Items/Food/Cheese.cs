using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGame.GameMain.Items.Enums;

namespace MyGame.GameMain.Items.Food
{
    public class Cheese : Food
    {
        public Cheese(int dropRate)
        {
            this.name = "Cheese";
            this.healAmount = 2;
            this.itemType = ItemTypes.ItemType.Food;
            this.goldPrice = 10;
            this.cashPrice = 0;
            calculateDropRate(dropRate);
        }

        void calculateDropRate(int rate)
        {
            this.dropRate = rate * 5;
        }
    }
}
