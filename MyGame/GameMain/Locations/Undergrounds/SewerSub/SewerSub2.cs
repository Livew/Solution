using MyGame.GameMain.Living.Monster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.GameMain.Locations.Undergrounds
{
    class SewerSub2 : Location
    {
        private static SewerSub2 instance { get; set; }
        public SewerSub2()
        {
            Rat rat = new Rat();
            BigRat bigRat = new BigRat();

            this.name = "Sewer Sub 2";
            this.levelRequirement = 2;
            this.monsters.Add(rat);
            this.monsters.Add(bigRat);

            //this.canGoTo.Add(new SewerSub1());
        }

        public static SewerSub2 getSewerSub2()
        {
            if (instance == null)
                instance = new SewerSub2();

            return instance;
        }
    }
}
