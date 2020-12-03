using MyGame.GameMain.Actions.Battle;
using MyGame.GameMain.Forms;
using MyGame.GameMain.Items.Food;
using MyGame.GameMain.Items;
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
using MyGame.GameMain.Locations;
using MyGame.GameMain.Forms.Builders;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace MyGame
{
    public partial class MainMenu : Form
    {
        private static MainMenu instance { get; set; }
        private int labelsWidth = 60;
        private int labelsLeft = 50;
        private int playerLabelLeft = 120;
        private int playerLabelTop = 25;
        private int PlayersLabelWidth = 40;
        private Player player;

        public Label playerLocationLabel;
        public Label playerExpLabel;
        public Label playerHpLabel;
        public Label playerGoldLabel;
        public ListBox playerInventoryList;
        public MainMenu()
        {
            this.player = Player.getPlayer();

            newLabel("NameLabel", "Player Name:", playerLabelTop, labelsLeft, labelsWidth, this);
            newLabel("LevelLabel", "Level:", playerLabelTop + 25, labelsLeft, labelsWidth, this);
            newLabel("HpLabel", "HP:", playerLabelTop + 50, labelsLeft, labelsWidth, this);
            newLabel("LocationLabel", "Location:", playerLabelTop + 75, labelsLeft, labelsWidth, this);
            newLabel("ExpLabel", "EXP:", playerLabelTop + 100, labelsLeft, labelsWidth, this);
            newLabel("GoldLabel", "Gold:", playerLabelTop + 125, labelsLeft, labelsWidth, this);

            newLabel("playerNameLabel", player.name, playerLabelTop, playerLabelLeft, PlayersLabelWidth, this);
            newLabel("playerLevelLabel", player.level.ToString(), playerLabelTop + 25, playerLabelLeft, PlayersLabelWidth, this);
            newLabel("playerHpLabel", player.currentHp.ToString() + "/" +player.maxHp.ToString(), playerLabelTop + 50, playerLabelLeft, PlayersLabelWidth, this);
            newLabel("playerLocationLabel", player.currentLocation.name, playerLabelTop + 75, playerLabelLeft, PlayersLabelWidth+40, this);
            newLabel("playerExpLabel", player.exp.ToString(), playerLabelTop + 100, playerLabelLeft, PlayersLabelWidth, this);
            newLabel("playerGoldLabel", player.gold.ToString(), playerLabelTop + 125, playerLabelLeft, PlayersLabelWidth, this);

            playerHpLabel = newLabel("playerHpLabel", player.currentHp.ToString() + "/" + player.maxHp.ToString(), playerLabelTop + 50, playerLabelLeft, PlayersLabelWidth, this);

            playerLocationLabel = newLabel("playerLocationLabel", player.currentLocation.name, playerLabelTop + 75, playerLabelLeft, PlayersLabelWidth + 40, this);
            changeLocationLabel(Player.getPlayer().currentLocation);
            playerInventoryList = new ListBox();
            playerInventoryList.Top = 50;
            playerInventoryList.Left = 220;
            playerInventoryList.DataSource = Player.getPlayer().GetItemsName();
            this.Controls.Add(playerInventoryList);

            InitializeComponent();
        }

        public Label newLabel(string labelName, string labelText, int labelTop, int labelLeft, int labelWidth, Form form)
        {
            Label label = new Label();
            label.Name = labelName;
            label.Text = labelText;
            label.Top = labelTop;
            label.Left = labelLeft;
            label.Width = labelWidth;

            addComponentToForm(form, label);

            return label;
        }

        public void addComponentToForm(Form form, Control control)
        {
            form.Controls.Add(control);
        }

        public void updateHealth ()
        {
            playerHpLabel.Text = "";
            //new MainMenu().Show();
        }

        //public static MainMenu getMainMenu()
        //{
        //    if (instance == null)
        //        instance = new MainMenu();

        //    return instance;
        //}

        public void addToInventory(List<Item> itens)
        {
            foreach(Item item in itens)
            {
                playerInventoryList.Items.Add(item.name);
            }
        }

        public void changeLocationLabel(Location location)
        {
            this.playerLocationLabel.Text = location.name;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Player player = Player.getPlayer();
            Cheese cheese = new Cheese(0);
            
            player.eat(cheese);
            updateHealth();
        }

        private void travelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TravelDestinations travelDestination = new TravelDestinations();
            travelDestination.Show();
        }
    }
}
