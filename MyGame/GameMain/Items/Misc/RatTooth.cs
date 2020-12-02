using MyGame.GameMain.Items.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.GameMain.Items.Misc
{
    class RatTooth : Item
    {
        public RatTooth(int dropRate)
        {
            this.name = "Rat Tooth";
            this.itemType = ItemTypes.ItemType.Misc;
            calculateDropRate(dropRate);
        }

        void calculateDropRate(int rate)
        {
            this.dropRate = rate * 4;
        }
    }
}
