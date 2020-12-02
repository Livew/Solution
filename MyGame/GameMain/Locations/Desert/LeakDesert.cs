using MyGame.GameMain.Locations.Forest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.GameMain.Locations.Desert
{
    class LeakDesert : Location
    {

        private static LeakDesert instance { get; set; }
        public LeakDesert()
        {
            this.name = "Leak Desert";
            this.levelRequirement = 3;

            //this.canGoTo.Add(new OakForest());
        }

        public static LeakDesert getLeakDesert()
        {
            if (instance == null)
                instance = new LeakDesert();

            return instance;
        }
    }
}
