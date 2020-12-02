using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGame.GameMain.Forms;
using MyGame.GameMain.Living;
using MyGame.GameMain.Living.Player;

namespace MyGame.GameMain.Actions.Battle
{
    class BattleAnimate
    {
        BattleForm form;

        public BattleAnimate(BattleForm form)
        {
            this.form = form;
            form.Show();
        }

        public void changeMonsterLabelHealth(LivingCreature monster)
        {
            this.form.setMonsterLabelText(monster.currentHp.ToString() + " / " + monster.maxHp.ToString()); 
        }

        public void changePlayerLabelHealth(Player player)
        {
            this.form.setPlayerLabelText(player.currentHp.ToString() + " / " + player.maxHp.ToString());
        }
    }
}
