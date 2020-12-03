using MyGame.GameMain.Actions.Travel;
using MyGame.GameMain.Locations;
using MyGame.GameMain.Locations.Undergrounds;
using MyGame.GameMain.Forms.Builders;
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
    public partial class TravelDestinations : Form
    {
        private int buttonStartX = 50;
        private int buttonStartY = 50;
        private int buttonWidth = 85;

        AllLocations allLocations;

        Travelling travel;
        private static TravelDestinations instance { get; set; }
        public TravelDestinations()
        {
            //TravelBuilder.getTravelBuilder(this);
            new TravelBuilder(this);

            this.travel = new Travelling();
            InitializeComponent();
        }

        private void backToMain_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Dispose();
        }

        public static TravelDestinations getTravelDestinations()
        {
            if (instance == null)
                instance = new TravelDestinations();

            return instance;
        }
    }
}
