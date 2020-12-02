using MyGame.GameMain.Locations.Undergrounds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGame.GameMain.Locations.Cities;
using MyGame.GameMain.Locations.Desert;

namespace MyGame.GameMain.Locations.Forest
{
    class OakForest : Location
    {
        private static OakForest instance { get; set; }
        public OakForest()
        {
            this.name = "Oak Forest";
            this.levelRequirement = 1;
        }

        public static OakForest getOakForest()
        {
            if (instance == null)
                instance = new OakForest();

            return instance;
        }
    }
}
