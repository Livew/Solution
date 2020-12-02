using MyGame.GameMain.Living.Monster;
using MyGame.GameMain.Living.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame.GameMain.Forms
{
    public partial class BattleForm : Form
    {
        public void setMonsterLabelText(string text)
        {
            monsterHpLabel.Text = text;
        }

        public void setPlayerLabelText(string text)
        {
            playerHpLabel.Text = text;
        }

        public BattleForm(Player player, Monster monster)
        {
            InitializeComponent();

            playerNameLabel.Text = player.name;
            monsterNameLabel.Text = monster.name;

            playerHpLabel.Text = player.currentHp.ToString() + " / " + player.maxHp.ToString();
            monsterHpLabel.Text = monster.currentHp.ToString() + " / " + monster.maxHp.ToString();
        }

        private void backToMain_Click(object sender, EventArgs e)
        {
            MainMenu.getMainMenu().Show();
            this.Dispose();
        }
    }
}
