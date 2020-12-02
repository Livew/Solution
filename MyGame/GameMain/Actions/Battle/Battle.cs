using MyGame.GameMain.Forms;
using MyGame.GameMain.Living.Monster;
using MyGame.GameMain.Living.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.GameMain.Actions.Battle
{
    class Battle
    {
        public Monster monster { get; set; }
        public Player player { get; set; }
        public BattleCalculate battleCalculate { get; set; }
        public BattleAnimate battleAnimate { get; set; }

        public Battle(Player player, Monster monster)
        {
            this.player = player;
            this.monster = monster;

            this.battleAnimate = new BattleAnimate(new BattleForm(player, monster));

            StartBattleAsync(player, monster);
        }

        public async Task StartBattleAsync(Player player, Monster monster)
        {
            while (this.monster.currentHp > 0 && this.player.currentHp > 0)
            {
                playerAttack(player, monster);
                monsterAttack(player, monster);
                await Task.Delay(2000);
            }

            BattleCalculate battleCalculate = new BattleCalculate(player, monster);
        }

        public void playerAttack(Player player, Monster monster)
        {
            int attack = new Random().Next(player.minAtk, player.maxAtk);
            monster.currentHp -= attack;
            this.battleAnimate.changeMonsterLabelHealth(monster);
            Console.WriteLine(player.name + " attacked " + monster.name + " for " + attack + " damage. " + monster.name + " Has " + monster.currentHp + " Health Points.");
        }

        public void monsterAttack(Player player, Monster monster)
        {
            int attack = new Random().Next(monster.minAtk, monster.maxAtk);
            player.currentHp -= attack;
            this.battleAnimate.changePlayerLabelHealth(player);
            Console.WriteLine(monster.name + " attacked " + player.name + " for " + attack + " damage. " + player.name + " Has " + player.currentHp + " Health Points.");
        }
    }
}
