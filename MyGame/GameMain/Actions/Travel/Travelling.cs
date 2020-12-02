using MyGame.GameMain.Locations;
using MyGame.GameMain.Living.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.GameMain.Actions.Travel
{
    class Travelling
    {
        public void travelTo(Location location) {
            Player.getPlayer().setPlayerLocation(location);
        }
    }
}
