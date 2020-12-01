using MyGame.GameMain.Living.Monster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.GameMain.Locations.Undergrounds
{
    class SewerSub1 : Location
    {
        public SewerSub1()
        {
            Rat rat = new Rat();

            this.name = "Sewer Sub 1";
            this.levelRequirement = 1;
            this.monsters.Add(rat);
        }
    }
}
