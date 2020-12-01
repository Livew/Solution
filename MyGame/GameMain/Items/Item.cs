using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGame.GameMain.Items.Enums;

namespace MyGame.GameMain.Items
{
    class Item
    {
        public string name { get; set; }
        public ItemTypes.ItemType itemType { get; set; }
        public int goldPrice { get; set; }
        public int cashPrice { get; set; }
        public int dropRate { get; set; }
    }
}
