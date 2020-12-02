using MyGame.GameMain.Locations.Forest;
using MyGame.GameMain.Locations.Undergrounds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.GameMain.Locations.Cities
{
    class FirstCity : Location
    {

        private static FirstCity instance { get; set; }
        public FirstCity()
        {
            this.name = "First City";
            this.levelRequirement = 0;

            this.monsters = null;
        }

        public static FirstCity getFirstCity()
        {
            if (instance == null)
                instance = new FirstCity();

            return instance;
        }
    }
}
