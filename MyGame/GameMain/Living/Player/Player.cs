using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGame.GameMain.Items;
using MyGame.GameMain.Items.Food;
using MyGame.GameMain.Items.Weapons;
using MyGame.GameMain.Items.Weapons.Swords;
using MyGame.GameMain.Locations;
using MyGame.GameMain.Locations.Cities;

namespace MyGame.GameMain.Living.Player
{
    public class Player : LivingCreature
    {
        public string name { get; set; }
        public int exp { get; set; }
        public int level { get; set; }
        public int gold { get; set; }
        public List<Item> items { get; set; }
        public Location currentLocation { get; set; }
        public int maxStamina { get; set; }
        public int currentStamina { get; set; }
        private static Player instance { get; set; }
        public Weapon equippedWeapon { get; set; }
        public int baseMinAtk { get; set; }
        public int baseMaxAtk { get; set; }
        public int fightSkill { get; set; }

        public Player(string name, int maxHp, int currentHp, int exp, int level, int fightSkill, List<Item> items)
        {
            this.currentLocation = FirstCity.getFirstCity();
            this.equippedWeapon = new BasicSword();
            this.name = name;
            this.maxHp = maxHp;
            this.currentHp = currentHp;
            this.exp = exp;
            this.level = level;
            this.fightSkill = fightSkill;
            this.items = items;
            calculateMinAtk();
            calculateMaxAtk();
        }

        public List<string> GetItemsName()
        {
            List<string> itemNames = new List<string>();

            foreach (Item item in this.items)
            {
                itemNames.Add(item.name);
            }

            return itemNames;
        }

        void calculateMinAtk()
        {
            calculateBaseMinAtk();
            this.minAtk = this.equippedWeapon.minAtk + this.baseMinAtk;
        }

        void calculateMaxAtk()
        {
            calculateBaseMaxAtk();
            this.maxAtk = this.equippedWeapon.maxAtK + this.baseMaxAtk;
        }

        void calculateBaseMinAtk()
        {
            this.baseMinAtk = this.fightSkill + this.level;
        }

        void calculateBaseMaxAtk()
        {
            double sumBaseMaxAtk = (this.fightSkill * 1*5) + this.level;
            Convert.ToInt32(sumBaseMaxAtk);

            this.baseMaxAtk = Convert.ToInt32(sumBaseMaxAtk);
        }

        public static Player getPlayer()
        {
            if (instance == null)
                instance = new Player("Livew", 20, 20, 0, 1, 1, new List<Item>());

            return instance;
        }

        public static void destroyPlayer()
        {
            instance = null;
        }


        public void setPlayerLocation(Location location)
        {
            this.currentLocation = location;
        }

        public void eat(Food food)
        {
            this.currentHp += food.healAmount;
            Console.WriteLine(this.name + " Had " + (this.currentHp - food.healAmount) + " now has " + this.currentHp);
        }
    }
}
