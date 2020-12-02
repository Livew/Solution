using MyGame.GameMain.Living.Monster;
using MyGame.GameMain.Living.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame.GameMain.Forms.Builders
{
    class BattleBuilder
    {
        private Player player;
        private Monster monster;
        private Form form;

        private int playerLabelLeft = 50;
        private int playerLabelTop = 50;
        private int LabelWidth = 100;

        public BattleBuilder(Form form, Monster monster)
        {
            this.player = Player.getPlayer();
            this.monster = monster;
            this.form = form;

            labelBuilder();
        }

        void labelBuilder()
        {
            List<Label> labels = new List<Label>();

            Label playerNameLabel = new Label();
            playerNameLabel.Name = "playerNameLabel";
            playerNameLabel.Text = player.name;
            playerNameLabel.Top = playerLabelTop;
            playerNameLabel.Left = playerLabelLeft;
            playerNameLabel.Width = LabelWidth;
            labels.Add(playerNameLabel);

            Label playerHpLabel = new Label();
            playerHpLabel.Name = "playerHpLabel";
            playerHpLabel.Text = player.currentHp.ToString() + " / " + player.maxHp.ToString();
            playerHpLabel.Top = playerNameLabel.Top + 25;
            playerHpLabel.Left = playerNameLabel.Left;
            playerHpLabel.Width = LabelWidth;
            labels.Add(playerHpLabel);

            Label monsterNameLabel = new Label();
            monsterNameLabel.Name = "monsterNameLabel";
            monsterNameLabel.Text = monster.name;
            monsterNameLabel.Top = playerNameLabel.Top;
            monsterNameLabel.Left = playerNameLabel.Left + 150;
            monsterNameLabel.Width = LabelWidth;
            labels.Add(monsterNameLabel);

            Label monsterHpLabel = new Label();
            monsterHpLabel.Name = "monsterHpLabel";
            monsterHpLabel.Text = monster.currentHp.ToString() + " / " + monster.maxHp.ToString();
            monsterHpLabel.Top = playerNameLabel.Top + 25;
            monsterHpLabel.Left = playerNameLabel.Left + 150;
            monsterHpLabel.Width = LabelWidth;
            labels.Add(monsterHpLabel);

            foreach (Label label in labels)
            {
                form.Controls.Add(label);
            }
        }

    }
}
