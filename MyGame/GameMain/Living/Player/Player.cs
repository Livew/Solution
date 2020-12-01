﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGame.GameMain.Items;
using MyGame.GameMain.Items.Food;
using MyGame.GameMain.Locations;

namespace MyGame.GameMain.Living.Player
{
    class Player : Living
    {
        public string name { get; set; }
        public int exp { get; set; }
        public int level { get; set; }
        public List<Item> items { get; set; }
        public Location currentLocation { get; set; }
        public int maxStamina { get; set; }
        public int currentStamina { get; set; }
        private static Player instance { get; set; }

        public Player(string name, int maxHp, int currentHp, int minAtk, int maxAtk, int exp, int level)
        {
            this.name = name;
            this.maxHp = maxHp;
            this.currentHp = currentHp;
            this.minAtk = minAtk;
            this.maxAtk = maxAtk;
            this.exp = exp;
            this.level = level;
        }

        public static Player getPlayer()
        {
            if (instance == null)
                instance = new Player("Livew", 20, 20, 3, 5, 0, 1);

            return instance;
        }

        public static void destroyPlayer()
        {
            instance = null;
        }

        public void eat(Food food)
        {
            this.currentHp += food.healAmount;
        }
    }
}
