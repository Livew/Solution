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

        public void changeMonsterLabelHealth(LivingCreature livingCreature)
        {
            this.form.setMonsterLabelText(getLabel("monsterHpLabel"), livingCreature.currentHp.ToString() + " / " + livingCreature.maxHp.ToString()); 
        }

        public void changePlayerLabelHealth(Player player)
        {
            this.form.setPlayerLabelText(getLabel("playerHpLabel"), player.currentHp.ToString() + " / " + player.maxHp.ToString());
        }

        Label getLabel(string label)
        {
            var control = this.form.Controls.OfType<Label>()
                           .FirstOrDefault(c => c.Name == label);

            return control;
        }
    }
}
