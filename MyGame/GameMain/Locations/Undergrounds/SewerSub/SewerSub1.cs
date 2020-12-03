using MyGame.GameMain.Living.Monster;
using MyGame.GameMain.Locations.Cities;
using MyGame.GameMain.Locations.Undergrounds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.GameMain.Locations.Undergrounds
{
    class SewerSub1 : Location
    {

        private static SewerSub1 instance { get; set; }
        public SewerSub1()
        {
            Rat rat = new Rat();
            BigRat bigRat = new BigRat();

            this.name = "Sewer Sub 1";
            this.levelRequirement = 1;
            this.monsters.Add(rat);
            this.monsters.Add(bigRat);
        }
    }
}
