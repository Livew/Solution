using MyGame.GameMain.Actions.Battle;
using MyGame.GameMain.Forms.Builders;
using MyGame.GameMain.Living.Monster;
using MyGame.GameMain.Living.Player;
using MyGame.GameMain.Locations;
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
    public partial class LocationForm : Form
    {
        private int buttonStartX = 50;
        private int buttonStartY = 50;
        public LocationForm(Location location)
        {
            new LocationBuilder(this, location);

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Dispose();
        }
    }
}
