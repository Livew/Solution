using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGame.GameMain.Items;

namespace MyGame.GameMain.Living.Monster
{
    public class Monster : Living
    {
        public string name { get; set; }
        public List<Item> itemMayDrops { get; set; }
        public List<Item> itemWillDrops { get; set; }
        public int expDrop { get; set; }
        public int goldDrop { get; set; }
        public int cashDrop { get; set; }

        public void willDrop(Item item)
        {
            Random rnd = new Random();
            int drop = new Random().Next(0, 100);

            if (drop > item.dropRate)
            {
                this.itemWillDrops.Add(item);
            }
        }
    }
}
