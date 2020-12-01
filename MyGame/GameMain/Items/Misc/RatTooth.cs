using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.GameMain.Items.Misc
{
    class RatTooth : Item
    {
        public string name { get; set; }

        public RatTooth()
        {
            this.name = "Rat Tooth";
            this.dropRate = 10;
        }
    }
}
