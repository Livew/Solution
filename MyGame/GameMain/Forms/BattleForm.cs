using MyGame.GameMain.Forms.Builders;
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
        public void setMonsterLabelText(Label label, string text)
        {
            label.Text = text;
        }

        public void setPlayerLabelText(Label label, string text)
        {
            label.Text = text;
        }

        public BattleForm(Player player, Monster monster)
        {
            new BattleBuilder(this, monster);

            InitializeComponent();
        }

        private void backToMain_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Dispose();
        }
    }
}
