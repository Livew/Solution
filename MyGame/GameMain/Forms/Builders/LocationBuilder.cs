using MyGame.GameMain.Actions.Battle;
using MyGame.GameMain.Living.Monster;
using MyGame.GameMain.Living.Player;
using MyGame.GameMain.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame.GameMain.Forms.Builders
{
    class LocationBuilder
    {
        private int buttonStartX = 50;
        private int buttonStartY = 50;
        public LocationBuilder(Form form, Location location)
        {
            buttonBuild(form, location);
        }

        void buttonBuild(Form form, Location location)
        {
            foreach (Monster monster in location.monsters)
            {
                Button button = new Button();
                button.Text = monster.name;
                button.Top = buttonStartX;
                button.Left = buttonStartY;

                button.Click += (object sender, EventArgs e) =>
                {
                    form.Hide();

                    Battle battle = new Battle(Player.getPlayer(), monster);
                };

                form.Controls.Add(button);

                buttonStartX += 50;
            }
        }
    }
}
