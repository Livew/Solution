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
            Cheese cheese = new Cheese();
            RatTooth ratTooth = new RatTooth();

            //itemMayDrops.Add(cheese);
            //itemMayDrops.Add(ratTooth);

            this.name = "Rat";
            this.maxHp = 10;
            this.currentHp = 10;
            this.minAtk = 1;
            this.maxAtk = 2;

            //foreach (Item item in this.itemMayDrops)
            //{
            //    willDrop(item);
            //}
        }
    }
}
