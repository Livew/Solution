using MyGame.GameMain.Living.Monster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.GameMain.Locations
{
    public class Location
    {
        public string name { get; set; }
        public List<Monster> monsters { get; set; }
        public int levelRequirement { get; set; }

    }
}
