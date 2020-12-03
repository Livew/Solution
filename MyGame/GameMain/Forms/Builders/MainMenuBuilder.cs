using MyGame.GameMain.Living.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame.GameMain.Forms.Builders
{
    class MainMenuBuilder : GenericComponentBuilder
    {

        private Player player;
        private Form form { get; set; }

        private int playerLabelLeft = 50;
        private int playerLabelTop = 50;
        private int LabelWidth = 100;
        public MainMenuBuilder()
        {
            this.player = Player.getPlayer();
            this.form = new MainMenu();

            buildLabels();
        }

        void buildLabels()
        {
            newLabel("playerNameLabel", player.name, playerLabelTop, playerLabelLeft, LabelWidth, form);
            newLabel("playerLevelLabel", player.level.ToString(), playerLabelTop + 30, playerLabelLeft, LabelWidth, form);
            newLabel("playerLocationLabel", player.currentLocation.name, playerLabelTop + 60, playerLabelLeft, LabelWidth, form);
            newLabel("playerExpLabel", player.exp.ToString(), playerLabelTop + 90, playerLabelLeft, LabelWidth, form);
            newLabel("playerGoldLabel", player.gold.ToString(), playerLabelTop + 120, playerLabelLeft, LabelWidth, form);
        }

        public void changeExpLabel()
        {
            new MainMenu().playerExpLabel.Text = Player.getPlayer().exp.ToString();
        }

        public void changeGoldLabel()
        {
            new MainMenu().playerGoldLabel.Text = Player.getPlayer().gold.ToString();
        }
    }
}
