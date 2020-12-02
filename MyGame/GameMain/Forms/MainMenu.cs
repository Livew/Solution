using MyGame.GameMain.Actions.Battle;
using MyGame.GameMain.Forms;
using MyGame.GameMain.Items.Food;
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

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace MyGame
{
    public partial class MainMenu : Form
    {
        private static MainMenu instance { get; set; }
        public MainMenu()
        {
            InitializeComponent();
        }

        public static MainMenu getMainMenu()
        {
            if (instance == null)
                instance = new MainMenu();

            return instance;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Rat rat = new Rat();

            Battle battle = new Battle(Player.getPlayer(), rat);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            BigRat bigRat = new BigRat();

            Battle battle = new Battle(Player.getPlayer(), bigRat);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Player player = Player.getPlayer();
            Cheese cheese = new Cheese(0);

            player.eat(cheese);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
