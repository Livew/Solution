﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGame.GameMain.Items.Food;
using MyGame.GameMain.Items.Misc;
using MyGame.GameMain.Items;

namespace MyGame.GameMain.Living.Monster
{
    class BigRat : Monster
    {

        private static BigRat instance { get; set; }
        public BigRat()
        {
            Cheese cheese = new Cheese(6);
            RatTooth ratTooth = new RatTooth(5);

            itensMayDrop.Add(cheese);
            itensMayDrop.Add(ratTooth);

            this.itensWillDrop = this.willDrop(itensMayDrop);

            this.name = "Big Rat";
            this.maxHp = 15;
            this.currentHp = 15;
            this.minAtk = 2;
            this.maxAtk = 3;

            this.expDrop = 10;
            this.goldDrop = 5;
            this.cashDrop = 0;
        }

        public static BigRat getBigRat()
        {
            if (instance == null)
                instance = new BigRat();

            return instance;
        }
    }
}
