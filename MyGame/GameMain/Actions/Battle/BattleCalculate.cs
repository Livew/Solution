using MyGame.GameMain.Living.Monster;
using MyGame.GameMain.Living.Player;
using MyGame.GameMain.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.GameMain.Actions.Battle
{
    class BattleCalculate
    {
        public Player player { get; set; }
        public Monster monster { get; set; }
        public BattleCalculate(Player player, Monster monster)
        {
            this.player = player;
            this.monster = monster;

            giveExp();
            giveGold();
            giveItems();
        }

        public void giveExp()
        {
            this.player.exp += monster.expDrop;
            Console.WriteLine("!!!!!!!! " + player.name + " Earned " + monster.expDrop + " EXP. Total EXP: " + this.player.exp);
        }

        public void giveGold()
        {
            this.player.gold += monster.goldDrop;
            Console.WriteLine("!!!!!!!! " + player.name + " Earned " + monster.goldDrop + " Gold. Total Gold: " + this.player.gold);
        }

        public void giveItems()
        {
            foreach (Item item in monster.itensWillDrop)
            {
                player.items.Add(item);
                Console.WriteLine("!!!!!!!! " + player.name + " Got " + item.name);
            }
        }
    }
}
