using MyGame.GameMain.Locations.Cities;
using MyGame.GameMain.Locations.Desert;
using MyGame.GameMain.Locations.Forest;
using MyGame.GameMain.Locations.Undergrounds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.GameMain.Locations
{
    public class AllLocations
    {
        public List<Location> getAllLocations()
        {
            List<Location> locations = new List<Location>();

            locations.Add(FirstCity.getFirstCity());
            locations.Add(OakForest.getOakForest());
            locations.Add(LeakDesert.getLeakDesert());
            locations.Add(SewerSub1.getSewerSub1());
            locations.Add(SewerSub2.getSewerSub2());

            return locations;
        }
    }
}
