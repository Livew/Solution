using MyGame.GameMain.Items.Food;
using MyGame.GameMain.Items.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGame.GameMain.Items;

namespace MyGame.GameMain.Living.Monster
{
    class Rat : Monster
    {
        public Rat()
        {
            Cheese cheese = new Cheese(4);
            RatTooth ratTooth = new RatTooth(4);

            itensMayDrop.Add(cheese);
            itensMayDrop.Add(ratTooth);

            this.itensWillDrop = this.willDrop(itensMayDrop);

            this.name = "Rat";
            this.maxHp = 10;
            this.currentHp = 10;
            this.minAtk = 1;
            this.maxAtk = 2;

            this.expDrop = 5;
            this.goldDrop = 2;
            this.cashDrop = 0;
        }

        public static void destroyRat()
        {
            instance = null;
        }

    }
}
