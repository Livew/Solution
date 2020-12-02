using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGame.GameMain.Items;

namespace MyGame.GameMain.Living.Monster
{
    public class Monster : LivingCreature
    {
        public string name { get; set; }
        public List<Item> itensMayDrop { get; set; }
        public List<Item> itensWillDrop { get; set; }
        public int expDrop { get; set; }
        public int goldDrop { get; set; }
        public int cashDrop { get; set; }
        private static Monster instance { get; set; }

        public Monster()
        {
            this.itensMayDrop = new List<Item>();
            this.itensWillDrop = new List<Item>();
        }

        public static Monster getMonster()
        {
            if (instance == null)
                instance = new Monster();

            return instance;
        }

        public static void destroyMonster()
        {
            instance = null;
        }

        public List<Item> willDrop(List<Item> itensMayDrop)
        {
            List<Item> itemDropList = new List<Item>();

            foreach (Item item in itensMayDrop)
            {
                //int drop = 5;
                int drop = new Random().Next(0, 100);
                if (drop <= item.dropRate)
                {
                    itemDropList.Add(item);
                }
            }

            return itemDropList;
        }
    }
}
