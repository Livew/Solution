using MyGame.GameMain.Actions.Travel;
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
    public class TravelBuilder
    {
        private int buttonStartX = 50;
        private int buttonStartY = 50;
        private int buttonWidth = 85;
        private int labelWidth = 120;
        private AllLocations allLocations;
        private Travelling travel;

        private static TravelBuilder instance { get; set; }

        public TravelBuilder(Form form)
        {
            buttonBuild(form);

            this.travel = new Travelling();
        }

        void buttonBuild(Form form)
        {
            allLocations = new AllLocations();
            List<Location> locations = allLocations.getAllLocations();

            foreach (Location location in locations)
            {
                Button button = new Button();
                button.Text = location.name;
                button.Top = buttonStartX;
                button.Left = buttonStartY;
                button.Width = buttonWidth;

                labelBuild(button, form, location);

                if (locationEnabled(location))
                {
                    button.Enabled = true;
                }
                else
                {
                    button.Enabled = false;
                }

                button.Click += (object sender, EventArgs e) =>
                {
                    MainMenu.getMainMenu().changeLocationLabel(location);
                    form.Hide();
                    LocationForm locationForm = new LocationForm(location);
                    this.travel.travelTo(location);
                    locationForm.Show();
                };

                form.Controls.Add(button);

                buttonStartX += 30;
            }
        }

        void labelBuild(Button button, Form form, Location location)
        {
            Label label = new Label();
            label.Text = "Level Requirement:" + location.levelRequirement.ToString();

            label.Top = button.Top + 10;
            label.Left = button.Left + 90;
            label.Width = labelWidth;

            form.Controls.Add(label);
        }

        bool locationEnabled(Location location)
        {
            if (Player.getPlayer().level >= location.levelRequirement) return true;

            return false;
        }

        public static TravelBuilder getTravelBuilder(Form form)
        {
            if (instance == null)
                instance = new TravelBuilder(form);

            return instance;
        }

    }
}
